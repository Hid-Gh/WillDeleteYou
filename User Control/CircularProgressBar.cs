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
    public partial class CircularProgressBar : UserControl
    {
        private int _value;

        [Category("Circular Progress Bar")]
        public Color ColorForTrack { get; set; } = Color.Red;

        [Category("Circular Progress Bar")]
        public Color ValueTrackColor { get; set; } = Color.Black;

        [Category("Circular Progress Bar")]
        public Color InnerColor { get; set; } = Color.White;

        [Category("Circular Progress Bar")]
        public int InnerRadius { get; set; } = 7;

        [Category("Circular Progress Bar")]
        public int Value {
            get { return _value; }
            set {
                _value = value;
                this.Refresh();
            }
        }

        [Category("Circular Progress Bar")]
        public Font TextFont { get; set; } = new Font("Lucida Sans", 14F, FontStyle.Bold);

        [Category("Circular Progress Bar")]
        public Color TextColor { get; set; } = Color.Black;

        public CircularProgressBar()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            float centerX = Width / 2F;
            float centerY = Height / 2F;

            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            e.Graphics.TranslateTransform(centerX, centerY);
            Rectangle r = Rectangle.Inflate(ClientRectangle, -10, -10);

            if (r.Width <= 0 || r.Height <= 0)
                return;

            Rectangle OutRect = new Rectangle(-r.Width / 2, -r.Height / 2 , r.Width, r.Height);

            e.Graphics.FillPie(new SolidBrush(ColorForTrack), OutRect, 0, 360);

            e.Graphics.FillPie(new SolidBrush(ValueTrackColor), Rectangle.Inflate(OutRect, 1, 1), -90, (int)(_value * 3.6));

            r = Rectangle.Inflate(r, -InnerRadius, -InnerRadius);

            if (r.Width > 0 && r.Height > 0)
            {
                Rectangle InnerRect = new Rectangle(-r.Width / 2, -r.Height / 2, r.Width, r.Height);
                e.Graphics.FillPie(new SolidBrush(InnerColor), InnerRect, 0, 360);
            }

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(Convert.ToString(_value) +"%", TextFont, new SolidBrush(TextColor), Point.Empty ,sf);

        }
    }
}
