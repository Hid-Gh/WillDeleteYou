using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Dream_Hotel.User_Control
{

    public partial class Voucher : UserControl
    {
        public int Id { get; set; }

        public string Tooltip { get; set; }

        public int UpdateId { get; set; }

        public char Status { get; set; }


        public string VoucherStatus
        {
            get { return lblStatus.Text; }
            set { lblStatus.Text = value; }
        }


        public string Companyname {

            get { return lblCompanyName.Text; }
            set { lblCompanyName.Text = value; }
        }

        public string CompanyType
        {

            get { return lblCompanyType.Text; }
            set { lblCompanyType.Text = value; }
        }


        public DateTime Date
        {

            get
            {
                try
                {
                    return DateTime.Parse(lblDate.Text);
                }
                catch
                { return new DateTime(); }
            }

            set { lblDate.Text = value.ToString("MMMM dd , yyy , hh:mm tt"); }
        }

        private new event MouseEventHandler Click
        {
            add
            {
                base.MouseDown += value;
                foreach (Control control in Controls)
                {
                    control.MouseDown += value;
                }
            }
            remove
            {
                base.MouseDown -= value;
                foreach (Control control in Controls)
                {
                    control.MouseDown -= value;
                }
            }

        }

            public event MouseEventHandler Clicked;

        public Voucher()
        {
            InitializeComponent();
        }

        private void Voucher_Load(object sender, EventArgs e)
        {
            tooltip.ToolTipTitle = "Employee Info";
            tooltip.SetToolTip(this , Tooltip);
            Click += Voucher_Click;

        }

        private void Voucher_Click(object sender, MouseEventArgs e)
        {
            Clicked?.Invoke(this, e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            int borderSize = 4 , borderRadius = 20;
            Color borderColor = Parent.BackColor;

            var rectBorderSmooth = this.ClientRectangle;
            var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
            int smoothSize = borderSize > 0 ? borderSize : 1;

            using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
            using (Pen penBorderSmooth = new Pen(borderColor , smoothSize))
            {
                //-Drawing
                this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                graph.SmoothingMode = SmoothingMode.AntiAlias;

                //Draw border smoothing
                graph.DrawPath(penBorderSmooth, pathBorderSmooth);

            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            if (radius < 0)
                radius = 1;
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

    }
}
