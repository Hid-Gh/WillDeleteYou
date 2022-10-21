using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;
using System.Configuration;
using System.ComponentModel;
using System.Threading;

namespace Dream_Hotel.DataBase
{
    class FetchInfo 
    {
        public struct Room {
            public int id;
            public string name;
            public int RoomNumber;
        }

        public struct Customer
        {
            public int ID;
            public string fname;
            public string lname;
            public string gname;
            public DateTime DateOfBirth;
            public string Gender;
            public string phoneNumber;
            public string nationality;
        }

        public struct Reservation
        {
            public int ID;
            public int CustId;
            public int RoomId;
            public DateTime CheckInDate;
            public DateTime CheckOutDate;
            public bool IsPaid;
            public int NumberOfPeople;
            public int EmpId;
       }

        public struct Supplier
        {
            public int ID;
            public string Name { get; set; }
            public string phoneNumber { get; set; }
            public string City { get; set; }
            public string SubCity { get; set; }
            public string Woreda { get; set; }
            public string Kebele { get; set; }
            public string SType { get; set; }
            public string Email { get; set; }

        }


        static public List<Tuple<string, int , int>> RoomType { private set; get; }
        static public List<Room> RoomInfo { private set; get; }
        static public List<Customer> CustomerInfo { private set; get; }
        static public List<Reservation> ReservationInfo { private set; get; }

        static public event PropertyChangedEventHandler RegestrationChange;



        static public DataTable SelectDepartement()
        {
            SqlDataAdapter data = new SqlDataAdapter("Select name from Departement", Connect.Connection);

            DataTable rows = new DataTable();
            data.Fill(rows);

            return rows;

        }

        static public void SelectRoomType()
        {
            SqlDataAdapter data = new SqlDataAdapter("Select name , NumberOfPpl , color from RoomType", Connect.Connection);
            if (data == null)
                return;
            DataSet rows = new DataSet();
            data.Fill(rows, "RoomType");

            RoomType = rows.Tables["RoomType"].AsEnumerable().Select(xq => new Tuple<string, int, int>(
            xq.Field<string>("Name"),
            xq.Field<int>("NumberOfPpl"),
            xq.Field<int>("color")

            )

            ).ToList();

        }

        static public void SelectRoomInfo()
        {
            SqlDataAdapter data = new SqlDataAdapter("Select r.id , name , RoomNumber from Room r join RoomType rt on r.RoomTypeId = rt.ID", Connect.Connection);
            if (data == null)
                return;
            DataSet rows = new DataSet();
            data.Fill(rows, "Room");

            RoomInfo = rows.Tables["Room"].AsEnumerable()
                .Select(
                  row => new Room{ RoomNumber = row.Field<int>("RoomNumber"),  name = row.Field<string>("name"), id = row.Field<int>("id") }
                ).ToList();

        }

        static public void SelectCustomerInfo()
        {

            SqlDataAdapter data = new SqlDataAdapter("Select * From Customer", Connect.Connection);
            if (data == null)
                return;

            DataSet rows = new DataSet();
            data.Fill(rows, "cust");

            CustomerInfo = rows.Tables["cust"].AsEnumerable()
                .Select(
                  row => new Customer
                  {
                      ID = row.Field<int>("ID"),
                      fname = row.Field<string>("fname"),
                      lname = row.Field<string>("lname"),
                      gname = row.Field<string>("gname"),
                      DateOfBirth = row.Field<DateTime>("DateOfBirth"),
                      Gender = row.Field<string>("Gender"),
                      phoneNumber = row.Field<string>("phoneNumber"),
                      nationality = row.Field<string>("nationality")
                  }
                ).ToList();

        }

        static public void SelectReservationInfo()
        {

            SqlDataAdapter data = new SqlDataAdapter("Select * From Reservation", Connect.Connection);
            if (data == null)
                return;

            DataSet rows = new DataSet();
            data.Fill(rows, "res");

            ReservationInfo = rows.Tables["res"].AsEnumerable()
            .Select(
              row => new Reservation
              {
                  ID = row.Field<int>("ID"),
                  CustId = row.Field<int>("CustId"),
                  RoomId = row.Field<int>("RoomId"),
                  CheckInDate = row.Field<DateTime>("CheckInDate"),
                  CheckOutDate = row.Field<DateTime>("CheckOutDate"),
                  IsPaid = row.Field<bool>("IsPaid"),
                  NumberOfPeople = row.Field<int>("NumberOfPeople"),
                  EmpId = row.Field<int>("EmpId")
              }
            ).ToList();

        }

        static public DataTable SelectAttendenceInfo(DateTime date)
        {

            SqlDataAdapter data = new SqlDataAdapter("AttendenceList", Connect.Connection);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            DataSet rows = new DataSet();
            data.Fill(rows, "res");

            return rows.Tables["res"];
        }

        static public DataTable SelectViewAttendence(int month , int year)
        {

            SqlDataAdapter data = new SqlDataAdapter("DisplayAttendance", Connect.Connection);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.Add("@month", SqlDbType.Int).Value = month;
            data.SelectCommand.Parameters.Add("@year", SqlDbType.Int).Value = year;

            DataTable rows = new DataTable();
            data.Fill(rows);

            return rows;
        }

        static public List<Tuple<int , int , string, string, DateTime , string>> SelectVoucher(char c)
        {

            SqlDataAdapter data = new SqlDataAdapter("GetVoucher", Connect.Connection);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.Add("@c", SqlDbType.Char).Value = c;

            DataTable rows = new DataTable();
            data.Fill(rows);

            if (rows.Rows.Count <= 0)
                return null;

            var items = new List<Tuple<int , int , string, string, DateTime , string>>();

            foreach (DataRow row in rows.Rows)
            {
                var list = new Tuple<int , int , string, string, DateTime , string>(
                   row.Field<int>("ID"),
                   row.Field<int>("UpdateId"),
                   row.Field<string>("Cname"),
                   row.Field<string>("Type"),
                   row.Field<DateTime>("Date"),
                   "Employee ID: " + row.Field<int>("Employee ID") + "\n Full Name: " + row.Field<string>("Full Name")

                );

                items.Add(list);
            }


            return items;
        }


        static public DataTable SelectListOfProforma(int id)
        {

            SqlDataAdapter data = new SqlDataAdapter("getProforma", Connect.Connection);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

            DataTable rows = new DataTable();
            data.Fill(rows);

            return rows;
        }

        static public Supplier SelectSupplier(int id)
        {

            SqlDataAdapter data = new SqlDataAdapter("getProformaSupplier", Connect.Connection);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

            DataTable rows = new DataTable();
            data.Fill(rows);

            Supplier s = new Supplier();

            if (rows.Rows.Count <= 0)
                return s;

            foreach(DataRow row in rows.Rows)
            {

                s.ID = row.Field<int>("ID");
                s.Name = row.Field<string>("Name");
                s.phoneNumber = row.Field<string>("phoneNumber");
                s.Email = row.Field<string>("Email");
                s.City = row.Field<string>("City");
                s.SubCity = row.Field<string>("SubCity");
                s.Woreda = row.Field<string>("Woreda");
                s.Kebele = row.Field<string>("Kebele");
                s.SType = row.Field<string>("SType");

            }

            return s;
        }

        static public List<Supplier> SelectSupplier()
        {
            string query = "Select * from Supplier";
            SqlDataAdapter data = new SqlDataAdapter(query, Connect.Connection);

            DataTable rows = new DataTable();
            data.Fill(rows);

            List<Supplier> lis = new List<Supplier>();

            if (rows.Rows.Count <= 0)
                return null;

            foreach (DataRow row in rows.Rows)
            {
                lis.Add(
                    new Supplier
                    {
                        ID = row.Field<int>("ID"),
                        Name = row.Field<string>("Name"),
                        phoneNumber = row.Field<string>("phoneNumber"),
                        Email = row.Field<string>("Email"),
                        City = row.Field<string>("City"),
                        SubCity = row.Field<string>("SubCity"),
                        Woreda = row.Field<string>("Woreda"),
                        Kebele = row.Field<string>("Kebele"),
                        SType = row.Field<string>("SType")
                    });

            }

            return lis;
        }


        static public string SelectLeave(int id, DateTime date)
        {

            SqlDataAdapter data = new SqlDataAdapter("getLeaveType", Connect.Connection);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            data.SelectCommand.Parameters.Add("@date", SqlDbType.Date).Value = date;

            DataTable rows = new DataTable();
            data.Fill(rows);

            if (rows.Rows.Count <= 0)
                return "";

            string s = "Start Date: " + rows.Rows[0].Field<DateTime>("startDate") + " \n" +
                       "End Date: " + rows.Rows[0].Field<DateTime>("EndDate") + " \n" +
                       "Leave Type: " + rows.Rows[0].Field<string>("Ltype");

            return s;
        }

        static public DataTable SelectListOfProduct()
        {
            string query = "select p.ID , p.Name , pc.Name as 'Catagory Name' , pt.Name as 'Type Name' ,  MinRequirement as 'Quantity' from Product p join ProductType pt on pt.ID = p.TypeID join ProductCatogory pc on pc.ID = p.CatogoryID";

            SqlDataAdapter data = new SqlDataAdapter(query, Connect.Connection);
            DataTable rows = new DataTable();
            data.Fill(rows);

            return rows;
        }

        static public DataTable SelectEmpolyeeByDepartment(string Department)
        {
            string query = "SELECT E.ID, E.fname, E.lname,E.gname, E.Gender,E.DateOfBirth, E.phoneNumber, E.Email, E.EmergencyContactName,E.EmergencyContactPhoneNumber,E.City, E.SubCity,E.Woreda,E.Kebele,E.UserName,E.password,D.NAME as Department,E.DateOfEmployment, FROM Employee E JOIN Departement D ON E.DepId = D.ID Where D.NAME = '" + Department +"'";

            SqlDataAdapter data = new SqlDataAdapter(query, Connect.Connection);
            DataTable rows = new DataTable();
            data.Fill(rows);

            return rows;
        }

        static public DataTable SearchEmployeeByID(int EmpId)
        {
            string query = "SELECT E.ID, E.fname, E.lname,E.gname, E.Gender,E.DateOfBirth, E.phoneNumber, E.EmergencyContactName,E.EmergencyContactPhoneNumber,E.UserName,E.DateOfEmployment,D.NAME as Department FROM Employee E JOIN Departement D ON E.DepId = D.ID Where E.ID = '" + EmpId + "'";

            SqlDataAdapter data = new SqlDataAdapter(query, Connect.Connection);
            DataTable rows = new DataTable();
            data.Fill(rows);

            return rows;
        }

        static public string SelectTimeEntered(int id, DateTime date)
        {
            string query = " select EntryTime , EnteredTime from Attendence where empId = @id and Stas = 'P' and RegesteredDate = @date";

            SqlDataAdapter data = new SqlDataAdapter(query, Connect.Connection);

            data.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            data.SelectCommand.Parameters.Add("@date", SqlDbType.Date).Value = date;

            DataTable rows = new DataTable();
            data.Fill(rows);

            if (rows.Rows.Count <= 0)
                return "";

            string s = "Entry Time: " + rows.Rows[0].Field<TimeSpan>("EntryTime") + " \n" +
                       "Entered Time: " + rows.Rows[0].Field<TimeSpan>("EnteredTime");

            return s;
        }


        static public Tuple<DateTime, DateTime> SelectDateAttendence()
        {
            string query = "select min(RegesteredDate) as Minimum , max(RegesteredDate) as Maximum from Attendence";

            SqlDataAdapter data = new SqlDataAdapter(query, Connect.Connection);

            DataTable rows = new DataTable();
            data.Fill(rows);

            if (rows.Rows.Count <= 0)
                return null;

            Tuple<DateTime, DateTime> minMaxDate = new Tuple<DateTime, DateTime>(rows.Rows[0].Field<DateTime>("Minimum"), rows.Rows[0].Field<DateTime>("Maximum"));
            return minMaxDate;
        }

        static public List<Tuple<int, int, string, string, DateTime , string>> SelectHistoryOfVoucher(int UpdatedId)
        {

            SqlDataAdapter data = new SqlDataAdapter("viewHistoryOfVoucher", Connect.Connection);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.Add("@UpdatedId", SqlDbType.Int).Value = UpdatedId;

            DataTable rows = new DataTable();
            data.Fill(rows);

            if (rows.Rows.Count <= 0)
                return null;

            var items = new List<Tuple<int, int, string, string, DateTime , string>>();

            foreach (DataRow row in rows.Rows)
            {
                var list = new Tuple<int, int, string, string, DateTime , string>(
                   row.Field<int>("ID"),
                   row.Field<int>("UpdateId"),
                   row.Field<string>("Cname"),
                   row.Field<string>("Type"),
                   row.Field<DateTime>("Date"),
                   "Employee ID: " + row.Field<int>("Employee ID") + "\n Full Name: " + row.Field<string>("Full Name")
                );

                items.Add(list);
            }


            return items;
        }


        static private void sqlDependency()
        {
            SqlDependencyEx ReservationTable = new SqlDependencyEx(ConfigurationManager.ConnectionStrings["Test"].ConnectionString, "deleteme" , "Reservation", identity: 1);
            ReservationTable.TableChanged += ReservationTable_TableChanged;
            ReservationTable.Start();
        }

        static private void ReservationTable_TableChanged(object sender, SqlDependencyEx.TableChangedEventArgs e)
        {            
            CustomerInfo.Clear();
            ReservationInfo.Clear();
            
            SelectCustomerInfo();
            SelectReservationInfo();
            RegestrationChange?.Invoke(e , new PropertyChangedEventArgs("Regestration"));

        }

        static FetchInfo()
        {
            SelectRoomType();
            SelectRoomInfo();
            SelectCustomerInfo();
            SelectReservationInfo();

            sqlDependency();
        }
    }
}