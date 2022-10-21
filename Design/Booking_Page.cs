using Dream_Hotel.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dream_Hotel
{
    public partial class Booking_Page : Form
    {
        BookingReport report = new BookingReport();

        public Booking_Page()
        {
    
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void customCalender1_DayButtonClick(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            CustomCalender c = btn.Parent.Parent as CustomCalender;
            //MessageBox.Show(btn.Text + " Meow");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int boxWidth = 18, boxHeight = 18;
            Bitmap b = new Bitmap(boxWidth, boxHeight);
            Graphics g = Graphics.FromImage(b);

            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if ((sender as CheckBox).Checked)
            {
                g.FillRectangle(Brushes.DodgerBlue, 0, 0, boxWidth, boxHeight);
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                g.DrawString("\u2713", new Font("Arial Unicode MS", 10F, FontStyle.Bold), Brushes.White, 2, 0);
            }
            else
            {
                //GraphicsPath p = RoundedRect(new Rectangle(Point.Empty , b.Size) , 9 , 9 , 9 , 9);
                //g.DrawPath(new Pen(Color.Black , 3), p);


                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(Point.Empty, b.Size), Color.Aqua, Color.Blue, 90);

                using (GraphicsPath gp = new GraphicsPath())
                {
                    AddRoundedRectangle(gp, new Point(1, 1), new Size(b.Width - 2, b.Height - 2));
                    g.FillPath(brush, gp);
                }

            }
            (sender as CheckBox).Image = b;
        }

        private void AddRoundedRectangle(GraphicsPath gp, Point upperLeft, Size size)
        {
            gp.AddArc(new Rectangle(upperLeft, new Size(size.Height, size.Height)), 90, 180);
            gp.AddLine(new Point(size.Height / 2, upperLeft.Y), new Point(size.Width - (size.Height / 2), upperLeft.Y));
            gp.AddArc(new Rectangle(new Point(size.Width - size.Height, upperLeft.Y), new Size(size.Height, size.Height)), -90, 180);
            gp.CloseFigure();
        }


/*        void co(BorderForAll b , string s)
        {
            Label l = new Label();

            b.BorderColor = System.Drawing.Color.MediumSlateBlue;
            b.BorderFocusColor = System.Drawing.Color.HotPink;
            b.BorderRadius = 15;
            b.BorderSize = 2;
            b.Controls.Add(l);
            b.Location = new System.Drawing.Point(121, 12);
            b.Name = "borderForAll1";
            b.Padding = new System.Windows.Forms.Padding(2);
            b.Size = new System.Drawing.Size(36, 35);

            l.Dock = System.Windows.Forms.DockStyle.Fill;
            l.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l.Name = s;
            l.Text = s;
            l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
        */
        private void customCalender1_MonthButtonClick(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            //MessageBox.Show(btn.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                circularProgressBar1.Value = i;
                System.Threading.Thread.Sleep(10);
            }
        }
    }

}


