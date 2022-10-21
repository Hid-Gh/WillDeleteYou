namespace Dream_Hotel
{
    partial class Booking_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ckb = new System.Windows.Forms.CheckedListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.circularProgressBar1 = new Dream_Hotel.User_Control.CircularProgressBar();
            this.customCalender1 = new Dream_Hotel.User_Control.CustomCalender();
            this.bookedDetail2 = new Dream_Hotel.BookedDetail();
            this.bookedDetail1 = new Dream_Hotel.BookedDetail();
            this.rj = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(517, 302);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(235, 36);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 50;
            // 
            // ckb
            // 
            this.ckb.CheckOnClick = true;
            this.ckb.FormattingEnabled = true;
            this.ckb.Items.AddRange(new object[] {
            "df ds",
            "fd fds",
            "dfds ",
            "fds "});
            this.ckb.Location = new System.Drawing.Point(758, 265);
            this.ckb.Name = "ckb";
            this.ckb.Size = new System.Drawing.Size(120, 94);
            this.ckb.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox1.Location = new System.Drawing.Point(744, 380);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 45);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "fg";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.DarkRed;
            this.monthCalendar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.monthCalendar1.Location = new System.Drawing.Point(651, 100);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(0);
            this.monthCalendar1.MaxSelectionCount = 100;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.White;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.Lime;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 348);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(290, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.ColorForTrack = System.Drawing.Color.Gainsboro;
            this.circularProgressBar1.InnerColor = System.Drawing.SystemColors.Control;
            this.circularProgressBar1.InnerRadius = 7;
            this.circularProgressBar1.Location = new System.Drawing.Point(360, 103);
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.Size = new System.Drawing.Size(128, 129);
            this.circularProgressBar1.TabIndex = 11;
            this.circularProgressBar1.TextColor = System.Drawing.Color.Black;
            this.circularProgressBar1.TextFont = new System.Drawing.Font("Magneto", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.Value = 50;
            this.circularProgressBar1.ValueTrackColor = System.Drawing.Color.Purple;
            // 
            // customCalender1
            // 
            this.customCalender1.BackColor = System.Drawing.Color.White;
            this.customCalender1.BackColorDays = System.Drawing.Color.White;
            this.customCalender1.BackColorWeek = System.Drawing.Color.Black;
            this.customCalender1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customCalender1.DropDownMonth = false;
            this.customCalender1.EndDate = new System.DateTime(2099, 11, 1, 0, 0, 0, 0);
            this.customCalender1.FontForDay = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customCalender1.FontForMonth = new System.Drawing.Font("Lucida Sans", 11F);
            this.customCalender1.FontForWeek = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customCalender1.FontForYear = new System.Drawing.Font("Lucida Sans", 11F);
            this.customCalender1.ForeColorDays = System.Drawing.Color.DarkGoldenrod;
            this.customCalender1.ForeColorWeek = System.Drawing.Color.White;
            this.customCalender1.givePriortyForRecentSelect = true;
            this.customCalender1.Location = new System.Drawing.Point(12, 12);
            this.customCalender1.MouseClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customCalender1.MouseEnterColor = System.Drawing.Color.Green;
            this.customCalender1.Name = "customCalender1";
            this.customCalender1.SelectedBackColor = System.Drawing.Color.Black;
            this.customCalender1.SelectedForeColor = System.Drawing.Color.White;
            this.customCalender1.selectionAmount = 3;
            this.customCalender1.Size = new System.Drawing.Size(286, 293);
            this.customCalender1.StartDate = new System.DateTime(2000, 5, 20, 18, 17, 0, 0);
            this.customCalender1.TabIndex = 10;
            // 
            // bookedDetail2
            // 
            this.bookedDetail2.IsEnable = true;
            this.bookedDetail2.Location = new System.Drawing.Point(424, 371);
            this.bookedDetail2.MinimumSize = new System.Drawing.Size(100, 0);
            this.bookedDetail2.Name = "bookedDetail2";
            this.bookedDetail2.Size = new System.Drawing.Size(292, 54);
            this.bookedDetail2.TabIndex = 7;
            // 
            // bookedDetail1
            // 
            this.bookedDetail1.IsEnable = true;
            this.bookedDetail1.Location = new System.Drawing.Point(360, 45);
            this.bookedDetail1.Name = "bookedDetail1";
            this.bookedDetail1.Size = new System.Drawing.Size(485, 56);
            this.bookedDetail1.TabIndex = 6;
            // 
            // rj
            // 
            this.rj.BackColor = System.Drawing.SystemColors.Window;
            this.rj.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rj.BorderFocusColor = System.Drawing.Color.Fuchsia;
            this.rj.BorderRadius = 10;
            this.rj.BorderSize = 2;
            this.rj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rj.Location = new System.Drawing.Point(229, 289);
            this.rj.Margin = new System.Windows.Forms.Padding(4);
            this.rj.Multiline = true;
            this.rj.Name = "rj";
            this.rj.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rj.PasswordChar = false;
            this.rj.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rj.PlaceholderText = "hello";
            this.rj.Size = new System.Drawing.Size(250, 61);
            this.rj.TabIndex = 4;
            this.rj.Texts = "";
            this.rj.UnderlinedStyle = false;
            // 
            // Booking_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.customCalender1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.bookedDetail2);
            this.Controls.Add(this.bookedDetail1);
            this.Controls.Add(this.rj);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ckb);
            this.Controls.Add(this.progressBar1);
            this.Name = "Booking_Page";
            this.Text = "Booking Page";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckedListBox ckb;
        private System.Windows.Forms.CheckBox checkBox1;
        private CustomControls.RJControls.RJTextBox rj;
        private BookedDetail bookedDetail1;
        private BookedDetail bookedDetail2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private User_Control.CustomCalender customCalender1;
        private User_Control.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Button button1;
    }
}

