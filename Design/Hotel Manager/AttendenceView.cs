using Dream_Hotel.DataBase;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Dream_Hotel.Design
{
    public partial class AttendenceView : Form
    {
        public AttendenceView()
        {
            InitializeComponent();
        }

        private void MainCalender_calenderDateChanged(object sender, PropertyChangedEventArgs e)
        {
            setView((DateTime)sender);

        }

        private void AttendenceView_Load(object sender, EventArgs e)
        {
            setView(MainCalender.currentDate);

        }

        private void setView(DateTime t)
        {
            dgvView.DataSource = null;
            dgvView.DataSource = FetchInfo.SelectViewAttendence(t.Month, t.Year);
            if (dgvView.DataSource == null || dgvView.Rows.Count < 1)
                return;

            dgvView.Columns["id"].Visible = false;

            var minMax = FetchInfo.SelectDateAttendence();
            if(minMax != null)
            {
                MainCalender.StartDate = minMax.Item1;
                MainCalender.EndDate = minMax.Item2;
            }

            foreach (DataGridViewColumn col in dgvView.Columns)
            {
                if (Regex.IsMatch(col.HeaderText, @"^\d+$"))
                {
                    col.MinimumWidth = 30;
                    col.FillWeight = 45;
                }

                else if (col.Index == 0)
                    col.MinimumWidth = 70;
            }

        }

        private void dgvView_MouseEnter(object sender, EventArgs e)
        {
            (sender as Control).Focus();
        }

        private void dgvView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            
            if (Regex.IsMatch(dgvView.Columns[e.ColumnIndex].HeaderText, @"^\d+$"))
            {
                DateTime t = new DateTime(MainCalender.currentDate.Year , MainCalender.currentDate.Month , int.Parse( dgvView.Columns[e.ColumnIndex].HeaderText ));
                int id = int.Parse(dgvView["id", e.RowIndex].Value.ToString());

                if (dgvView[e.ColumnIndex, e.RowIndex].Value.ToString() == "L")
                {
                    string s = FetchInfo.SelectLeave(id, t);
                    dgvView[e.ColumnIndex , e.RowIndex].ToolTipText = s;
                }

                else if (dgvView[e.ColumnIndex, e.RowIndex].Value.ToString() == "P")
                {
                    string s = FetchInfo.SelectTimeEntered(id, t);
                    dgvView[e.ColumnIndex, e.RowIndex].ToolTipText = s;

                }
            }

        }
    }
}
