using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dream_Hotel.User_Control
{
    public partial class CustomDateTimePicker : UserControl
    {
        public DateTime SelectedDate {
            get
            {
                try {
                    return DateTime.Parse(lblShowDate.Text);
                 } catch
                { return new DateTime(); }
            }

            set
            {
                lblShowDate.Text = value.ToString("dddd , MMMM dd , yyy    ");
                Cal.selectedDate.Clear();
                Cal.selectedDate.Add(value);
                if (Cal.StartDate > value || Cal.EndDate < value)
                {
                    Cal.StartDate = value;
                    Cal.EndDate = value;
                }

                Cal.EntryDate = value;

            }
        }

        private ToolStripDropDown Drop = new ToolStripDropDown
        {
            CanOverflow = true,
            AutoClose = true,
            Margin = Padding.Empty,
            Padding = Padding.Empty,
            DropShadowEnabled = true
        };

        public CustomCalender Cal { get; set; } = new CustomCalender();

        public CustomDateTimePicker()
        {
            InitializeComponent();
            InitializeCalender();
        }

        private void InitializeCalender()
        {
            Cal.BackColor = Color.White;
            Cal.BorderStyle = BorderStyle.FixedSingle;
            Cal.DropDownMonth = false;
            Cal.EndDate = new DateTime(2063, 12, 1, 0, 0, 0, 0);
            Cal.givePriortyForRecentSelect = true;
            Cal.Name = "Cal";
            Cal.selectionAmount = 1;
            Cal.Size = new Size(290, 256);
            Cal.StartDate = new DateTime(2022, 9, 29, 19, 22, 15, 70);

            Cal.FontForDay = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cal.FontForMonth = new Font("Lucida Sans", 11F);
            Cal.FontForWeek = new Font("Arial", 9F);
            Cal.FontForYear = new Font("Lucida Sans", 11F);

            Cal.DayButtonClick += Cal_DayButtonClick;
        }

        private void Cal_DayButtonClick(object sender, PropertyChangedEventArgs e)
        {
            lblShowDate.Text = ((DateTime)sender).ToString("dddd , MMMM dd , yyy    ");

        }

        private void CustomDateTimePicker_Load(object sender, EventArgs e)
        {
            

            ToolStripControlHost t = new ToolStripControlHost(Cal);
            t.Margin = Padding.Empty;
            t.Padding = Padding.Empty;
            Cal.MinimumSize = Cal.Size;

            Drop.Size = Cal.Size;
            Drop.Items.Add(t);

            if(Cal.selectedDate.Count > 0)
            lblShowDate.Text = Cal.selectedDate[0].ToString("dddd , MMMM dd , yyy    ");

        }

        private void btnDropCal_Click(object sender, EventArgs e)
        {
            if (Drop.Visible)
                Drop.Hide();
            else
            {
                Point pt = PointToScreen(Point.Empty);

                if (Screen.PrimaryScreen.WorkingArea.Height - (pt.Y + Height + 2) <= Cal.Height)
                    pt.Offset(0, -Cal.Height - 2);
                else
                    pt.Offset(0, Height + 2);

                Drop.Show(pt);
            }
        }
    }

}
