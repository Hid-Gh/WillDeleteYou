using System.Drawing;

namespace Dream_Hotel
{
    partial class BookingDescription
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingDescription));
            this.lblFullDate = new System.Windows.Forms.Label();
            this.ckIsPaid = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.CheckIn = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.btnShowCal = new System.Windows.Forms.Button();
            this.checkInCal = new Dream_Hotel.User_Control.CustomCalender();
            this.checkOut = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.checkOutCal = new Dream_Hotel.User_Control.CustomCalender();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNationality = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbRoomType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRoomNumber = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPhoneNumber = new System.Windows.Forms.Panel();
            this.txtPhoneNumber = new Dream_Hotel.User_Control.CustomTextBox();
            this.txtPrefix = new Dream_Hotel.User_Control.CustomTextBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.txtNoOfPeople = new Dream_Hotel.User_Control.CustomTextBox();
            this.txtGname = new Dream_Hotel.User_Control.CustomTextBox();
            this.txtLname = new Dream_Hotel.User_Control.CustomTextBox();
            this.txtFname = new Dream_Hotel.User_Control.CustomTextBox();
            this.CheckIn.SuspendLayout();
            this.panel2.SuspendLayout();
            this.checkOut.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.pnlPhoneNumber.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFullDate
            // 
            this.lblFullDate.BackColor = System.Drawing.Color.Teal;
            this.lblFullDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFullDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFullDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullDate.ForeColor = System.Drawing.Color.White;
            this.lblFullDate.Location = new System.Drawing.Point(0, 0);
            this.lblFullDate.Name = "lblFullDate";
            this.lblFullDate.Size = new System.Drawing.Size(726, 42);
            this.lblFullDate.TabIndex = 0;
            this.lblFullDate.Text = "Time";
            this.lblFullDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFullDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFullDate_MouseDown);
            this.lblFullDate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblFullDate_MouseMove);
            // 
            // ckIsPaid
            // 
            this.ckIsPaid.AutoSize = true;
            this.ckIsPaid.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckIsPaid.Location = new System.Drawing.Point(603, 279);
            this.ckIsPaid.Name = "ckIsPaid";
            this.ckIsPaid.Size = new System.Drawing.Size(68, 30);
            this.ckIsPaid.TabIndex = 4;
            this.ckIsPaid.Text = "Paid";
            this.ckIsPaid.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(378, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(582, 399);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 40);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CheckIn
            // 
            this.CheckIn.AutoSize = true;
            this.CheckIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CheckIn.Controls.Add(this.panel2);
            this.CheckIn.Controls.Add(this.checkInCal);
            this.CheckIn.Location = new System.Drawing.Point(7, 322);
            this.CheckIn.MaximumSize = new System.Drawing.Size(0, 25);
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.Size = new System.Drawing.Size(293, 25);
            this.CheckIn.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblCheckInDate);
            this.panel2.Controls.Add(this.btnShowCal);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 27);
            this.panel2.TabIndex = 16;
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.BackColor = System.Drawing.Color.White;
            this.lblCheckInDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCheckInDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInDate.Location = new System.Drawing.Point(0, 0);
            this.lblCheckInDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblCheckInDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(104, 25);
            this.lblCheckInDate.TabIndex = 14;
            this.lblCheckInDate.Text = "Check In Date    ";
            this.lblCheckInDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowCal
            // 
            this.btnShowCal.BackColor = System.Drawing.Color.White;
            this.btnShowCal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowCal.BackgroundImage")));
            this.btnShowCal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowCal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowCal.FlatAppearance.BorderSize = 0;
            this.btnShowCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCal.Location = new System.Drawing.Point(104, 0);
            this.btnShowCal.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowCal.Name = "btnShowCal";
            this.btnShowCal.Size = new System.Drawing.Size(30, 25);
            this.btnShowCal.TabIndex = 0;
            this.btnShowCal.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnShowCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowCal.UseVisualStyleBackColor = false;
            this.btnShowCal.Click += new System.EventHandler(this.btnShowCal_Click);
            // 
            // checkInCal
            // 
            this.checkInCal.AnimationRatio = 5;
            this.checkInCal.AnimationSpeed = 5;
            this.checkInCal.BackColor = System.Drawing.Color.White;
            this.checkInCal.BackColorDays = System.Drawing.Color.White;
            this.checkInCal.BackColorWeek = System.Drawing.Color.White;
            this.checkInCal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkInCal.DisabledDays = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("checkInCal.DisabledDays")));
            this.checkInCal.DropDownMonth = false;
            this.checkInCal.EndDate = new System.DateTime(2063, 12, 1, 0, 0, 0, 0);
            this.checkInCal.EntryDate = new System.DateTime(((long)(0)));
            this.checkInCal.FontForDay = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInCal.FontForMonth = new System.Drawing.Font("Lucida Sans", 11F);
            this.checkInCal.FontForWeek = new System.Drawing.Font("Arial", 9F);
            this.checkInCal.FontForYear = new System.Drawing.Font("Lucida Sans", 11F);
            this.checkInCal.ForeColorDays = System.Drawing.Color.Black;
            this.checkInCal.ForeColorWeek = System.Drawing.Color.Black;
            this.checkInCal.givePriortyForRecentSelect = true;
            this.checkInCal.Location = new System.Drawing.Point(0, 27);
            this.checkInCal.MouseClickColor = System.Drawing.Color.Gray;
            this.checkInCal.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkInCal.Name = "checkInCal";
            this.checkInCal.SelectedBackColor = System.Drawing.Color.Black;
            this.checkInCal.selectedDate = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("checkInCal.selectedDate")));
            this.checkInCal.SelectedForeColor = System.Drawing.Color.White;
            this.checkInCal.selectionAmount = 1;
            this.checkInCal.showAnimation = false;
            this.checkInCal.Size = new System.Drawing.Size(290, 256);
            this.checkInCal.StartDate = new System.DateTime(2022, 9, 29, 19, 22, 15, 70);
            this.checkInCal.TabIndex = 14;
            this.checkInCal.Visible = false;
            this.checkInCal.DayButtonClick += new System.ComponentModel.PropertyChangedEventHandler(this.checkInCal_DayButtonClick);
            // 
            // checkOut
            // 
            this.checkOut.AutoSize = true;
            this.checkOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkOut.Controls.Add(this.panel3);
            this.checkOut.Controls.Add(this.checkOutCal);
            this.checkOut.Location = new System.Drawing.Point(327, 320);
            this.checkOut.MaximumSize = new System.Drawing.Size(0, 25);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(293, 25);
            this.checkOut.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblCheckOutDate);
            this.panel3.Controls.Add(this.btnShow);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 27);
            this.panel3.TabIndex = 16;
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.BackColor = System.Drawing.Color.White;
            this.lblCheckOutDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutDate.Location = new System.Drawing.Point(0, 0);
            this.lblCheckOutDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblCheckOutDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(115, 25);
            this.lblCheckOutDate.TabIndex = 14;
            this.lblCheckOutDate.Text = "Check Out Date    ";
            this.lblCheckOutDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShow.BackgroundImage")));
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(115, 0);
            this.btnShow.Margin = new System.Windows.Forms.Padding(0);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(30, 25);
            this.btnShow.TabIndex = 0;
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // checkOutCal
            // 
            this.checkOutCal.AnimationRatio = 5;
            this.checkOutCal.AnimationSpeed = 5;
            this.checkOutCal.BackColor = System.Drawing.Color.White;
            this.checkOutCal.BackColorDays = System.Drawing.Color.White;
            this.checkOutCal.BackColorWeek = System.Drawing.Color.White;
            this.checkOutCal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkOutCal.DisabledDays = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("checkOutCal.DisabledDays")));
            this.checkOutCal.DropDownMonth = false;
            this.checkOutCal.EndDate = new System.DateTime(2063, 12, 1, 0, 0, 0, 0);
            this.checkOutCal.EntryDate = new System.DateTime(((long)(0)));
            this.checkOutCal.FontForDay = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutCal.FontForMonth = new System.Drawing.Font("Lucida Sans", 11F);
            this.checkOutCal.FontForWeek = new System.Drawing.Font("Arial", 9F);
            this.checkOutCal.FontForYear = new System.Drawing.Font("Lucida Sans", 11F);
            this.checkOutCal.ForeColorDays = System.Drawing.Color.Black;
            this.checkOutCal.ForeColorWeek = System.Drawing.Color.Black;
            this.checkOutCal.givePriortyForRecentSelect = true;
            this.checkOutCal.Location = new System.Drawing.Point(0, 27);
            this.checkOutCal.MouseClickColor = System.Drawing.Color.Gray;
            this.checkOutCal.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkOutCal.Name = "checkOutCal";
            this.checkOutCal.SelectedBackColor = System.Drawing.Color.Black;
            this.checkOutCal.selectedDate = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("checkOutCal.selectedDate")));
            this.checkOutCal.SelectedForeColor = System.Drawing.Color.White;
            this.checkOutCal.selectionAmount = 1;
            this.checkOutCal.showAnimation = false;
            this.checkOutCal.Size = new System.Drawing.Size(290, 256);
            this.checkOutCal.StartDate = new System.DateTime(2022, 9, 29, 19, 22, 15, 70);
            this.checkOutCal.TabIndex = 14;
            this.checkOutCal.Visible = false;
            this.checkOutCal.DayButtonClick += new System.ComponentModel.PropertyChangedEventHandler(this.checkOutCal_DayButtonClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Check In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Check Out";
            // 
            // cmbNationality
            // 
            this.cmbNationality.DropDownHeight = 211;
            this.cmbNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNationality.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNationality.FormattingEnabled = true;
            this.cmbNationality.IntegralHeight = false;
            this.cmbNationality.ItemHeight = 18;
            this.cmbNationality.Location = new System.Drawing.Point(13, 226);
            this.cmbNationality.MaxDropDownItems = 17;
            this.cmbNationality.Name = "cmbNationality";
            this.cmbNationality.Size = new System.Drawing.Size(163, 26);
            this.cmbNationality.TabIndex = 18;
            this.cmbNationality.SelectedIndexChanged += new System.EventHandler(this.cmbNationality_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nationality";
            // 
            // CmbRoomType
            // 
            this.CmbRoomType.BackColor = System.Drawing.Color.White;
            this.CmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRoomType.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.CmbRoomType.FormattingEnabled = true;
            this.CmbRoomType.Location = new System.Drawing.Point(210, 225);
            this.CmbRoomType.Name = "CmbRoomType";
            this.CmbRoomType.Size = new System.Drawing.Size(124, 26);
            this.CmbRoomType.TabIndex = 20;
            this.CmbRoomType.SelectedIndexChanged += new System.EventHandler(this.CmbRoomType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Room Type";
            // 
            // Err
            // 
            this.Err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Err.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Room Number";
            // 
            // cmbRoomNumber
            // 
            this.cmbRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomNumber.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cmbRoomNumber.FormattingEnabled = true;
            this.cmbRoomNumber.Items.AddRange(new object[] {
            "100",
            "101",
            "102",
            "103",
            "202",
            "203",
            "204"});
            this.cmbRoomNumber.Location = new System.Drawing.Point(430, 228);
            this.cmbRoomNumber.Name = "cmbRoomNumber";
            this.cmbRoomNumber.Size = new System.Drawing.Size(124, 26);
            this.cmbRoomNumber.TabIndex = 24;
            this.cmbRoomNumber.SelectedIndexChanged += new System.EventHandler(this.cmbRoomNumber_SelectedIndexChanged);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(13, 145);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Date Of Birth";
            // 
            // pnlPhoneNumber
            // 
            this.pnlPhoneNumber.AutoSize = true;
            this.pnlPhoneNumber.Controls.Add(this.txtPhoneNumber);
            this.pnlPhoneNumber.Controls.Add(this.txtPrefix);
            this.pnlPhoneNumber.Location = new System.Drawing.Point(247, 136);
            this.pnlPhoneNumber.Name = "pnlPhoneNumber";
            this.pnlPhoneNumber.Size = new System.Drawing.Size(227, 29);
            this.pnlPhoneNumber.TabIndex = 30;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPhoneNumber.IsPassword = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(50, 0);
            this.txtPhoneNumber.MinimumSize = new System.Drawing.Size(163, 26);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PlaceHolder = "Phone Number";
            this.txtPhoneNumber.Size = new System.Drawing.Size(177, 26);
            this.txtPhoneNumber.TabIndex = 29;
            this.txtPhoneNumber.Text = "Phone Number";
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtPhoneNumber.MouseEnter += new System.EventHandler(this.txtFname_MouseEnter);
            // 
            // txtPrefix
            // 
            this.txtPrefix.BackColor = System.Drawing.Color.White;
            this.txtPrefix.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPrefix.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtPrefix.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtPrefix.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPrefix.IsPassword = false;
            this.txtPrefix.Location = new System.Drawing.Point(0, 0);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.PlaceHolder = "Prefix";
            this.txtPrefix.ReadOnly = true;
            this.txtPrefix.Size = new System.Drawing.Size(50, 26);
            this.txtPrefix.TabIndex = 28;
            this.txtPrefix.Text = "Prefix";
            this.txtPrefix.MouseEnter += new System.EventHandler(this.txtFname_MouseEnter);
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdFemale);
            this.grpGender.Controls.Add(this.rdMale);
            this.grpGender.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGender.Location = new System.Drawing.Point(556, 115);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(161, 84);
            this.grpGender.TabIndex = 31;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemale.Location = new System.Drawing.Point(24, 54);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(64, 19);
            this.rdFemale.TabIndex = 1;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMale.Location = new System.Drawing.Point(24, 31);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(53, 19);
            this.rdMale.TabIndex = 0;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // txtNoOfPeople
            // 
            this.txtNoOfPeople.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtNoOfPeople.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNoOfPeople.IsPassword = false;
            this.txtNoOfPeople.Location = new System.Drawing.Point(556, 72);
            this.txtNoOfPeople.Name = "txtNoOfPeople";
            this.txtNoOfPeople.PlaceHolder = "Number Of People";
            this.txtNoOfPeople.Size = new System.Drawing.Size(136, 26);
            this.txtNoOfPeople.TabIndex = 23;
            this.txtNoOfPeople.Text = "Number Of People";
            this.txtNoOfPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtNoOfPeople.MouseEnter += new System.EventHandler(this.txtFname_MouseEnter);
            // 
            // txtGname
            // 
            this.txtGname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtGname.IsPassword = false;
            this.txtGname.Location = new System.Drawing.Point(380, 72);
            this.txtGname.Name = "txtGname";
            this.txtGname.PlaceHolder = "Grand Father Name";
            this.txtGname.Size = new System.Drawing.Size(142, 26);
            this.txtGname.TabIndex = 12;
            this.txtGname.Text = "Grand Father Name";
            this.txtGname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            this.txtGname.MouseEnter += new System.EventHandler(this.txtFname_MouseEnter);
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtLname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtLname.IsPassword = false;
            this.txtLname.Location = new System.Drawing.Point(187, 72);
            this.txtLname.Name = "txtLname";
            this.txtLname.PlaceHolder = "Last Name";
            this.txtLname.Size = new System.Drawing.Size(124, 26);
            this.txtLname.TabIndex = 11;
            this.txtLname.Text = "Last Name";
            this.txtLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            this.txtLname.MouseEnter += new System.EventHandler(this.txtFname_MouseEnter);
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtFname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtFname.IsPassword = false;
            this.txtFname.Location = new System.Drawing.Point(17, 72);
            this.txtFname.Name = "txtFname";
            this.txtFname.PlaceHolder = "First Name";
            this.txtFname.Size = new System.Drawing.Size(124, 26);
            this.txtFname.TabIndex = 10;
            this.txtFname.Text = "First Name";
            this.txtFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            this.txtFname.MouseEnter += new System.EventHandler(this.txtFname_MouseEnter);
            // 
            // BookingDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.ControlBox = false;
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.pnlPhoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRoomNumber);
            this.Controls.Add(this.txtNoOfPeople);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbRoomType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbNationality);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.CheckIn);
            this.Controls.Add(this.txtGname);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ckIsPaid);
            this.Controls.Add(this.lblFullDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookingDescription";
            this.Text = "BookingDescription";
            this.Load += new System.EventHandler(this.BookingDescription_Load);
            this.CheckIn.ResumeLayout(false);
            this.CheckIn.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.checkOut.ResumeLayout(false);
            this.checkOut.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.pnlPhoneNumber.ResumeLayout(false);
            this.pnlPhoneNumber.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullDate;
        private System.Windows.Forms.CheckBox ckIsPaid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private User_Control.CustomTextBox txtFname;
        private User_Control.CustomTextBox txtLname;
        private User_Control.CustomTextBox txtGname;
        private System.Windows.Forms.Panel CheckIn;
        private User_Control.CustomCalender checkInCal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Button btnShowCal;
        private System.Windows.Forms.Panel checkOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Button btnShow;
        private User_Control.CustomCalender checkOutCal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNationality;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbRoomType;
        private System.Windows.Forms.Label label6;
        private User_Control.CustomTextBox txtNoOfPeople;
        private System.Windows.Forms.ErrorProvider Err;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRoomNumber;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label1;
        private User_Control.CustomTextBox txtPrefix;
        private System.Windows.Forms.Panel pnlPhoneNumber;
        private User_Control.CustomTextBox txtPhoneNumber;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
    }
}