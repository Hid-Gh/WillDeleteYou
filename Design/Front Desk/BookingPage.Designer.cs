namespace Dream_Hotel
{
    partial class BookingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DisplayBody = new System.Windows.Forms.Panel();
            this.DisplayDay = new System.Windows.Forms.TableLayoutPanel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderTable = new System.Windows.Forms.TableLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblReservation = new System.Windows.Forms.Label();
            this.MainCalender = new Dream_Hotel.User_Control.CustomCalender();
            this.panel1.SuspendLayout();
            this.DisplayBody.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.HeaderTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.DisplayBody);
            this.panel1.Controls.Add(this.HeaderPanel);
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 578);
            this.panel1.TabIndex = 1;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // DisplayBody
            // 
            this.DisplayBody.AutoScroll = true;
            this.DisplayBody.Controls.Add(this.DisplayDay);
            this.DisplayBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayBody.Location = new System.Drawing.Point(0, 111);
            this.DisplayBody.Name = "DisplayBody";
            this.DisplayBody.Size = new System.Drawing.Size(1269, 467);
            this.DisplayBody.TabIndex = 2;
            this.DisplayBody.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DisplayBody_Scroll);
            // 
            // DisplayDay
            // 
            this.DisplayDay.AutoSize = true;
            this.DisplayDay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DisplayDay.BackColor = System.Drawing.Color.Transparent;
            this.DisplayDay.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.DisplayDay.ColumnCount = 1;
            this.DisplayDay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.DisplayDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.DisplayDay.Location = new System.Drawing.Point(0, 0);
            this.DisplayDay.Margin = new System.Windows.Forms.Padding(0);
            this.DisplayDay.Name = "DisplayDay";
            this.DisplayDay.RowCount = 2;
            this.DisplayDay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.DisplayDay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.DisplayDay.Size = new System.Drawing.Size(1269, 103);
            this.DisplayDay.TabIndex = 1;
            this.DisplayDay.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.TableLayoutPanel1_CellPaint);
            this.DisplayDay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DisplayDay_MouseDown);
            this.DisplayDay.MouseEnter += new System.EventHandler(this.DisplayDay_MouseEnter);
            this.DisplayDay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DisplayDay_MouseMove);
            this.DisplayDay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DisplayDay_MouseUp);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.HeaderTable);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1269, 111);
            this.HeaderPanel.TabIndex = 12;
            // 
            // HeaderTable
            // 
            this.HeaderTable.AutoSize = true;
            this.HeaderTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HeaderTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.HeaderTable.ColumnCount = 4;
            this.HeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.40943F));
            this.HeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.59057F));
            this.HeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.HeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 511F));
            this.HeaderTable.Controls.Add(this.lblDate, 0, 0);
            this.HeaderTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.HeaderTable.Location = new System.Drawing.Point(0, 0);
            this.HeaderTable.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderTable.Name = "HeaderTable";
            this.HeaderTable.RowCount = 2;
            this.HeaderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.6769F));
            this.HeaderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.3231F));
            this.HeaderTable.Size = new System.Drawing.Size(2783, 111);
            this.HeaderTable.TabIndex = 1;
            // 
            // lblDate
            // 
            this.HeaderTable.SetColumnSpan(this.lblDate, 4);
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1, 1);
            this.lblDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(2781, 47);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "March 08 2022";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReservation
            // 
            this.lblReservation.AutoSize = true;
            this.lblReservation.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservation.Location = new System.Drawing.Point(8, 22);
            this.lblReservation.Name = "lblReservation";
            this.lblReservation.Size = new System.Drawing.Size(255, 59);
            this.lblReservation.TabIndex = 12;
            this.lblReservation.Text = "Reservation";
            // 
            // MainCalender
            // 
            this.MainCalender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MainCalender.AnimationRatio = 5;
            this.MainCalender.AnimationSpeed = 5;
            this.MainCalender.BackColorDays = System.Drawing.Color.White;
            this.MainCalender.BackColorWeek = System.Drawing.Color.White;
            this.MainCalender.DisabledDays = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("MainCalender.DisabledDays")));
            this.MainCalender.DropDownMonth = true;
            this.MainCalender.EndDate = new System.DateTime(2030, 12, 1, 0, 0, 0, 0);
            this.MainCalender.FontForDay = new System.Drawing.Font("Lucida Sans", 11F);
            this.MainCalender.FontForMonth = new System.Drawing.Font("Lucida Sans", 11F);
            this.MainCalender.FontForWeek = new System.Drawing.Font("Arial", 9F);
            this.MainCalender.FontForYear = new System.Drawing.Font("Lucida Sans", 11F);
            this.MainCalender.ForeColorDays = System.Drawing.Color.Black;
            this.MainCalender.ForeColorWeek = System.Drawing.Color.Black;
            this.MainCalender.givePriortyForRecentSelect = true;
            this.MainCalender.Location = new System.Drawing.Point(1010, 22);
            this.MainCalender.MouseClickColor = System.Drawing.Color.Gray;
            this.MainCalender.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainCalender.Name = "MainCalender";
            this.MainCalender.SelectedBackColor = System.Drawing.Color.Black;
            this.MainCalender.selectedDate = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("MainCalender.selectedDate")));
            this.MainCalender.SelectedForeColor = System.Drawing.Color.White;
            this.MainCalender.selectionAmount = -1;
            this.MainCalender.showAnimation = false;
            this.MainCalender.Size = new System.Drawing.Size(271, 57);
            this.MainCalender.StartDate = new System.DateTime(2022, 8, 20, 18, 44, 11, 223);
            this.MainCalender.TabIndex = 11;
            this.MainCalender.calenderDateChanged += new System.ComponentModel.PropertyChangedEventHandler(this.customCalender1_calenderDateChanged);
            // 
            // BookingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 687);
            this.Controls.Add(this.lblReservation);
            this.Controls.Add(this.MainCalender);
            this.Controls.Add(this.panel1);
            this.Name = "BookingPage";
            this.Text = "BookingPage";
            this.panel1.ResumeLayout(false);
            this.DisplayBody.ResumeLayout(false);
            this.DisplayBody.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.HeaderTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DisplayBody;
        private System.Windows.Forms.TableLayoutPanel DisplayDay;
        private User_Control.CustomCalender MainCalender;
        private System.Windows.Forms.TableLayoutPanel HeaderTable;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label lblReservation;
    }
}