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

namespace Dream_Hotel
{
    public partial class BookingReport : Form
    {

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        /// <summary>
        /// Prevent form from getting focus
        /// </summary>

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                const int WS_EX_NOACTIVATE = 0x08000000;

                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW & WS_EX_NOACTIVATE; 
                return cp;
            }
        }
        

        protected override bool ShowWithoutActivation => true; // to make not focusable


        public string RoomNumber
        {
            get { return lblRoomNumber.Text; }
            set { lblRoomNumber.Text = value; }
        }

        public string RoomType
        {
            get { return lblRoomType.Text; }
            set { lblRoomType.Text = value; }
        }

        public string checkInDate
        {
            get { return checkIn.Text; }
            set { checkIn.Text = value; }
        }

        public string checkOutDate
        {
            get { return checkOut.Text; }
            set { checkOut.Text = value; }
        }

        public string isPayed
        {
            get { return lblPay.Text; }
            set { lblPay.Text = value; }
        }

        public BookingReport()
        {
            InitializeComponent();
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

        }
    }
}
