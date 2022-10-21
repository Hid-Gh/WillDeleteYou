using Dream_Hotel.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Dream_Hotel
{
    class Methods
    {

        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion

        static public bool FindControlInRange(int poistion1, int poistion2, Control ForMe, TableLayoutPanel t, int Row)
        {
            if (poistion1 < 0 || poistion2 < 0)
                return true;

            if (poistion1 < poistion2)
            {
                for (int i = poistion1; i <= poistion2; i++)
                {
                    if (Row < 0)
                        return true;

                    if (t.GetControlFromPosition(i, Row) != null && t.GetControlFromPosition(i, Row) != ForMe)
                        return true;
                }
            }
            else
            {
                for (int i = poistion2; i <= poistion1; i++)
                {
                    if (Row < 0)
                        return true;

                    if (t.GetControlFromPosition(i, Row) != null && t.GetControlFromPosition(i, Row) != ForMe)
                        return true;
                }
            }

            return false;
        }

        static public Point GetIndex(TableLayoutPanel tlp, Point point)
        {
            Point p = new Point(-1, -1);
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return p;

            int w = 0, h = 0;
            int[] widths = tlp.GetColumnWidths(), heights = tlp.GetRowHeights();

            int i;
            for (i = 0; i < widths.Length && point.X > w; i++)
            {
                w += widths[i];
            }
            int col = i - 1;

            for (i = 0; i < heights.Length && point.Y + tlp.VerticalScroll.Value > h; i++)
            {
                h += heights[i];
            }
            int row = i - 1;

            return new Point(col, row);
        }

        static public void clearTable(TableLayoutPanel t)
        {
            t.Controls.Clear();
            t.RowStyles.Clear();
            t.ColumnStyles.Clear();
            t.ColumnCount = 0;
            t.RowCount = 0;
        }
        static public void createColumn(TableLayoutPanel t, int columnCount, SizeType st, float size = 70)
        {
            float controlWidth = 100F / columnCount;

            if (st == SizeType.Absolute || st == SizeType.AutoSize)
                controlWidth = size;

            for (int i = 0; i < columnCount; i++)
            {
                t.ColumnStyles.Add(new ColumnStyle(st, controlWidth));
            }
            t.ColumnCount += columnCount;

        }

        static public void createRow(TableLayoutPanel t, int RowCount, SizeType st, float size = 20)
        {
            float controlHeight = 100F / RowCount;

            if (st == SizeType.Absolute || st == SizeType.AutoSize)
                controlHeight = size;

            for (int i = 0; i < RowCount; i++)
            {
                t.RowStyles.Add(new RowStyle(st, controlHeight));
            }
            t.RowCount += RowCount;

        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        static public void Horizontal_Scrolling(object sender, MouseEventArgs e)
        {
            const int WM_SCROLL = 276; // Horizontal scroll 
            const int SB_LINELEFT = 0; // Scrolls one cell left 
            const int SB_LINERIGHT = 1; // Scrolls one line right

            ScrollableControl scroller;

            if (((ScrollableControl)sender).AutoScroll)
                scroller = sender as ScrollableControl;
            else
                scroller = ((Control)sender).Parent as ScrollableControl;


            if (Control.ModifierKeys == Keys.Shift)
            {

                int vertical = scroller.VerticalScroll.Value, horizontal = scroller.HorizontalScroll.Value;

                scroller.AutoScroll = false;

                scroller.VerticalScroll.Value = vertical;
                scroller.HorizontalScroll.Value = horizontal;

                if (((Control)sender).Location.X == 0)
                    scroller.HorizontalScroll.Value = 1;

                var direction = e.Delta > 0 ? SB_LINELEFT : SB_LINERIGHT;

                SendMessage(scroller.Handle, WM_SCROLL, (IntPtr)direction, IntPtr.Zero);
            }

            else
                scroller.AutoScroll = true;

        }

        static public XElement ConvertToXml<T>(List<T> v, string id)
        {
            var bindingFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly;
            
            var xml = new XElement("Rows" , v.Select(x => new XElement("Row",

                x.GetType()
                .GetProperties(bindingFlags)
                .Select(field =>
                {
                    dynamic myValue;
                    if (field.Name == id)
                        myValue = new XElement(field.Name, new XElement("operator", " = "), new XElement("value", field.GetValue(x)));
                    else
                        myValue = new XElement(field.Name, field.GetValue(x));
                    return myValue;
                }
                

                ).ToList() ,

                x.GetType()
               .GetFields()
               .Select(field =>
               {
                   dynamic myValue;
                   if (field.Name == id)
                       myValue = new XElement(field.Name, new XElement("operator", " = "), new XElement("value", field.GetValue(x)));
                   else
                       myValue = new XElement(field.Name, field.GetValue(x));
                   return myValue;
               }
               ).ToList()
                )));

            return xml;
        }

        public static Icon ResizeIcon(Icon icon, Size size)
        {
            Bitmap bitmap = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(icon.ToBitmap(), new Rectangle(Point.Empty, size));
            }
            return Icon.FromHandle(bitmap.GetHicon());
        }



        static public void Display(Control C, string msg, Color TextColor, Color backColor, Size siz, Font f, int Interval = 3000, int fading = 8)
        {

            ToolStripDropDown drop = new ToolStripDropDown
            {
                CanOverflow = true,
                TopLevel = true,
                AutoClose = false,
                Margin = Padding.Empty,
                Padding = Padding.Empty,
                DropShadowEnabled = true
            };

            Label b = new Label
            {
                AutoSize = false,
                Size = siz,
                MinimumSize = siz,
                BackColor = backColor,
                Font = f
            };

            b.Paint += (s, e) =>
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawString(msg, f, new SolidBrush(TextColor), b.ClientRectangle, sf);

            };

            ToolStripControlHost t = new ToolStripControlHost(b);
            t.Margin = Padding.Empty;
            t.Padding = Padding.Empty;

            drop.Size = siz;
            drop.Items.Add(t);
            drop.Enabled = false;

            drop.BringToFront();
            drop.Opacity = 0.0f;
            drop.Show(C, new Point( ( C.Width / 2) - (siz.Width / 2) , (C.Height / 2) - (siz.Height / 2) ));

            bool sty = false;
            Timer t1 = new Timer();
            t1.Interval = fading;

            t1.Tick += (s, e) =>
            {
                if (sty)
                {
                    t1.Interval = fading;
                    drop.Opacity -= 0.01f;
                    if (drop.Opacity <= 0.0f)
                    {
                        t1.Stop();
                        drop.Close();
                    }

                }
                else
                {
                    drop.Opacity += 0.01f;

                    if (drop.Opacity >= 1)
                    {
                        t1.Stop();
                        sty = true;
                        t1.Interval = Interval;
                        t1.Start();
                    }
                }
            };
            t1.Start();

        }


        static public Form SwitchForms<T>(Button btn, Panel indicator, Form f, Form[] switchList , Color selectedColor) where T : new()
        {

            Timer t = new Timer();
            t.Interval = 1;

            t.Tick += (s, ea) => {
                int x = 8;

                if (indicator.Left > btn.Left)
                    x = -x;

                int bottom = btn.Parent.Location.Y  + btn.Height;

                if (Math.Abs(btn.Left - indicator.Left) <= Math.Abs(x))
                {
                    indicator.Location = new Point(btn.Left, bottom - indicator.Height);
                    indicator.Size = new Size(btn.Width, 6);
                    t.Stop();
                }
                else
                    indicator.Location = new Point(indicator.Left + x, bottom - indicator.Height);
            };
            t.Start();

            indicator.BringToFront();

            foreach (Button c in btn.Parent.Controls)
                c.BackColor = Color.Transparent;

            btn.BackColor = selectedColor;

            Form h;
            if (switchList[btn.Parent.Controls.IndexOf(btn)] != null)
            {
                h = switchList[btn.Parent.Controls.IndexOf(btn)];
                switchList[btn.Parent.Controls.IndexOf(btn)].BringToFront();
                f.Refresh();
            }

            else
            {
                T S1 = new T();
                h = S1 as Form;

                h.MdiParent = f;
                h.Dock = DockStyle.Fill;
                h.FormBorderStyle = FormBorderStyle.None;
                h.ControlBox = false;
                h.Show();
                switchList[btn.Parent.Controls.IndexOf(btn)] = h;
            }

            return h;
        }

        public static DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }



        static public int cudOperation(XElement xml, string ProcType, string TableName, SqlTransaction trans = null)
        {
            int Id;
            if (trans != null)
            {
                using (SqlCommand command = new SqlCommand(ProcType, Connect.Connection, trans))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                        new SqlParameter
                        {
                            ParameterName = "@xml",
                            SqlDbType = SqlDbType.Xml,
                            Value = new SqlXml(xml.CreateReader())
                        });
                    command.Parameters.AddWithValue("@table", TableName);
                    command.ExecuteNonQuery();

                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT cast( @@IDENTITY as int)";

                    string ans = command.ExecuteScalar().ToString();
                    if (Regex.IsMatch(ans, "^[0-9]+$"))
                        Id = int.Parse(ans);
                    else
                        Id = 0;
                }

            }
            else
            {
                if (Connect.Connection.State != ConnectionState.Closed)
                    Connect.Connection.Close();

                Connect.Connection.Open();

                using (SqlCommand command = new SqlCommand(ProcType, Connect.Connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                        new SqlParameter
                        {
                            ParameterName = "@xml",
                            SqlDbType = SqlDbType.Xml,
                            Value = new SqlXml(xml.CreateReader())
                        });
                    command.Parameters.AddWithValue("@table", TableName);
                    command.ExecuteNonQuery();

                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT cast( @@IDENTITY as int)";

                    string ans = command.ExecuteScalar().ToString();
                    if (Regex.IsMatch(ans, "^[0-9]+$"))
                        Id = int.Parse(ans);
                    else
                        Id = 0;
                }

                Connect.Connection.Close();
            }

            return Id;
        }

    }
}
