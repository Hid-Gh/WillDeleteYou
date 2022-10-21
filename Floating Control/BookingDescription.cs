using Dream_Hotel.All_Methods;
using Dream_Hotel.DataBase;
using Dream_Hotel.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dream_Hotel
{
    public partial class BookingDescription : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private Point pressed;

        private ToolStripDropDown CheckInDrop = new ToolStripDropDown
        {
            CanOverflow = true,
            AutoClose = true,
            Margin = Padding.Empty,
            Padding = Padding.Empty,
            DropShadowEnabled = true
        };

        private ToolStripDropDown CheckOutDrop = new ToolStripDropDown
        {
            CanOverflow = true,
            AutoClose = true,
            Margin = Padding.Empty,
            Padding = Padding.Empty,
            DropShadowEnabled = true
        };


        #region -> Properties

        public DateTime CheckInDate {

            get { if (checkInCal.selectedDate.Count > 0) return checkInCal.selectedDate[0]; else return new DateTime(); }
            set { checkInCal.selectedDate.Clear(); checkInCal.selectedDate.Add(value); checkInCal.EntryDate = value; lblCheckInDate.Text = value.ToString("dddd , MMMM dd , yyy    "); }
        }

        public DateTime CheckOutDate {

            get { if (checkOutCal.selectedDate.Count > 0) return checkOutCal.selectedDate[0]; else return new DateTime(); } 
            set { checkOutCal.selectedDate.Clear(); checkOutCal.selectedDate.Add(value); checkOutCal.EntryDate = value; lblCheckOutDate.Text = value.ToString("dddd , MMMM dd , yyy    "); }
        }

        public string FirstName {

            get { if (txtFname.Text == txtFname.PlaceHolder && !txtFname.Writting) return ""; else return txtFname.Text; }
            set { if (Regex.IsMatch(value, @"^[a-zA-Z]+$")) txtFname.Text = value; }
        }

        public string LastName {

            get { if (txtLname.Text == txtLname.PlaceHolder && !txtLname.Writting) return ""; else return txtLname.Text; }
            set { if (Regex.IsMatch(value, @"^[a-zA-Z]+$")) txtLname.Text = value; }
        }

        public string GrandName {
            get { if (txtGname.Text == txtGname.PlaceHolder && !txtGname.Writting) return ""; else return txtGname.Text; }
            set { if (Regex.IsMatch(value, @"^[a-zA-Z]+$")) txtGname.Text = value; }
        }

        public string Nationality {

            get {return cmbNationality.SelectedItem + "";}
            set { 
                if (cmbNationality.Items.Cast<string>().Any(s => s.ToLower() == value.ToLower()))
                    cmbNationality.SelectedItem = cmbNationality.Items.Cast<string>().ToList().Find(s => s.ToLower() == value.ToLower());
            }
        }

        public int NumberOfPeople
        { 
             get { if (Regex.IsMatch(txtNoOfPeople.Text, @"^\d+$")) return int.Parse(txtNoOfPeople.Text); else return 0; }
             set { if(value > 0) txtNoOfPeople.Text = value + ""; } 
        }

        public string RoomType {

            get { return CmbRoomType.SelectedItem + "";}
            set {
                if (CmbRoomType.Items.Cast<string>().Any(s => s.ToLower() == value.ToLower()))
                    CmbRoomType.SelectedItem = CmbRoomType.Items.Cast<string>().ToList().Find(s => s.ToLower() == value.ToLower());
            }
        }

        public int RoomNumber
        {
            get{
                if (Regex.IsMatch(cmbRoomNumber.SelectedItem + "", @"^\d+$")) return int.Parse(cmbRoomNumber.SelectedItem + ""); else return 0;
            }
            set {

                if (value > 0 && cmbRoomNumber.Items.Contains(value + "")) 
                    cmbRoomNumber.SelectedItem = value + "";
            } 
        }

        public bool isPaid {

            get {return ckIsPaid.Checked; }
            set { ckIsPaid.Checked = value; }
        }

        public DateTime DateOfBirth
        {

            get { return dtpDateOfBirth.Value; }
            set { if(value < DateTime.Now) dtpDateOfBirth.Value = value; }
        }

        public string Gender
        { 
            get {return grpGender.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;}
            set {if(grpGender.Controls.OfType<RadioButton>().Any(r => r.Text.ToLower().Trim()[0] == value.ToLower().Trim()[0])) grpGender.Controls.OfType<RadioButton>().First(r => r.Text.ToLower().Trim()[0] == value.ToLower().Trim()[0]).Checked = true; }
        }

        public string phoneNumber {

            get { return txtPhoneNumber.Text; }
            set { if (Regex.IsMatch(value , @"^\d+$")) txtPhoneNumber.Text = value; }
        }

        public event PropertyChangedEventHandler Clicked;

        #endregion

        public BookingDescription()
        {
            InitializeComponent();
            
            Err.Icon = Methods.ResizeIcon(Properties.Resources.error, SystemInformation.SmallIconSize);

            CmbRoomType.Items.Clear();
            CmbRoomType.Items.AddRange(FetchInfo.RoomType.Select(t => t.Item1).ToArray()); 

            CmbRoomType.SelectedIndex = 0;

            CheckIn.MaximumSize = Size.Empty;
            checkOut.MaximumSize = Size.Empty;


            List<string> u = new List<string>();
            CultureInfo[] getCultureInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo g in getCultureInfo)
            {
                RegionInfo r = new RegionInfo(g.LCID);
                
                if(! u.Contains(r.EnglishName))
                    u.Add(r.EnglishName);
            }

            u.Sort();

            cmbNationality.DataSource = u;
            cmbNationality.SelectedIndex = cmbNationality.FindString("Ethiopia");

            dtpDateOfBirth.MaxDate = DateTime.Now;
        }

        private void BookingDescription_Load(object sender, EventArgs e)
        {
            CheckOutDrop.Items.Clear();
            CheckInDrop.Items.Clear();

            checkInCal.BorderStyle = BorderStyle.None;
            checkInCal.MinimumSize = checkInCal.Size;

            checkInCal.StartDate = DateTime.Now;
            checkInCal.EndDate = DateTime.Now.AddYears(3);

            checkOutCal.StartDate = DateTime.Now;
            checkOutCal.EndDate = DateTime.Now.AddYears(3);

            if (CheckOutDate.Date < CheckInDate.Date)
                CheckOutDate = CheckInDate;

            ToolStripControlHost t = new ToolStripControlHost(checkInCal);
            t.Margin = Padding.Empty;
            t.Padding = Padding.Empty;


            CheckInDrop.Size = checkInCal.Size;
            CheckInDrop.Items.Add(t);


            checkOutCal.BorderStyle = BorderStyle.None;
            checkOutCal.MinimumSize = checkInCal.Size;

            t = new ToolStripControlHost(checkOutCal);
            t.Margin = Padding.Empty;
            t.Padding = Padding.Empty;

            CheckOutDrop.Size = checkOutCal.Size;
            CheckOutDrop.Items.Add(t);

            lblFullDate.Text = lblCheckInDate.Text + "-    " + lblCheckOutDate.Text;

            if (CheckInDate.Date < DateTime.Now.Date)
            {
                txtPhoneNumber.BackColor = Color.White;
                
                foreach (Control c in Controls)
                {
                    if (!(c is Label) && c != btnSave && c != CheckIn && c != checkOut && c != grpGender)
                    {
                        if(c is CustomTextBox)
                             c.BackColor = Color.White;
                        c.Enabled = false;
                    }
                }
                btnShow.Enabled = false;
                btnShowCal.Enabled = false;
                rdMale.Enabled = false;
                rdFemale.Enabled = false;

                btnSave.Location = btnDelete.Location;
                btnSave.Text = "Hide";
                btnDelete.Visible = false;

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool FoundError = false;

            if (txtNoOfPeople.Text == txtNoOfPeople.PlaceHolder)
            {
                Err.SetError(txtNoOfPeople, "Number of People Can Not Be Empty");
                FoundError = true;
            }

            else if (FetchInfo.RoomType.Find(t => t.Item1 == RoomType).Item2 < int.Parse(txtNoOfPeople.Text))
            {
                int max = FetchInfo.RoomType.Find(t => t.Item1 == RoomType).Item2;

                Err.SetError(txtNoOfPeople, "Number of People Exceed Maximum Which is " + max);
                FoundError = true;
            }

            if (txtFname.Text == txtFname.PlaceHolder && !txtFname.Writting)
            {
                Err.SetError(txtFname, "Name Can not be empty");
                FoundError = true;
            }

            if (txtLname.Text == txtLname.PlaceHolder && !txtLname.Writting)
            {
                Err.SetError(txtLname, "Name Can not be empty");
                FoundError = true;
            }

            if (txtGname.Text == txtGname.PlaceHolder && !txtGname.Writting)
            {
                Err.SetError(txtGname, "Name Can not be empty");
                FoundError = true;
            }

            if (checkInCal.selectedDate.Count != 1)
            {
                Err.SetError(CheckIn, "Pick check In Date");
                FoundError = true;
            }

            if (checkOutCal.selectedDate.Count != 1)
            {
                Err.SetError(checkOut, "Pick check Out Date");
                FoundError = true;
            }

            if (cmbRoomNumber.SelectedIndex < 0)
            {
                Err.SetError(cmbRoomNumber, "Pick a room");
                FoundError = true;
            }

            if (txtPhoneNumber.Text == txtPhoneNumber.PlaceHolder)
            {
                Err.SetError(pnlPhoneNumber, "phone number Can Not Be Empty");
                FoundError = true;
            }

            if (FoundError)
                return;

            Clicked?.Invoke(this, new PropertyChangedEventArgs("Save"));

        }

        private void btnShowCal_Click(object sender, EventArgs e)
        {

            if (CheckInDrop.Visible)
                CheckInDrop.Hide();
            else
            {
                Point pt = panel2.PointToScreen(panel2.Location);

                if (Screen.PrimaryScreen.WorkingArea.Height - (pt.Y + panel2.Height + 2) <= checkInCal.Height)
                    pt.Offset(0, -checkInCal.Height - 2);
                else
                    pt.Offset(0, panel2.Height + 2);

                CheckInDrop.Show(pt);
            }

        }


        private void checkInCal_DayButtonClick(object sender, PropertyChangedEventArgs e)
        {
            if (checkOutCal.selectedDate.Count > 0 && checkOutCal.selectedDate[0].Date >= ((DateTime)sender).Date)
            {
                btnShowCal.PerformClick();
                lblCheckInDate.Text = ((DateTime)sender).ToString("dddd , MMMM dd , yyy") + "    ";
                lblFullDate.Text = lblCheckInDate.Text + "-    " + lblCheckOutDate.Text;
                Err.SetError(CheckIn, "");
            }
            else
            {
                try
                {
                    checkInCal.selectedDate.Clear();
                    checkInCal.selectedDate.Add(DateTime.Parse(lblCheckInDate.Text));
                    checkInCal.EntryDate = DateTime.Parse(lblCheckInDate.Text);

                    Err.SetError(CheckIn, "Check In Date Should Be Smaller Than Check Out Date");
                }
                catch (Exception ed) { };
            }

        }


        private void btnShow_Click(object sender, EventArgs e)
        {

            if (CheckOutDrop.Visible)
                CheckOutDrop.Hide();
            else
            {
                Point pt = panel3.PointToScreen(panel3.Location);

                if (Screen.PrimaryScreen.WorkingArea.Height - (pt.Y + panel3.Height + 2) <= checkOutCal.Height)
                    pt.Offset(0, -checkOutCal.Height - 2);
                else
                    pt.Offset(0, panel3.Height + 2);

                CheckOutDrop.Show(pt);
            }

        }

        private void checkOutCal_DayButtonClick(object sender, PropertyChangedEventArgs e)
        {
            if (checkInCal.selectedDate.Count > 0 && checkInCal.selectedDate[0].Date <= ((DateTime)sender).Date)
            {
                btnShow.PerformClick();
                lblCheckOutDate.Text = ((DateTime)sender).ToString("dddd , MMMM dd , yyy") + "    ";
                lblFullDate.Text = lblCheckInDate.Text + "-    " + lblCheckOutDate.Text;
                Err.SetError(checkOut, "");
            }
            else
            {
                try
                {
                    checkOutCal.selectedDate.Clear();
                    checkOutCal.selectedDate.Add(DateTime.Parse(lblCheckOutDate.Text));
                    checkOutCal.EntryDate = DateTime.Parse(lblCheckOutDate.Text);

                    Err.SetError(checkOut, "Check In Date Should Be Smaller Than Check Out Date");
                }
                catch (Exception ed) { };
        }

        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            CustomTextBox c = sender as CustomTextBox;

            bool check = (c.Text == c.PlaceHolder && !c.Writting);

            if (check && char.IsDigit(e.KeyChar))
            {
                if (c == txtPhoneNumber)
                    Err.SetError(pnlPhoneNumber, "");
                else
                    Err.SetError(c, "");
                return;
            }

            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.KeyChar = '\0';
        }


        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            CustomTextBox c = sender as CustomTextBox;

            if((int)e.KeyChar == 22 && Control.ModifierKeys == Keys.Control)
            {
                string paste = Clipboard.GetDataObject().GetData(DataFormats.Text) + "";

                if (Regex.IsMatch(paste, @"^[a-zA-Z]+$"))
                {
                    Err.SetError(c, "");
                    return;
                }

                else
                e.KeyChar = '\0';
            }

           else if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                Err.SetError(c, "");
                return;
            }
            else
                e.KeyChar = '\0';
        }

        private void cmbRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoomNumber.SelectedIndex >= 0)
                Err.SetError(cmbRoomNumber, "");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Clicked?.Invoke(this, new PropertyChangedEventArgs("delete"));

        }

        private void txtFname_MouseEnter(object sender, EventArgs e)
        {
            CustomTextBox t = sender as CustomTextBox;
            toolTip.SetToolTip(t , t.PlaceHolder);

        }

        private void cmbNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            var regions = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(x => new RegionInfo(x.LCID));
            var englishRegion = regions.FirstOrDefault(region => region.EnglishName.Contains(cmbNationality.SelectedItem.ToString()));
            var countryAbbrev = englishRegion.TwoLetterISORegionName.ToUpper();

            var c = ISO3166.FromAlpha2(countryAbbrev);
            if (c != null)
                txtPrefix.Text = "+" + c.DialCodes[0];
        }

        private void CmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var c = FetchInfo.RoomInfo.Where(t => t.name == CmbRoomType.SelectedItem.ToString()).Select(t => t.RoomNumber + "");
            cmbRoomNumber.Items.Clear();
            cmbRoomNumber.Items.AddRange(c.ToArray());

        }

        private void lblFullDate_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Location = new Point(Left + e.X - pressed.X , Top + e.Y - pressed.Y);
            }
        }

        private void lblFullDate_MouseDown(object sender, MouseEventArgs e)
        {
            pressed = e.Location;
        }


    }
}
