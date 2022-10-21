using Dream_Hotel.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Dream_Hotel.Design
{
    public partial class AttendencePage : Form
    {
        private DataView view;
        private DateTime Attendenceday = DateTime.Now;

        public AttendencePage()
        {
            InitializeComponent();

            dtpMain.Cal.StartDate = Attendenceday;
            dtpMain.Cal.EndDate = Attendenceday.AddMonths(11);
            dtpMain.Cal.selectedDate.Add(Attendenceday);
            dtpMain.SelectedDate = Attendenceday;

            dtpMain.Cal.DayButtonClick += (s, e) =>
            {
                Attendenceday = new DateTime(dtpMain.SelectedDate.Year, dtpMain.SelectedDate.Month, dtpMain.SelectedDate.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                view.RowFilter = "[Is Present] = True";
                InsertIntoAttendence();

                Initialize();
            };

        }


        private void AttendencePage_Load(object sender, EventArgs e)
        {
            Initialize();

            dgvAttendence.ReadOnly = true;

            dgvAttendence.Columns["Is Present"].DefaultCellStyle.SelectionBackColor = Color.Teal;
            dgvAttendence.Columns["Is Present"].DefaultCellStyle.SelectionForeColor = Color.White;
            dgvAttendence.Columns["Is Present"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvAttendence.Columns["Time Entered"].DefaultCellStyle.Format = "HH:mm:ss";
            dgvAttendence.Columns["Status"].Visible = false;
            dgvAttendence.Columns["ID"].Visible = false;

        }

        private void Initialize()
        {

            lblTime.Text = Attendenceday.ToString("HH:mm");
            view = new DataView(FetchInfo.SelectAttendenceInfo(Attendenceday));
            view.RowFilter = "Status <> ''";
            InsertIntoAttendence(true);
            

            DataTable table = FetchInfo.SelectAttendenceInfo(Attendenceday);

            DataColumn dc = new DataColumn();
            dc.DefaultValue = false;
            dc.ColumnName = "Is Present";
            dc.DataType = typeof(bool);

            table.Columns.Add(dc);

            dc = new DataColumn();
            dc.ColumnName = "Time Entered";
            dc.AllowDBNull = true;
            dc.DataType = typeof(DateTime);

            table.Columns.Add(dc);

            view = new DataView(table);
            dgvAttendence.DataSource = view;

            if( view.Count < 1)
                Methods.Display(this, "There Are No Employee", Color.Black, Color.LightGreen, new Size(200, 200), new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0) , 200);

        }

        private List<dynamic> GetList()
        {
            var attendance =
             view.ToTable().AsEnumerable()
            .Select(
              row => new
              {
                  empId = row["ID"],
                  Stas = row.Field<bool>("Is Present") ? "P" : "A",
                  EntryTime = row["Entry Time"].ToString(),
                  EnteredTime = (Convert.IsDBNull(row["Time Entered"])) ? new DateTime().ToString("HH:mm:ss") : row.Field<DateTime>("Time Entered").ToString("HH:mm:ss"),
                  RegesteredDate = Attendenceday
              }
            ).ToList();

            return attendance.ToList<dynamic>();
        }

        private void dgvAttendence_MouseEnter(object sender, EventArgs e)
        {
            dgvAttendence.Focus();
        }

        private void dgvAttendence_MouseDown(object sender, MouseEventArgs e)
        {
            int Row = dgvAttendence.HitTest(e.X, e.Y).RowIndex;
            if (Row < 0)
                return;

            var checkCell = dgvAttendence["Is Present", Row];
            checkCell.Value = checkCell.Value.ToString() == "True" ? false : true;

            var TimeEntered = dgvAttendence["Time Entered", Row];

            if (checkCell.Value.ToString() == "True")
                TimeEntered.Value = DateTime.Now;

            else
                TimeEntered.Value = DBNull.Value;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            view.RowFilter = "[Is Present] = False";
            DialogResult result = DialogResult.None;

            if (view.Count > 0)
            {
                result = MessageBox.Show("Are You Sure you want to finish?", "Warning", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                    return;
            }

            view.RowFilter = "";
            InsertIntoAttendence();
            Initialize();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            view.RowFilter = "[Is Present] = True";
            InsertIntoAttendence();

            Initialize();
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(sender as Control, "Summit the checked onces only");
        }

        private void InsertIntoAttendence(bool ForOtherReasons = false)
        {
            if (Connect.Connection.State != ConnectionState.Closed)
                Connect.Connection.Close();

            Connect.Connection.Open();

            using (SqlCommand command = new SqlCommand("InsertForAll", Connect.Connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                if (view.Count > 0)
                {
                    XElement xml;
                    if (ForOtherReasons)
                    {
                        var attend =
                            view.ToTable().AsEnumerable()
                           .Select(
                             row => new
                             {
                                 empId = row["ID"],
                                 Stas = row.Field<string>("Status"),
                                 EntryTime = new DateTime().ToString("HH:mm:ss"),
                                 EnteredTime = new DateTime().ToString("HH:mm:ss"),
                                 RegesteredDate = Attendenceday
                             }
                           ).ToList();

                        xml = Methods.ConvertToXml(attend, "");
                    }
                    else
                        xml = Methods.ConvertToXml(GetList(), "");

                    command.Parameters.Add(
                            new SqlParameter
                            {
                                ParameterName = "@xml",
                                SqlDbType = SqlDbType.Xml,
                                Value = new SqlXml(xml.CreateReader())
                            });
                    command.Parameters.AddWithValue("@table", "Attendence");
                    command.ExecuteNonQuery();
                }
                Connect.Connection.Close();
            }
        }
    }
}
