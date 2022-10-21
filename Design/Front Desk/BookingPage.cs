using Dream_Hotel.DataBase;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Threading;
using System.Configuration;

namespace Dream_Hotel
{
    public partial class BookingPage : Form
    {
        private int staticColumn = 2;
        private BookedDetail book;
        private List<BookedDetail> reservedBook = new List<BookedDetail>();
        public delegate void InvokeDelegate(SqlDependencyEx.TableChangedEventArgs e);

        #region .. code for Flucuring ..
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion

        public BookingPage()
        {
            InitializeComponent();

            Load += BookingPage_Load;

            DisplayDay.Dock = DockStyle.None;
            DisplayDay.Location = Point.Empty;

            HeaderTable.Dock = DockStyle.None;
            HeaderTable.Location = Point.Empty;

            DisplayBody.HorizontalScroll.SmallChange = 50;
            DisplayDay.MouseWheel += Methods.Horizontal_Scrolling;

            FetchInfo.RegestrationChange += new PropertyChangedEventHandler( FetchInfo_RegestrationChange );

        }


        private void FetchInfo_RegestrationChange(object sender, PropertyChangedEventArgs e)
        {
            this.BeginInvoke(new InvokeDelegate(Notify) , (SqlDependencyEx.TableChangedEventArgs) sender);
        }

        private void Notify(SqlDependencyEx.TableChangedEventArgs e)
        {

            var deleted = e.Data.Element("deleted");

            if (deleted != null) //delete the deleted values
            {

                var IDS = deleted.Elements("row").Select(d => d.Element("ID").Value).ToList();
                foreach (var id in IDS)
                    reservedBook.RemoveAll(t => t.Id == int.Parse(id));
            }

            var inserted = e.Data.Element("inserted");  ///only load the new inserted values
            if (inserted != null)
            {
                var IDS = inserted.Elements("row").Select(d => d.Element("ID").Value).ToList();

                var BookingInformation =
                        from res in FetchInfo.ReservationInfo
                        join cust in FetchInfo.CustomerInfo
                         on res.CustId equals cust.ID
                        join roo in FetchInfo.RoomInfo
                        on res.RoomId equals roo.id
                        where
                              IDS.Contains(res.ID+"")
                        select new
                        {
                            res.ID,
                            res.CustId,
                            cust.fname,
                            cust.lname,
                            cust.gname,
                            cust.DateOfBirth,
                            cust.Gender,
                            cust.phoneNumber,
                            cust.nationality,
                            res.IsPaid,
                            res.CheckInDate,
                            res.CheckOutDate,
                            res.NumberOfPeople,
                            roo.name,
                            roo.RoomNumber
                        };

                foreach (var row in BookingInformation)
                {
                    BookedDetail book;
                    if (DisplayDay.Controls.OfType<BookedDetail>() != null && DisplayDay.Controls.OfType<BookedDetail>().Any(t => t.Id == row.ID))
                    {
                        book = DisplayDay.Controls.OfType<BookedDetail>().Where(t => t.Id == row.ID).First();
                        if(book.Detail == null)
                            book.Detail = new BookingDescription();

                    }
                    else
                    {
                        book = new BookedDetail();
                        book.Id = row.ID;
                        book.Detail = new BookingDescription();

                    }
                    book.CustId = row.CustId;
                    book.Detail.FirstName = row.fname;
                    book.Detail.LastName = row.lname;
                    book.Detail.GrandName = row.gname;
                    book.Detail.DateOfBirth = row.DateOfBirth;
                    book.Detail.Gender = row.Gender;
                    book.Detail.phoneNumber = row.phoneNumber;
                    book.Detail.Nationality = row.nationality;
                    book.Detail.isPaid = row.IsPaid;
                    book.Detail.CheckInDate = row.CheckInDate;
                    book.Detail.CheckOutDate = row.CheckOutDate;
                    book.Detail.NumberOfPeople = row.NumberOfPeople;
                    book.Detail.RoomType = row.name;
                    book.Detail.RoomNumber = row.RoomNumber;
                    book.Detail = book.Detail;

                    if (DisplayDay.Controls.OfType<BookedDetail>() != null && DisplayDay.Controls.OfType<BookedDetail>().Any(t => t.Id == row.ID))
                        setPositionBasedOnDate(book, book.Detail);

                    else
                    {
                        book.Dock = DockStyle.Fill;
                        book.Margin = new Padding(1, 1, 1, 1);
                    }
                    reservedBook.Add(book);
                }
            }


            removeDeletedReservation();

            AddedReserved();

        }

        private void removeDeletedReservation(bool removeAll = false)
        {
            for (int i = 0; i < DisplayDay.Controls.Count; i++)
            {
                if (DisplayDay.Controls[i] is BookedDetail)
                {
                    if (removeAll)
                    {
                        DisplayDay.Controls[i].Parent = null;
                        i--;
                    }
                    else
                    {
                        bool isOpened = ((BookedDetail)DisplayDay.Controls[i]).Detail != null;

                        if (isOpened && !reservedBook.Any(t => t.Id == ((BookedDetail)DisplayDay.Controls[i]).Id) && ((BookedDetail)DisplayDay.Controls[i]).Detail.Visible)
                            ((BookedDetail)DisplayDay.Controls[i]).Detail.Close();

                        if (!reservedBook.Any(t => t.Id == ((BookedDetail)DisplayDay.Controls[i]).Id))
                        {
                            DisplayDay.Controls[i].Parent = null;
                            i--;
                        }
                    }
                }
            }
        }

        private void LoadReserved()
        {
            reservedBook.Clear();
            var BookingInformation =
                        from res in FetchInfo.ReservationInfo
                        join cust in FetchInfo.CustomerInfo
                         on res.CustId equals cust.ID
                        join roo in FetchInfo.RoomInfo
                        on res.RoomId equals roo.id
                        where
                             new DateTime(res.CheckInDate.Year, res.CheckInDate.Month, 1) >= new DateTime(MainCalender.StartDate.Year, MainCalender.StartDate.Month, 1)
                        select new
                        {
                            res.ID,
                            res.CustId,
                            cust.fname,
                            cust.lname,
                            cust.gname,
                            cust.DateOfBirth,
                            cust.Gender,
                            cust.phoneNumber,
                            cust.nationality,
                            res.IsPaid,
                            res.CheckInDate,
                            res.CheckOutDate,
                            res.NumberOfPeople,
                            roo.name,
                            roo.RoomNumber
                        };

            foreach (var row in BookingInformation)
            {
                BookedDetail book = new BookedDetail();
                book.Id = row.ID;
                book.CustId = row.CustId;
                book.Detail = new BookingDescription();
                book.Detail.FirstName = row.fname;
                book.Detail.LastName = row.lname;
                book.Detail.GrandName = row.gname;
                book.Detail.DateOfBirth = row.DateOfBirth;
                book.Detail.Gender = row.Gender;
                book.Detail.phoneNumber = row.phoneNumber;
                book.Detail.Nationality = row.nationality;
                book.Detail.isPaid = row.IsPaid;
                book.Detail.CheckInDate = row.CheckInDate;
                book.Detail.CheckOutDate = row.CheckOutDate;
                book.Detail.NumberOfPeople = row.NumberOfPeople;
                book.Detail.RoomType = row.name;
                book.Detail.RoomNumber = row.RoomNumber;
                book.Detail = book.Detail;

                book.Dock = DockStyle.Fill;
                book.Margin = new Padding(1, 1, 1, 1);
                reservedBook.Add(book);
            }

        }

        void setRow(TableLayoutPanel t)
        {
            int count = 0;
            foreach (var row in FetchInfo.RoomInfo.OrderBy(tt => tt.name))
            {
                t.RowStyles.Add(new RowStyle(SizeType.Absolute, 54));

                for (int j = 0; j < staticColumn; j++)
                {
                    Label v = new Label
                    {
                        Font = new Font("Monotype Corsiva", 12.5F, FontStyle.Italic),
                        Dock = DockStyle.Fill,
                        Margin = new Padding(0),
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    if (j == 0)
                        v.Text = row.RoomNumber + "";
                    else
                        v.Text = row.name + "";

                    t.Controls.Add(v, j, count);
                }
                count++;
            }
            DisplayDay.RowCount = count;
        }


        private void BookingPage_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            MainCalender.StartDate = DateTime.Now;
            MainCalender.EndDate = DateTime.Now.AddYears(3);

            int MaxDay = 31 , RowSize = 48;

            Methods.SetDoubleBuffered(DisplayDay);
            Methods.SetDoubleBuffered(HeaderTable);

            Methods.clearTable(HeaderTable);
            Methods.createRow(HeaderTable, 1, SizeType.Absolute, RowSize);
            Methods.createRow(HeaderTable, 1, SizeType.Absolute, HeaderPanel.Height - RowSize - 5);

            Methods.createColumn(HeaderTable, staticColumn, SizeType.Absolute);
            Methods.createColumn(HeaderTable, MaxDay, SizeType.Absolute);

            Methods.clearTable(DisplayDay);
            Methods.createColumn(DisplayDay, staticColumn, SizeType.Absolute);
            Methods.createColumn(DisplayDay, MaxDay, SizeType.Absolute);

            HeaderTable.Controls.Add(lblDate); //Add the Date Label
            HeaderTable.SetColumnSpan(lblDate, HeaderTable.ColumnCount);

            for (int i = 0; i < MaxDay + staticColumn ; i++)  //Add day text
            {
                Label l = new Label
                {
                    Text = (i - staticColumn + 1) + "",
                    Font = new Font("Monotype Corsiva", 12.5F, (FontStyle.Bold | FontStyle.Italic)),
                    Dock = DockStyle.Fill,
                    Margin = new Padding(0),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                if (i < staticColumn)
                {
                    if (i == 0)
                        l.Text = "Room Number";
                    else
                        l.Text = "Room Type";
                }
                HeaderTable.Controls.Add(l);
            }

            setRow(DisplayDay);

            ChangeColumnAmount();
            LoadReserved();
            AddedReserved();

            this.ActiveControl = DisplayDay;
 
        }

        private void TableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if((MainCalender.StartDate.Year == MainCalender.currentDate.Year && MainCalender.StartDate.Month == MainCalender.currentDate.Month) && e.Column > staticColumn - 1 && MainCalender.StartDate.Day > ((e.Column - staticColumn) + 1 ))
              e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb( 45 , 45 , 45)), e.CellBounds);

            else if (MainCalender.GetWeekends().Contains( (e.Column - staticColumn) + 1))
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);

        }

        private void DisplayDay_MouseEnter(object sender, EventArgs e)
        {
            (sender as Control).Focus();
        }



        private void DisplayDay_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TableLayoutPanel t = sender as TableLayoutPanel;
                Point p = Methods.GetIndex(t, e.Location);

                if ((MainCalender.StartDate.Year == MainCalender.currentDate.Year && MainCalender.StartDate.Month == MainCalender.currentDate.Month) && MainCalender.StartDate.Day > p.X - staticColumn + 1)
                    return;

                if (p.X == -1 || p.Y == -1)
                    return;
                book = new BookedDetail();
                
                string RoomType = DisplayDay.GetControlFromPosition(1, p.Y).Text;
                int color = FetchInfo.RoomType.Find(tt => tt.Item1 == RoomType).Item3;
                book.BackColor = Color.FromArgb(color);
                
                book.Dock = DockStyle.Fill;
                book.Margin = new Padding(1, 1, 1, 1);
                t.Controls.Add(book, p.X, p.Y);
            }
        }

        private void DisplayDay_MouseMove(object sender, MouseEventArgs e)
        {
            if (book == null)
                return;

            TableLayoutPanel t = sender as TableLayoutPanel;
            int column = t.GetCellPosition(book).Column;

            int newCol = Methods.GetIndex(t, e.Location).X;


            if (e.Button == MouseButtons.Left)
            {
                if (Methods.FindControlInRange(column, newCol, book, t, t.GetRow(book)))
                    return;

                if (newCol > column && (t.ColumnCount - column != 1))
                {
                    int XforNextToBook = 0;
                    if (t.GetColumnWidths().Length > column + 1)
                    {
                        XforNextToBook = t.GetColumnWidths()[column] + book.Location.X - book.Margin.Left;
                        XforNextToBook += t.GetColumnWidths()[column + 1] / 2;
                    }
                    if (XforNextToBook > e.X)
                        t.SetColumnSpan(book, newCol - column);
                    else
                        t.SetColumnSpan(book, newCol - column + 1);
                }

                else if (newCol < column && newCol >= 0)
                {
                    if ((MainCalender.StartDate.Year == MainCalender.currentDate.Year && MainCalender.StartDate.Month == MainCalender.currentDate.Month) &&  MainCalender.StartDate.Day > newCol - staticColumn + 1)
                        return;

                    t.Controls.Add(book, newCol, t.GetRow(book));
                    t.SetColumnSpan(book, t.GetColumnSpan(book) + column - newCol);
                }

            }
        }

        private void DisplayDay_MouseUp(object sender, MouseEventArgs e)
        {
            if (book != null)
            {
                BookingDescription bookDesc = new BookingDescription();

                if (DisplayDay.GetPositionFromControl(book).Column - staticColumn + 1 > 0)
                     bookDesc.CheckInDate = new DateTime(MainCalender.currentDate.Year, MainCalender.currentDate.Month, DisplayDay.GetPositionFromControl(book).Column - staticColumn + 1);

                if (DisplayDay.GetPositionFromControl(book).Column - staticColumn + DisplayDay.GetColumnSpan(book) > 0)
                    bookDesc.CheckOutDate = new DateTime(MainCalender.currentDate.Year, MainCalender.currentDate.Month, DisplayDay.GetPositionFromControl(book).Column - staticColumn + DisplayDay.GetColumnSpan(book));

                int RoomNumber = DisplayDay.GetPositionFromControl(book).Row;
                bookDesc.RoomType = DisplayDay.GetControlFromPosition(1, RoomNumber).Text;
                bookDesc.RoomNumber = int.Parse(DisplayDay.GetControlFromPosition(0, RoomNumber).Text);

                bookDesc.Clicked += BookDesc_Clicked;
                bookDesc.ShowDialog(this);
            }
        }

        public void BookAltered(BookedDetail book) ///WHEN BOOKDETAIL HAS BEEN RESIZED SO WE CHANGE INFO ACCORDINGLY
        {
            BookingDescription bookDesc = book.Detail;

            DateTime CheckInDate = new DateTime(MainCalender.currentDate.Year, MainCalender.currentDate.Month, DisplayDay.GetPositionFromControl(book).Column - staticColumn + 1);
            DateTime CheckOutDate = new DateTime(MainCalender.currentDate.Year, MainCalender.currentDate.Month, DisplayDay.GetPositionFromControl(book).Column - staticColumn + DisplayDay.GetColumnSpan(book));

            int room = DisplayDay.GetPositionFromControl(book).Row;

            string RoomType = DisplayDay.GetControlFromPosition(1, room).Text;
            int RoomNumber = int.Parse(DisplayDay.GetControlFromPosition(0, room).Text);


            int RoomId = FetchInfo.RoomInfo.Where(t =>
                        t.name == RoomType && t.RoomNumber == RoomNumber
                        ).Select(t => t.id).First();


            if (new DateTime(MainCalender.StartDate.Year, MainCalender.StartDate.Month, 1) == new DateTime(MainCalender.currentDate.Year, MainCalender.currentDate.Month, 1))
            {
                if(DisplayDay.GetPositionFromControl(book).Column - staticColumn + 1 < MainCalender.StartDate.Day)
                {
                    setPositionBasedOnDate(book, bookDesc);
                    return;
                }
            }

                if (DisplayDay.GetPositionFromControl(book).Column - staticColumn + 1 > 0)
            {
                if ((DisplayDay.GetPositionFromControl(book).Column - staticColumn + 1 > 1) || new DateTime(bookDesc.CheckInDate.Year, bookDesc.CheckInDate.Month, 1) == new DateTime(MainCalender.currentDate.Year, MainCalender.currentDate.Month, 1))
                    bookDesc.CheckInDate = CheckInDate;
            }
            if (DisplayDay.GetPositionFromControl(book).Column - staticColumn + DisplayDay.GetColumnSpan(book) > 0)
            {
                if ((DisplayDay.GetPositionFromControl(book).Column + DisplayDay.GetColumnSpan(book) < DisplayDay.ColumnCount) || new DateTime(bookDesc.CheckOutDate.Year, bookDesc.CheckOutDate.Month, 1) == new DateTime(MainCalender.currentDate.Year, MainCalender.currentDate.Month, 1))
                    bookDesc.CheckOutDate = CheckOutDate;
            }

            bookDesc.RoomType = RoomType;
            bookDesc.RoomNumber = RoomNumber;

            book.Detail = bookDesc;


            FetchInfo.Reservation res = new FetchInfo.Reservation();
            res.CheckInDate = book.Detail.CheckInDate;
            res.CheckOutDate = book.Detail.CheckOutDate;
            res.RoomId = RoomId;
            res.ID = book.Id;
            res.EmpId = SignIn_Page.Id;

            List<FetchInfo.Reservation> u = new List<FetchInfo.Reservation> { res };
            var c = u.Select(t => new { t.CheckInDate, t.CheckOutDate, t.RoomId, t.ID }).ToList();

            var xmlRes = Methods.ConvertToXml(c, "ID");


            Methods.cudOperation(xmlRes , "UPDATEForAll" , "Reservation");

        }

        public bool setPositionBasedOnDate(BookedDetail book , BookingDescription bookDesc) ///WHEN INFO IS CHANGED SO WE CHANGE POISITION ACCORDINGLY
        {
            int dateStart = 0, dateEnd = 0 , Row = 0;
            bool needsFix = false;

            if (new DateTime(bookDesc.CheckInDate.Year, bookDesc.CheckInDate.Month, 1) <= new DateTime(MainCalender.currentDate.Year, MainCalender.currentDate.Month, 1)
                && new DateTime(bookDesc.CheckOutDate.Year, bookDesc.CheckOutDate.Month, 1) >= new DateTime(MainCalender.currentDate.Year, MainCalender.currentDate.Month, 1))
            {
                dateStart = bookDesc.CheckInDate.Day + staticColumn - 1;
                dateEnd = (bookDesc.CheckOutDate.Day - bookDesc.CheckInDate.Day) + staticColumn - 1;

                if (dateStart <= 0 || new DateTime(bookDesc.CheckInDate.Year, bookDesc.CheckInDate.Month, 1) < new DateTime(MainCalender.currentDate.Year, MainCalender.currentDate.Month, 1))
                {
                    dateStart = staticColumn;

                    if (new DateTime(bookDesc.CheckOutDate.Year, bookDesc.CheckOutDate.Month, 1) == new DateTime(MainCalender.currentDate.Year, MainCalender.currentDate.Month, 1))
                        dateEnd = bookDesc.CheckOutDate.Day;

                }

                if (dateEnd <= 0 || new DateTime(bookDesc.CheckOutDate.Year, bookDesc.CheckOutDate.Month, 1) > new DateTime(MainCalender.currentDate.Year, MainCalender.currentDate.Month, 1))
                    dateEnd = (DisplayDay.ColumnCount - staticColumn) - dateStart + 2;


                for (int i = 0; i < DisplayDay.RowCount; i++)
                {
                    if (DisplayDay.GetControlFromPosition(0, i).Text == bookDesc.RoomNumber + "" && DisplayDay.GetControlFromPosition(1, i).Text == bookDesc.RoomType)
                    {
                        if (Methods.FindControlInRange(dateStart, dateStart + dateEnd - 1, book, DisplayDay, i))
                            needsFix = true;
                        Row = i;
                        break;
                    }

                }

                if (!needsFix && !Methods.FindControlInRange(dateStart, dateStart + dateEnd - 1, book, DisplayDay, Row))
                {
                        DisplayDay.SetColumn(book, dateStart);
                        DisplayDay.SetColumnSpan(book, dateEnd);

                    //setting the booking number and type
                        DisplayDay.SetRow(book, Row);

                }
                else
                    needsFix = true;

            }
            else
                book.Parent = null; 

            return needsFix; ///CHECKS IF A PERSON TRIES TO RESERVE A BOOKED SPOT IF SO DONT RESERVE AND CHANGE INFO TO PREVIOUS
        }

        private void AddedReserved()
        {
            foreach(BookedDetail res in reservedBook)
            {
                if( new DateTime(res.Detail.CheckInDate.Year, res.Detail.CheckInDate.Month, 1) <= new DateTime(MainCalender.currentDate.Year, MainCalender.currentDate.Month, 1) && new DateTime(res.Detail.CheckOutDate.Year, res.Detail.CheckOutDate.Month, 1) >= new DateTime(MainCalender.currentDate.Year, MainCalender.currentDate.Month, 1))
                {
                    if (DisplayDay.Controls.OfType<BookedDetail>() == null || !DisplayDay.Controls.OfType<BookedDetail>().Any(t => t.Id == res.Id))
                    {
                        DisplayDay.Controls.Add(res);

                        if (setPositionBasedOnDate(res, res.Detail))
                            DisplayDay.Controls.Remove(res);
                    }
                }
            }

        }


        public void SaveFromDetail(BookedDetail book , string What)
        {
            BookingDescription bookDesc = book.Detail;
            bookDesc.Close();

            if (What == "Save")
            {

                int RoomId =
                       FetchInfo.RoomInfo.Where(t =>
                      t.name == book.Detail.RoomType && t.RoomNumber == book.Detail.RoomNumber
                      ).Select(t => t.id).First();


                if (FetchInfo.ReservationInfo.Any(t => (t.ID != book.Id) && (t.RoomId == RoomId) && (book.Detail.CheckInDate.Date <= t.CheckOutDate.Date) && (t.CheckInDate.Date <= book.Detail.CheckOutDate.Date)))
                {
                    MessageBox.Show("Operation Failed Already reserverd");
                    var c = FetchInfo.ReservationInfo.Where(t => t.ID == book.Id).Select(t => new { t.CheckInDate , t.CheckOutDate , t.RoomId }).ToList();

                    if (c.Count >= 1)
                    {

                        book.Detail.CheckInDate = c[0].CheckInDate;
                        book.Detail.CheckOutDate = c[0].CheckOutDate;

                        book.Detail.RoomNumber = FetchInfo.RoomInfo.Where(t => t.id == c[0].RoomId).Select(t => t.RoomNumber).First();
                        book.Detail.RoomType = FetchInfo.RoomInfo.Where(t => t.id == c[0].RoomId).Select(t => t.name).First();

                        book.Detail = book.Detail;
                    }

                    removeDeletedReservation();
                    AddedReserved();

                    return;
                }


                if (book != null)
                {
                    if (Connect.Connection.State != ConnectionState.Closed)
                        Connect.Connection.Close();

                    Connect.Connection.Open();

                    SqlTransaction transaction = Connect.Connection.BeginTransaction();

                    FetchInfo.Customer cust = new FetchInfo.Customer();
                    cust.fname = book.Detail.FirstName;
                    cust.lname = book.Detail.LastName;
                    cust.gname = book.Detail.GrandName;
                    cust.DateOfBirth = book.Detail.DateOfBirth;
                    cust.Gender = book.Detail.Gender;
                    cust.phoneNumber = book.Detail.phoneNumber;
                    cust.nationality = book.Detail.Nationality;
                    cust.ID = book.CustId;

                    var xml = Methods.ConvertToXml(new List<FetchInfo.Customer> { cust }, "ID");
                    Methods.cudOperation(xml, "UPDATEForAll", "Customer", transaction);


                    FetchInfo.Reservation res = new FetchInfo.Reservation();
                    res.ID = book.Id;
                    res.CheckInDate = book.Detail.CheckInDate;
                    res.CheckOutDate = book.Detail.CheckOutDate;
                    res.CustId = book.CustId;
                    res.IsPaid = book.Detail.isPaid;
                    res.NumberOfPeople = book.Detail.NumberOfPeople;
                    res.RoomId = RoomId;
                    res.EmpId = SignIn_Page.Id;

                    xml = Methods.ConvertToXml(new List<FetchInfo.Reservation> { res }, "ID");
                    Methods.cudOperation(xml, "UPDATEForAll", "Reservation", transaction);

                    transaction.Commit();
                    Connect.Connection.Close();

                }

            }
            else
            {
                if (book.Detail.isPaid)
                {
                    MessageBox.Show("Can not deleted Paid Reservation");
                    return;
                }

                FetchInfo.Reservation res = new FetchInfo.Reservation();
                res.ID = book.Id;
                var xml = Methods.ConvertToXml(new List<FetchInfo.Reservation> { res }, "ID");

                Methods.cudOperation(xml, "DeleteForAll", "Reservation");
                try
                    {
                        FetchInfo.Customer cust = new FetchInfo.Customer();
                        cust.ID = book.CustId;

                        xml = Methods.ConvertToXml(new List<FetchInfo.Customer> { cust }, "ID");
                        Methods.cudOperation(xml, "DeleteForAll", "Customer");

                    }
                    catch { }
                }

                book.Parent = null; 
            
        }

        private void BookDesc_Clicked(object sender, PropertyChangedEventArgs e)
        {

            BookingDescription bookDesc = sender as BookingDescription;

           bookDesc.Clicked -= BookDesc_Clicked;

            if (e.PropertyName == "Save")
            {
                    bool needsFix = setPositionBasedOnDate(book, bookDesc);
                    if (book != null)
                    {
                        book.Detail = bookDesc;
                        if (needsFix)
                            BookAltered(book);
                    }

                int RoomId =
                        FetchInfo.RoomInfo.Where(t =>
                       t.name == book.Detail.RoomType && t.RoomNumber == book.Detail.RoomNumber
                       ).Select(t => t.id).First();

                if (FetchInfo.ReservationInfo.Any(t => (t.RoomId == RoomId) && (book.Detail.CheckInDate.Date <= t.CheckOutDate.Date) && (t.CheckInDate.Date <= book.Detail.CheckOutDate.Date)))
                {
                    MessageBox.Show("Operation Failed Already reserverd");
                    bookDesc.Clicked += BookDesc_Clicked;
                    return;
                }

                    FetchInfo.Customer cust = new FetchInfo.Customer();
                    cust.fname = book.Detail.FirstName;
                    cust.lname = book.Detail.LastName;
                    cust.gname = book.Detail.GrandName;
                    cust.DateOfBirth = book.Detail.DateOfBirth;
                    cust.Gender = book.Detail.Gender;
                    cust.phoneNumber = book.Detail.phoneNumber;
                    cust.nationality = book.Detail.Nationality;

                    int custId = -1;
                    try
                    {
                        custId =
                        FetchInfo.CustomerInfo.Where(t =>
                        t.fname == cust.fname && t.lname == cust.lname && t.gname == cust.gname &&
                        t.DateOfBirth.Date == cust.DateOfBirth.Date && t.Gender.ToLower().Trim()[0] == cust.Gender.ToLower().Trim()[0] && t.phoneNumber == cust.phoneNumber
                        && t.nationality == cust.nationality
                        ).Select(t => t.ID).First();
                    }
                    catch (Exception eq) { };

                if (Connect.Connection.State != ConnectionState.Closed)
                    Connect.Connection.Close();

                Connect.Connection.Open();
                    try
                    {
                        SqlTransaction transaction = Connect.Connection.BeginTransaction();
                        if (custId <= 0)
                            {
                                var xml = Methods.ConvertToXml(new List<FetchInfo.Customer> { cust }, "ID");
                                custId = Methods.cudOperation(xml, "InsertForAll", "Customer", transaction);

                            }

                            book.CustId = custId;

                            FetchInfo.Reservation res = new FetchInfo.Reservation();
                            res.CheckInDate = book.Detail.CheckInDate;
                            res.CheckOutDate = book.Detail.CheckOutDate;
                            res.CustId = custId;
                            res.RoomId = RoomId;
                            res.NumberOfPeople = book.Detail.NumberOfPeople;
                            res.IsPaid = book.Detail.isPaid;
                            res.EmpId = SignIn_Page.Id;
                            var xmlRes = Methods.ConvertToXml(new List<FetchInfo.Reservation> { res }, "ID");
                            book.Id = Methods.cudOperation(xmlRes, "InsertForAll", "Reservation", transaction);

                            transaction.Commit();
                    }

                    catch (Exception ex) {
                        MessageBox.Show("Failed " + ex.Message);
                    }
                        Connect.Connection.Close();

            }
            else
            {
                book.Parent = null;
            }

            bookDesc.Close();
            book = null;
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            ResizeDay();
            DisplayBody.AutoScroll = true;
            HeaderTable.Location = new Point(DisplayDay.Location.X, HeaderTable.Location.Y);

        }

        private void customCalender1_calenderDateChanged(object sender, PropertyChangedEventArgs e)
        {
            ChangeColumnAmount();
            AddedReserved();
        }

        private void DisplayBody_Scroll(object sender, ScrollEventArgs e)
        {
            HeaderTable.Location = new Point(DisplayDay.Location.X, HeaderTable.Location.Y);
        }

        private void ChangeColumnAmount()
        {

            DateTime c = MainCalender.currentDate;

            removeDeletedReservation(true);

            int days = DateTime.DaysInMonth(c.Year, c.Month);
            lblDate.Text = c.ToString("MMMM yyy");

            DisplayDay.ColumnCount = staticColumn + days;
            HeaderTable.ColumnCount = staticColumn + days;

            foreach (Control co in HeaderTable.Controls)
            {
                co.Visible = true;

                if (HeaderTable.GetPositionFromControl(co).Row > 1)
                    co.Visible = false;

            }

            ResizeDay();
        }

        private void ResizeDay()
        {
            HeaderTable.Location = new Point(DisplayDay.Location.X, HeaderTable.Location.Y);

            int borderSize = SystemInformation.Border3DSize.Width;
            if (DisplayDay.CellBorderStyle == TableLayoutPanelCellBorderStyle.Single)
                borderSize = SystemInformation.BorderSize.Width;
            else if (DisplayDay.CellBorderStyle == TableLayoutPanelCellBorderStyle.None)
                borderSize = 0;


            float sum = 0;
            for (int i = 0; i < staticColumn && DisplayDay.ColumnCount > i; i++)
                sum += DisplayDay.ColumnStyles[i].Width;

            int width = (int)(DisplayBody.ClientSize.Width - sum - borderSize * DisplayDay.ColumnCount);
            width = width / (DisplayDay.ColumnCount - staticColumn);

            if (width < 1)
                width = 1;

            for (int i = staticColumn; i < DisplayDay.ColumnCount ; i++)
            {
                DisplayDay.ColumnStyles[i].Width = width;
                HeaderTable.ColumnStyles[i].Width = width;
            }
        }
    }

}