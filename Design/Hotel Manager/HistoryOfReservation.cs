using Dream_Hotel.All_Methods;
using Dream_Hotel.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dream_Hotel.Design
{
    public partial class HistoryOfReservation : Form
    {
        public HistoryOfReservation()
        {
            InitializeComponent();
            dtpMain.Cal.DayButtonClick += Cal_DayButtonClick;
        }

        private void Cal_DayButtonClick(object sender, PropertyChangedEventArgs e)
        {
            SetInfo();
        }

        private void SetInfo()
        {
            try {
                dtpMain.Cal.StartDate = FetchInfo.ReservationInfo.OrderBy(t => t.CheckInDate).Select(t => t.CheckInDate).First();
                dtpMain.Cal.EndDate = FetchInfo.ReservationInfo.OrderByDescending(t => t.CheckOutDate).Select(t => t.CheckOutDate).First();
            }
            catch { }

            var BookingInformation =
                        (from res in FetchInfo.ReservationInfo
                         join cust in FetchInfo.CustomerInfo
                          on res.CustId equals cust.ID
                         join roo in FetchInfo.RoomInfo
                         on res.RoomId equals roo.id
                         where res.CheckInDate.Date <= dtpMain.SelectedDate.Date && res.CheckOutDate.Date >= dtpMain.SelectedDate.Date
                         select new
                         {
                             First_Name = cust.fname,
                             Middle_Name = cust.lname,
                             Last_Name = cust.gname,
                             Date_Of_Birth = cust.DateOfBirth,
                             cust.Gender,
                             Phone_Number = "+" + ISO3166.FromName(cust.nationality).DialCodes[0] + " " + cust.phoneNumber,
                             Nationality = cust.nationality,
                             Is_Paid = res.IsPaid,
                             Chech_In_Date = res.CheckInDate,
                             Check_Out_Date = res.CheckOutDate,
                             Number_Of_People = res.NumberOfPeople,
                             Room_Type = roo.name,
                             Room_Number = roo.RoomNumber,
                             Employee_Id = res.EmpId
                         }).ToList();


            dgvHistory.DataSource = Methods.ToDataTable(BookingInformation); // made it sortable
            foreach (DataGridViewColumn col in dgvHistory.Columns)
            {
                if (col.HeaderText.Contains("_"))
                    col.HeaderText = col.HeaderText.Replace("_", " ");
            }
        }

        private void HistoryOfReservation_Load(object sender, EventArgs e)
        {
            dtpMain.SelectedDate = DateTime.Now;
            dgvHistory.ReadOnly = true;
            SetInfo();
        }

        private void dgvHistory_MouseEnter(object sender, EventArgs e)
        {
            (sender as Control).Focus();
        }
    }
}
