using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using Dream_Hotel.All_Methods;
using System.Drawing.Drawing2D;
using System.Diagnostics.Contracts;

namespace Dream_Hotel.User_Control
{
    public partial class CustomCalender : UserControl
    {

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr WindowFromPoint(Point Point);  //to get control under the specific point

        //private field
        private DateTime CurrentDate = DateTime.Now;
        private DateTime _EntryDate;
        private Size InitialSize;
        private List<Button> ForMultiSelectDay = new List<Button>();
        private event PropertyChangedEventHandler EntryChanged;
        private PictureBox animationDisplay = new PictureBox
        {
            Location = Point.Empty,
        };
        private int x1, y1; //for animation initial point
        private Bitmap img; //for animation flipped image

        //properties
        [Category("Custom Calender")]
        public List<DateTime> selectedDate { get; set; } = new List<DateTime>();

        [Category("Custom Calender")]
        public DateTime EntryDate
        {
            get { return _EntryDate; }
            set
            {
                if (StartDate.Date <= value.Date && EndDate.Date >= value.Date)
                {
                    _EntryDate = value;
                    EntryChanged?.Invoke(_EntryDate, new PropertyChangedEventArgs("date Change"));
                }
            }
        }


        [Category("Custom Calender")]
        public DateTime currentDate {

            get { return CurrentDate; }
            private set
            {
                CurrentDate = value;
                calenderDateChanged?.Invoke(CurrentDate, new PropertyChangedEventArgs("date Change"));
            }
        }

        [Category("Custom Calender")]
        public Color SelectedBackColor { get; set; } = Color.Black;

        [Category("Custom Calender")]
        public Color SelectedForeColor { get; set; } = Color.White;

        [Category("Custom Calender")]
        public Color BackColorDays { get; set; } = Color.White;

        [Category("Custom Calender")]
        public Color ForeColorDays { get; set; } = Color.Black;

        [Category("Custom Calender")]
        public Color MouseEnterColor { get; set; } = Color.FromArgb(224, 224, 224);

        [Category("Custom Calender")]
        public Color MouseClickColor { get; set; } = Color.Gray;

        [Category("Custom Calender")]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Category("Custom Calender")]
        public DateTime EndDate { get; set; } = new DateTime(2063, 12, 1);

        [Category("Custom Calender")]
        public Font FontForDay { get; set; } = new Font("Lucida Sans", 11F, FontStyle.Regular);

        [Category("Custom Calender")]
        public Font FontForMonth { get; set; } = new Font("Lucida Sans", 11F, FontStyle.Regular);

        [Category("Custom Calender")]
        public Font FontForYear { get; set; } = new Font("Lucida Sans", 11F, FontStyle.Regular);

        [Category("Custom Calender")]
        public Font FontForWeek { get; set; } = new Font("Arial", 9F);

        [Category("Custom Calender")]
        public Color ForeColorWeek { get; set; } = Color.Black;

        [Category("Custom Calender")]
        public Color BackColorWeek { get; set; } = Color.White;

        [Category("Custom Calender")]
        public bool DropDownMonth { get; set; } = false;

        [Category("Custom Calender")]
        public int selectionAmount { get; set; } = -1;

        [Category("Custom Calender")]
        public bool givePriortyForRecentSelect { get; set; } = true;

        [Category("Custom Calender")]
        public bool showAnimation { get; set; } = false;

        [Category("Custom Calender")]
        public int AnimationSpeed { get; set; } = 5;

        [Category("Custom Calender")]
        public int AnimationRatio { get; set; } = 5;

        [Category("Custom Calender")]
        public List<DateTime> DisabledDays { get; set; } = new List<DateTime>();

        [Category("Custom Calender")]
        public event PropertyChangedEventHandler DayButtonClick;

        [Category("Custom Calender")]
        public event PropertyChangedEventHandler MonthButtonClick;

        [Category("Custom Calender")]
        public event PropertyChangedEventHandler calenderDateChanged;

        [Category("Custom Calender")]
        public event PropertyChangedEventHandler YearButtonClick;

        public CustomCalender()
        {
            InitializeComponent();
            animationDisplay.Paint += Pb_Paint;
            animationDisplay.Visible = false;
            Controls.Add(animationDisplay);
        }

        protected override void OnLoad(EventArgs e)
        {

            base.OnLoad(e);
            DoubleBuffered = true;

            Methods.SetDoubleBuffered(DisplayArea);
            Methods.SetDoubleBuffered(DisplayMonth);
            Methods.SetDoubleBuffered(DisplayYear);
            Methods.SetDoubleBuffered(DisplayHeader);

            if (StartDate.Date > currentDate.Date || EndDate.Date < currentDate.Date)
                currentDate = StartDate;

            if (EntryDate != null && StartDate.Date <= EntryDate.Date && EndDate.Date >= EntryDate.Date)
                currentDate = EntryDate;

            DisplayMonth.Visible = false;
            DisplayYear.Visible = false;
            DisplayArea.Visible = true;

            ContructDisplay(DisplayYear, 4, 4);
            FillTable(DisplayYear, BackColorDays, ForeColorDays, FontForYear, Btn_ForYear);

            ContructDisplay(DisplayMonth, 3, 4);
            FillTable(DisplayMonth, BackColorDays, ForeColorDays, FontForMonth, Btn_ForMonth);

            FillMonthWithNames();
            MonthEnabled();

            ContructDisplay(DisplayArea, 7, 7);
            FillTable(DisplayArea, BackColorDays, ForeColorDays, FontForDay, Btn_Click);

            makeHeaderWeek(1);
            btnHeaderDisplay.Text = currentDate.ToString("MMMM yyy");
            clearDay(7, DisplayArea);
            makeDays();

            if (DropDownMonth)
            {
                InitialSize = new Size(Width, 300);
                Size = new Size(Width, DisplayHeader.Height);
            }


            int widthOfString = TextRenderer.MeasureText(btnHeaderDisplay.Text, btnHeaderDisplay.Font).Width;
            int Spaces = DisplayHeader.Margin.Left + DisplayHeader.Margin.Right + btnHeaderDisplay.Margin.Left;

            if ((btnHeaderDisplay.Width - Spaces) < widthOfString)
            {
                Size = new Size(Width + (widthOfString - btnHeaderDisplay.Width + Spaces), Height);
            }

            EntryChanged += CustomCalender_EntryChanged;
        }


        #region -> private methods

        #region -> Methods For All

        private void CustomCalender_EntryChanged(object sender, PropertyChangedEventArgs e)
        {
            currentDate = _EntryDate;
            clearDay(7, DisplayArea);
            makeDays();
            btnHeaderDisplay.Text = currentDate.ToString("MMMM yyy");
        }

        private void ContructDisplay(TableLayoutPanel t, int columnCount, int RowCount)
        {
            Methods.clearTable(t);
            Methods.createColumn(t, columnCount, SizeType.Percent);

            Methods.createRow(t, RowCount, SizeType.Percent);
        }

        private void FillTable(TableLayoutPanel t, Color back, Color Fore, Font f, MouseEventHandler clicks)
        {
            int boxes = t.RowCount * t.ColumnCount;
            for (int i = 0; i < boxes; i++)
            {
                Button btn = new Button();
                btn.Margin = new Padding(1);
                btn.Dock = DockStyle.Fill;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Font = f;
                btn.TabIndex = i;
                btn.Text = string.Empty;
                btn.UseVisualStyleBackColor = true;
                btn.BackColor = back;
                btn.ForeColor = Fore;

                if (t == DisplayArea && i > 6)
                    btn.MouseMove += Btn_MouseMove;

                if (t == DisplayArea && i > 6)
                    btn.MouseDown += clicks;

                else if (t != DisplayArea)
                    btn.MouseUp += clicks;

                t.Controls.Add(btn);
            }

        }

        private void clearDay(int start, TableLayoutPanel t)
        {
            for (int i = start; i < t.Controls.Count; i++)
            {
                Button btn = t.Controls[i] as Button;
                btn.Text = string.Empty;
                btn.Enabled = false;
                btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                btn.BackColor = BackColorDays;
                btn.ForeColor = ForeColorDays;
            }

        }

        #endregion

        #region -> Table For Day

        private void makeHeaderWeek(int startDay = 0)
        {
            if (startDay < 0 || startDay >= 7)
                startDay = 0;
            for (int i = 0; i < 7; i++)
            {
                Button btn = DisplayArea.Controls[i] as Button;
                string name = CultureInfo.CurrentCulture.DateTimeFormat.DayNames[startDay];
                startDay++;
                if (startDay >= 7)
                    startDay = 0;

                btn.Text = name.Substring(0, 3);
                btn.Font = FontForWeek;
                btn.BackColor = BackColorWeek;
                btn.ForeColor = ForeColorWeek;
                btn.FlatAppearance.MouseDownBackColor = BackColorWeek;
                btn.FlatAppearance.MouseOverBackColor = BackColorWeek;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Margin = new Padding(0);
            }

        }


        private void makeDays()
        {
            int days = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
            int first = int.Parse(new DateTime(currentDate.Year, (currentDate.Month), 1).DayOfWeek.ToString("d"));

            if (first == 0)
                first = 7;
            for (int i = first; i <= (days + (first - 1)); i++)
            {
                Button btn = DisplayArea.Controls[7 + (i - 1)] as Button;
                if (btn == null)
                    return;

                btn.Text = i - first + 1 + "";

                if ((StartDate.Date <= new DateTime(currentDate.Year, currentDate.Month, (i - first + 1))) && (EndDate.Date >= new DateTime(currentDate.Year, currentDate.Month, (i - first + 1))))
                {
                    if (! DisabledDays.Any(d => d.Date == new DateTime(currentDate.Year, currentDate.Month, (i - first + 1)).Date) )
                    {
                        btn.FlatAppearance.MouseDownBackColor = MouseClickColor;
                        btn.FlatAppearance.MouseOverBackColor = MouseEnterColor;
                        btn.Enabled = true;
                    }
                }
                
                if (selectedDate.Any(d => d.Date == new DateTime(currentDate.Year, currentDate.Month, int.Parse(btn.Text)).Date))
                {
                    btn.BackColor = SelectedBackColor;
                    btn.ForeColor = SelectedForeColor;
                }
            }

        }
        #endregion

        #region -> Table For Month
        private void FillMonthWithNames()
        {

            string[] MonthName = DateTimeFormatInfo.CurrentInfo.MonthNames;
            for (int i = 0; i < DisplayMonth.Controls.Count; i++)
            {
                Button btn = DisplayMonth.Controls[i] as Button;
                btn.Text = MonthName[i].Substring(0, 3);
                btn.FlatAppearance.MouseDownBackColor = MouseClickColor;
                btn.FlatAppearance.MouseOverBackColor = MouseEnterColor;
            }

        }

        private void MonthEnabled()
        {

            for (int i = 0; i < DisplayMonth.Controls.Count; i++)
            {
                Button btn = DisplayMonth.Controls[i] as Button;
                btn.Enabled = false;

                if ((new DateTime(StartDate.Year, StartDate.Month, 1) <= new DateTime(currentDate.Year, (i + 1), 1) && (new DateTime(EndDate.Year, EndDate.Month, 1) >= new DateTime(currentDate.Year, (i + 1), 1))))
                    btn.Enabled = true;
            }
        }
        #endregion

        #region -> For Year Table

        private void arrangeYear(int start, int step)
        {
            int startYear = start;

            int box = DisplayYear.RowCount * DisplayYear.ColumnCount;
            int stop = 0;
            if (step == 1)
                step = 0;

            for (int i = 0; i < box; i++)
            {
                Button btn = DisplayYear.Controls[i] as Button;
                btn.FlatAppearance.MouseDownBackColor = MouseClickColor;
                btn.FlatAppearance.MouseOverBackColor = MouseEnterColor;
                btn.Enabled = true;

                stop = (start + step);
                if (stop > EndDate.Year)
                    stop = EndDate.Year;

                if (step == 0)
                    btn.Text = start + "";
                else
                    btn.Text = start + " - " + stop;

                start += step + 1;

                if (stop == EndDate.Year)
                    break;

            }

            btnHeaderDisplay.Text = startYear + " - " + stop;
        }

        private void TieYear(string yearBound, int startYear = -1)
        {
            if (startYear < StartDate.Year)
                startYear = StartDate.Year;

            int box = DisplayYear.RowCount * DisplayYear.ColumnCount;
            int start = 0, stop = -1, step = 1;
            if (yearBound.Contains('-'))
            {
                start = int.Parse(yearBound.Split('-')[0].Trim());
                stop = int.Parse(yearBound.Split('-')[1].Trim());
            }
            else
                start = stop = int.Parse(yearBound);

            if (stop > 0)
                step = stop - start;

            if ((startYear + (step + 1) * box) < stop)
            {
                double q = (stop - startYear + 1);
                while (q > box)
                    q = q / (double)box;

                step = (int)Math.Ceiling((stop - startYear + 1) / q) - 1;
            }

            arrangeYear(startYear, step);

        }


        private void UntieYear(string rangeYear)
        {

            int box = DisplayYear.RowCount * DisplayYear.ColumnCount;
            int start = int.Parse(rangeYear.Split('-')[0]);
            int stop = int.Parse(rangeYear.Split('-')[1]);

            int step = (int)Math.Ceiling(((stop - start) + 1) / (double)box) - 1;

            double q = (stop - start + 1);
            while (q > box)
                q = q / (double)box;

            step = (int)Math.Ceiling((stop - start + 1) / q) - 1;

            arrangeYear(start, step);


        }


        #endregion

        #endregion

        #region -> Events

        #region -> For Navigation Buttons

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (DisplayArea.Visible == true)
            {
                if((currentDate.AddMonths(-1).Year < StartDate.Year) || (currentDate.AddMonths(-1).Year == StartDate.Year && StartDate.Month > currentDate.AddMonths(-1).Month))
                    return;

                currentDate = currentDate.AddMonths(-1);
                btnHeaderDisplay.Text = currentDate.ToString("MMMM yyy");

                int widthOfString = TextRenderer.MeasureText(btnHeaderDisplay.Text, btnHeaderDisplay.Font).Width;
                int Spaces = DisplayHeader.Margin.Left + DisplayHeader.Margin.Right + btnHeaderDisplay.Margin.Left;

                if ((btnHeaderDisplay.Width - Spaces) < widthOfString)
                {
                    Size = new Size(Width + (widthOfString - btnHeaderDisplay.Width + Spaces), Height);
                }

                if (!DropDownMonth && showAnimation)
                {
                    Bitmap img = new Bitmap(DisplayArea.Width, DisplayArea.Height);
                    DisplayArea.DrawToBitmap(img, DisplayArea.ClientRectangle);
                    this.img = img;
                }

                clearDay(7, DisplayArea);
                makeDays();

                if (!DropDownMonth && showAnimation)
                {
                    Bitmap img2 = new Bitmap(Width, Height);
                    DrawToBitmap(img2, ClientRectangle);
                    animationDisplay.Image = img2;
                    flipping();
                }
            }

            else if (DisplayMonth.Visible == true)
            {
                if (StartDate.Year <= currentDate.AddYears(-1).Year)
                {
                    currentDate = currentDate.AddYears(-1);
                    MonthEnabled();
                    btnHeaderDisplay.Text = currentDate.Year + "";
                }
            }

            else
            {
                int box = DisplayYear.RowCount * DisplayYear.ColumnCount;
                int start = int.Parse(btnHeaderDisplay.Text.Split('-')[0]);
                int stop = int.Parse(btnHeaderDisplay.Text.Split('-')[1]);
                if (start - (stop - start) - 1 < StartDate.Year)
                    return;

                clearDay(0, DisplayYear);
                arrangeYear(start - (stop - start) - 1, (int)Math.Ceiling((stop - start + 1) / (double)box) - 1);
            }

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (DisplayArea.Visible == true)
            {
                if((currentDate.AddMonths(1).Year > EndDate.Year) || (currentDate.AddMonths(1).Year == EndDate.Year && EndDate.Month < currentDate.AddMonths(1).Month))
                    return;

                currentDate = currentDate.AddMonths(1);
                btnHeaderDisplay.Text = currentDate.ToString("MMMM yyy");

                int widthOfString = TextRenderer.MeasureText(btnHeaderDisplay.Text, btnHeaderDisplay.Font).Width;
                int Spaces = DisplayHeader.Margin.Left + DisplayHeader.Margin.Right + btnHeaderDisplay.Margin.Left;

                if ((btnHeaderDisplay.Width - Spaces) < widthOfString)
                {
                    Size = new Size(Width + (widthOfString - btnHeaderDisplay.Width + Spaces), Height);
                }

                if (!DropDownMonth && showAnimation)
                {
                    Bitmap img = new Bitmap(DisplayArea.Width, DisplayArea.Height);
                    DisplayArea.DrawToBitmap(img, DisplayArea.ClientRectangle);
                    this.img = img;
                }

                clearDay(7, DisplayArea);
                makeDays();

                if (!DropDownMonth && showAnimation)
                {
                    Bitmap img2 = new Bitmap(Width, Height);
                    DrawToBitmap(img2, ClientRectangle);
                    animationDisplay.Image = img2;
                    flipping();
                }

            }

            else if (DisplayMonth.Visible == true)
            {
                if (EndDate.Year >= currentDate.AddYears(1).Year)
                {
                    currentDate = currentDate.AddYears(1);
                    MonthEnabled();
                    btnHeaderDisplay.Text = currentDate.Year + "";
                }

            }
            else
            {
                int box = DisplayYear.RowCount * DisplayYear.ColumnCount;
                int start = int.Parse(btnHeaderDisplay.Text.Split('-')[0]);
                int stop = int.Parse(btnHeaderDisplay.Text.Split('-')[1]);

                if (start + (stop - start) + 1 >= EndDate.Year)
                    return;

                clearDay(0, DisplayYear);
                arrangeYear(start + (stop - start) + 1, (int)Math.Ceiling((stop - start + 1) / (double)box) - 1);
            }
        }



        private void btnHeaderDisplay_Click(object sender, EventArgs e)
        {
            if (DisplayArea.Visible == true)
            {
                if (DropDownMonth)
                    Size = InitialSize;

                btnHeaderDisplay.Text = currentDate.Year + "";

                MonthEnabled();
                DisplayMonth.Visible = true;
                DisplayArea.Visible = false;
                DisplayYear.Visible = false;
            }

            else if (DisplayMonth.Visible == true)
            {
                if (StartDate.Year >= EndDate.Year)
                    return;

                DisplayMonth.Visible = false;
                DisplayArea.Visible = false;
                DisplayYear.Visible = true;
                clearDay(0, DisplayYear);
                TieYear(btnHeaderDisplay.Text);

            }

            else if (DisplayYear.Visible == true)
            {
                if (btnHeaderDisplay.Text.Contains('-'))
                {
                    if (StartDate.Year >= EndDate.Year)
                        return;

                    clearDay(0, DisplayYear);
                    TieYear(btnHeaderDisplay.Text);
                }
            }
        }

        #endregion


        #region -> For Day Buttons

        private void Btn_Click(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;

            if (selectedDate.Any(d => d.Date == new DateTime(currentDate.Year, currentDate.Month, int.Parse(btn.Text)).Date))
            {
                selectedDate.RemoveAll(t => t.Date == new DateTime(currentDate.Year, currentDate.Month, int.Parse(btn.Text)));
                btn.BackColor = BackColorDays;
                btn.ForeColor = ForeColorDays;
            }
            else
            {
                if (givePriortyForRecentSelect && selectedDate.Count == selectionAmount)
                {
                    int day = selectedDate[selectedDate.Count - 1].Day;
                    foreach (Button button in DisplayArea.Controls)
                    {
                        if (button.Text == Convert.ToString(day))
                        {
                            button.BackColor = BackColorDays;
                            button.ForeColor = ForeColorDays;
                            break;
                        }
                    }

                    selectedDate.RemoveAt(selectedDate.Count - 1);
                }

                if (selectionAmount < 0 || selectedDate.Count < selectionAmount)
                {
                    btn.BackColor = SelectedBackColor;
                    btn.ForeColor = SelectedForeColor;
                    selectedDate.Add(new DateTime(currentDate.Year, currentDate.Month, int.Parse(btn.Text)));
                }
            }

            DayButtonClick?.Invoke(new DateTime(currentDate.Year, currentDate.Month, int.Parse(btn.Text)), new PropertyChangedEventArgs("Day Clicked"));

        }
        private void Btn_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                var hdl = WindowFromPoint(Control.MousePosition);
                Control c = Control.FromHandle(hdl);

                if (c is Button && (c.Parent == DisplayArea) && (DisplayArea.GetPositionFromControl(c).Row > 0))
                {
                    Button btn = c as Button;

                    if (ForMultiSelectDay.Contains(btn) || (btn == (Button)sender))
                        return;

                    if (selectedDate.Any(d => d.Date == new DateTime(currentDate.Year, currentDate.Month, int.Parse(btn.Text)).Date))
                    {
                        selectedDate.Remove(new DateTime(currentDate.Year, currentDate.Month, int.Parse(btn.Text)));
                        btn.BackColor = BackColorDays;
                        btn.ForeColor = ForeColorDays;
                    }
                    else
                    {
                        if (givePriortyForRecentSelect && selectedDate.Count == selectionAmount)
                        {
                            int day = selectedDate[selectedDate.Count - 1].Day;

                            foreach (Button button in DisplayArea.Controls)
                            {
                                if (button.Text == Convert.ToString(day))
                                {
                                    button.BackColor = BackColorDays;
                                    button.ForeColor = ForeColorDays;
                                    break;
                                }
                            }
                            selectedDate.RemoveAt(selectedDate.Count - 1);
                        }

                        if (selectionAmount < 0 || selectedDate.Count < selectionAmount)
                        {
                            btn.BackColor = SelectedBackColor;
                            btn.ForeColor = SelectedForeColor;
                            selectedDate.Add(new DateTime(currentDate.Year, currentDate.Month, int.Parse(btn.Text)));
                        }
                    }

                    ForMultiSelectDay.Add(btn);
                    DayButtonClick?.Invoke(new DateTime(currentDate.Year, currentDate.Month, int.Parse(btn.Text)), new PropertyChangedEventArgs("Day Clicked"));

                }
            }
            else
                ForMultiSelectDay.Clear();


        }

        #endregion


        #region -> For Month Buttons

        private void Btn_ForMonth(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            int poistion = DisplayMonth.Controls.GetChildIndex(btn) + 1;
            currentDate = new DateTime(currentDate.Year, poistion, 1);

            clearDay(7, DisplayArea);
            makeDays();
            btnHeaderDisplay.Text = currentDate.ToString("MMMM yyy");

            int widthOfString = TextRenderer.MeasureText(btnHeaderDisplay.Text, btnHeaderDisplay.Font).Width;
            int Spaces = DisplayHeader.Margin.Left + DisplayHeader.Margin.Right + btnHeaderDisplay.Margin.Left;

            if ((btnHeaderDisplay.Width - Spaces) < widthOfString)
            {
                Size = new Size(Width + (widthOfString - btnHeaderDisplay.Width + Spaces), Height);
            }
            if (DropDownMonth)
                Size = new Size(Width, DisplayHeader.Height);

            MonthButtonClick?.Invoke(currentDate, new PropertyChangedEventArgs("Month Clicked"));

            DisplayMonth.Visible = false;
            DisplayYear.Visible = false;
            DisplayArea.Visible = true;

        }

        #endregion

        #region -> For Year Buttons

        private void Btn_ForYear(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            YearButtonClick?.Invoke(btn.Text, new PropertyChangedEventArgs("Year Clicked"));

            if (string.IsNullOrEmpty(btn.Text))
                return;

            if (btn.Text.Contains('-'))
            {
                int startValue = int.Parse(btn.Text.Split('-')[0].Trim());
                string value = btn.Text;
                clearDay(0, DisplayYear);
                UntieYear(value);
            }
            else
            {
                currentDate = new DateTime(int.Parse(btn.Text), currentDate.Month, 1);
                btnHeaderDisplay.Text = currentDate.Year + "";

                MonthEnabled();
                DisplayMonth.Visible = true;
                DisplayArea.Visible = false;
                DisplayYear.Visible = false;
            }
        }

        #endregion

        #endregion


        #region -> Animation

        private PointF[] GetFigurePath(int tetha, int x1, int y1, int Left, int Right, int Top, int Bottom, out int x2, out int y2)
        {
            GraphicsPath path = new GraphicsPath();

            int width = Right - Left, height = Bottom - Top;

            path.StartFigure();
            path.AddLine(new PointF(Left, Top), new PointF(Left, Bottom));
            path.AddLine(new PointF(Left, Bottom), new PointF(x1, y1));

            if (tetha < 90)
            {
                y2 = (int)Math.Round(y1 - (width * Math.Tan(tetha * (Math.PI / 180))));
                x2 = (int)Math.Round(x1 + (height * Math.Atan2(1, tetha * (Math.PI / 180))));

                if (x2 > Right)
                    x2 = Right;

                if (y2 < Top)
                    y2 = Top;
            }

            else
            {
                y2 = Top;
                x2 = x1;
            }

            path.AddLine(new PointF(x1, y1), new PointF(x2, y2));

            if (y2 < height + y2)
            {
                path.AddLine(new PointF(x2, y2), new PointF(Right, Top));
                path.AddLine(new PointF(Right, Top), new PointF(Left, Top));
            }

            else
                path.AddLine(new PointF(x2, y2), new PointF(Left, Top));

            path.CloseFigure();
            return path.PathPoints;
        }

        private void Pb_Paint(object sender, PaintEventArgs e)
        {

            using (GraphicsPath path = new GraphicsPath())  // create a graphic path to hold the shape data
            using (GraphicsPath fold = new GraphicsPath())
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.CompositingQuality = CompositingQuality.HighQuality;

                int x2, y2;
                int i = DisplayArea.Width - x1;
                int top = DisplayHeader.Height;

                PointF[] p = GetFigurePath(i, x1, y1 + top, 0, e.ClipRectangle.Width, top, e.ClipRectangle.Height, out x2, out y2);


                path.AddLines(p);  // add a set of points that define the shape
                path.CloseAllFigures(); // close the shape

                g.Clip = new Region(path); // set the clop region of the forms graphic object to be the new shape
                g.DrawImage(img, new PointF(0, top));  // draw the image cliped to the custom shape

                fold.StartFigure();

                int y = y1 - i;
                int x = x1;
                float xx = 0;
                int yIncline = 0;

                if (i >= 90)
                {
                    x = x1 - i;
                    y = DisplayArea.Height + top;
                }

                if (y2 == top && i >= 90)
                {
                    yIncline = 15;

                    double f = x1 - Math.Sqrt((i * i) - (yIncline * yIncline));
                    x = (int)Math.Ceiling(f) + yIncline * 2;

                    fold.AddCurve(new PointF[] { new PointF(x1, y1 + top), new PointF(x1, (y1 + top) - yIncline), new PointF(x, y) }, 0.4f);

                    using (var mx = new Matrix(1, 0, 0, 1, 0, 0))
                    {
                        fold.Flatten(mx, 0.1f);
                    }

                    xx = fold.PathPoints.Max(c => c.X);

                    fold.AddCurve(new PointF[] { new PointF(x, top), new PointF(x + ((xx - x) - (xx - x) / 5), top - yIncline), new PointF(xx, top) });
                    fold.AddLine(new PointF(xx, top), new PointF(xx, y1 + top - yIncline + 5));

                }

                else
                {
                    fold.AddLine(new PointF(x2, y2), new PointF(x1, y1 + top));
                    fold.AddLine(new PointF(x1, y1 + top), new PointF(x, y));
                }

                fold.CloseAllFigures();

                g.ResetClip();

                if (fold.GetBounds().Width <= 0 || fold.GetBounds().Height <= 0)
                    return;

                LinearGradientBrush brush = new LinearGradientBrush(fold.GetBounds(), Color.White, Color.DarkGray, 0f);
                g.FillPath(brush, fold);
                g.DrawPath(Pens.Black, fold);

                if (y2 == top && i >= 90)
                    g.DrawCurve(new Pen(Color.FromArgb(100, 0, 0, 0), 15), new PointF[] { new PointF(xx + 5, top), new PointF(xx + 5, y1 + top - yIncline + 5), new PointF(x1 + 5, y) }, 0f);

            }

        }

        private void flipping()
        {

            animationDisplay.Size = Size;
            animationDisplay.BringToFront();

            animationDisplay.Visible = true;

            int i = 0;
            while (DisplayArea.Right - i > DisplayArea.Left)
            {
                x1 = DisplayArea.Width - i;
                y1 = DisplayArea.Height;

                animationDisplay.Refresh();
                Application.DoEvents();
                Thread.Sleep(AnimationSpeed);
                i += AnimationRatio;
            }

            animationDisplay.Visible = false;
        }


        #endregion

        public List<DateTime> getAllSelectedDate()
        {
            return selectedDate;
        }

        public List<int> GetWeekends()
        {
            List<int> WeekendDays = new List<int>();
            int days = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
            DateTime date;
            for (int i = 1; i <= days; i++)
            {
                date = new DateTime(currentDate.Year, currentDate.Month, i);

                if ((date.DayOfWeek == DayOfWeek.Saturday) || (date.DayOfWeek == DayOfWeek.Sunday))
                    WeekendDays.Add(i);
            }
            return WeekendDays;
        }
     }
}
