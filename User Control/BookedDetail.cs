using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Dream_Hotel.DataBase;

namespace Dream_Hotel
{
    public partial class BookedDetail : UserControl
    {
        private BookingDescription _detail;
        private BookingReport report = new BookingReport();
        private int showResize = 4;
        private bool isPressedLeft = false, isPressedRight = false;
        private int ColumnWherePressed = -1, MainColumn = -1;
        private bool isResized = false;

        public int Id;
        public int CustId;

        [Category("Booking Report")]
        public BookingDescription Detail {
            get { return _detail; }
            set {

                _detail = value;
                _detail.Clicked -= Detail_Clicked;
                _detail.Clicked += Detail_Clicked;

                if (value.isPaid) { lblPay.Text = "Paid"; IsEnable = false; } else { lblPay.Text = "Not Paid"; IsEnable = true; }
                lblRoomNumber.Text = value.RoomNumber + "";
                lblRoomType.Text = value.RoomType;
                lblFullDate.Text = value.CheckInDate.ToString("MMM dd, yyy") + "  -  " + value.CheckOutDate.ToString("MMM dd, yyy");

                report.RoomNumber = lblRoomNumber.Text;
                report.RoomType = lblRoomType.Text;
                report.isPayed = lblPay.Text;
                report.checkInDate = value.CheckInDate.ToString("dddd, MMM dd, yyy");
                report.checkOutDate = value.CheckOutDate.ToString("dddd, MMM dd, yyy");

                if (_detail.isPaid)
                    BackColor = Color.DarkGreen;
                else
                {
                    int color = FetchInfo.RoomType.Find(t => t.Item1 == report.RoomType).Item3;
                    BackColor = Color.FromArgb(color);
                }

                report.BackColor = BackColor;
                report.ForeColor = lblRoomNumber.ForeColor;

                if (value.CheckInDate.Date < DateTime.Now.Date)
                {
                    IsEnable = false;
                    
                }
            }
        }

        [Category("Booking Report")]
        public bool IsEnable { get; set; } = true;

        public BookedDetail()
        {
            InitializeComponent();
        }

        private void BookedDetail_Load(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
                c.MouseEnter += panel1_MouseEnter;
        }

        private void Detail_Clicked(object sender, PropertyChangedEventArgs e)
        {
            if (Detail.CheckInDate.Date < DateTime.Now.Date)
            {
                _detail.Close();
                 return;
            }

            if (e.PropertyName == "Save")
            {
                Detail = Detail;
                if (FindForm() is BookingPage)
                    ((BookingPage)FindForm()).SaveFromDetail(this, "Save");
            }
            else
            {
                if (FindForm() is BookingPage)
                    ((BookingPage)FindForm()).SaveFromDetail(this, "Delete");

            }

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.Capture = true;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            report.Hide();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isResized)
            {
                if (FindForm() is BookingPage)
                {
                      ((BookingPage)FindForm()).BookAltered(this);
                }
            }
            isResized = false;
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.None)
            {
                report.Show();
                Point p = new Point(Cursor.Position.X + 20, Cursor.Position.Y + 20);

                if (Screen.PrimaryScreen.WorkingArea.Width - (Cursor.Position.X + 20) < report.Width)
                    p = new Point((Cursor.Position.X + 20) - report.Width, Cursor.Position.Y + 20);

                if (Screen.PrimaryScreen.WorkingArea.Height - (Cursor.Position.Y + 20) < report.Height)
                    p = new Point(p.X, (Cursor.Position.Y - 10) - report.Height);

                report.Location = p;
            }
            else
                report.Hide();

            if (!ClientRectangle.Contains(PointToClient(Control.MousePosition)) && e.Button != MouseButtons.Left)
                panel1.Capture = false;

                if (!IsEnable)
                return;

            if ((e.X < showResize || (e.X >= Width - showResize)) && e.Button != MouseButtons.Left)
                Cursor.Current = Cursors.SizeWE;

            else if(e.Button != MouseButtons.Left)
                Cursor.Current = Cursors.Hand;

            if (Parent is TableLayoutPanel)
            {
                TableLayoutPanel t = Parent as TableLayoutPanel;
                int column = t.GetCellPosition(this).Column;

                Point tablePoint = t.PointToClient(Cursor.Position);

                int newCol = Methods.GetIndex(t, tablePoint).X;
                if (newCol < 0)
                    return;

                if (e.Button == MouseButtons.Left)
                {
                    if (Cursor.Current == Cursors.Hand) {

                        int InsertForColumn = -1 , maximumSpaceTakenByColumn = -1;

                        if (!(ColumnWherePressed < 0 || MainColumn < 0))
                        {

                            InsertForColumn = (newCol - (ColumnWherePressed - MainColumn));

                            maximumSpaceTakenByColumn = InsertForColumn + t.GetColumnSpan(this) - 1;

                            if (!(maximumSpaceTakenByColumn >= t.ColumnCount) && (!Methods.FindControlInRange(InsertForColumn, maximumSpaceTakenByColumn, this, t, t.GetRow(this))))
                            {
                                isResized = true;
                                t.Controls.Add(this, InsertForColumn, t.GetRow(this));
                            }
                        }

                        int newRow = Methods.GetIndex(t, tablePoint).Y;

                        if (!(maximumSpaceTakenByColumn >= t.ColumnCount) && InsertForColumn >= 0 &&  !(newRow < 0 || newRow >= t.RowCount))
                        {
                            if (!Methods.FindControlInRange(InsertForColumn, maximumSpaceTakenByColumn , this, t, newRow))
                            {
                                isResized = true;
                                t.Controls.Add(this, InsertForColumn , newRow);
                            }
                        }

                        return;
                    }

                    if (Methods.FindControlInRange(column, newCol, this, t , t.GetRow(this)))
                        return;

                    if (Cursor.Current != Cursors.SizeWE)
                        return;

                    if (newCol > column  && isPressedRight)
                    {
                        isResized = true;

                        int XforNextToBook = 0;

                        if ((newCol - column == 1) && t.GetColumnWidths().Length > newCol)
                            XforNextToBook = t.GetColumnWidths()[column] + t.GetColumnWidths()[column + 1] / 2;

                        if (XforNextToBook > e.X)
                            t.SetColumnSpan(this, newCol - column);
                        else
                            t.SetColumnSpan(this, newCol - column + 1);
                    }

                    else if (newCol < column && isPressedLeft)
                    {
                        isResized = true;

                        t.Controls.Add(this, newCol, t.GetRow(this));
                        t.SetColumnSpan(this, t.GetColumnSpan(this) + column - newCol);
                    }

                    else if (t.GetColumnSpan(this) > 1 && isPressedLeft)
                    {
                        isResized = true;

                        t.SetColumnSpan(this, t.GetColumnSpan(this) - (newCol - column));
                        t.Controls.Add(this, newCol, t.GetRow(this));
                    }
                }
            }

            else if (isPressedLeft)
            {
                if (MinimumSize.Width == Size.Width && e.X > 0)
                    return;

                if (e.Button == MouseButtons.Left)
                {
                    Left += e.X;
                    Width -= e.X;
                }
            }
            else if (isPressedRight)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Width += (e.X - Width);
                }
            }

            if (e.Button == MouseButtons.None)
            {
                isPressedLeft = false;
                isPressedRight = false;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                    Detail.ShowDialog(FindForm());

            if (!IsEnable)
                return;

            if (e.X < showResize)
            {
                Cursor.Current = Cursors.SizeWE;
                isPressedLeft = true;

            }
            else if (e.X >= Width - showResize)
            {
                Cursor.Current = Cursors.SizeWE;
                isPressedRight = true;
            }

            else if (Cursor.Current == Cursors.Hand && Parent is TableLayoutPanel)
            {
                MainColumn = (Parent as TableLayoutPanel).GetCellPosition(this).Column;
                ColumnWherePressed = Methods.GetIndex((Parent as TableLayoutPanel), (Parent as TableLayoutPanel).PointToClient(Cursor.Position)).X;
            }
        }

    }
}
