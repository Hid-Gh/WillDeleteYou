namespace Dream_Hotel.Design
{
    partial class AttendenceView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendenceView));
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.lblAttendence = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MainCalender = new Dream_Hotel.User_Control.CustomCalender();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToAddRows = false;
            this.dgvView.AllowUserToResizeRows = false;
            this.dgvView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvView.BackgroundColor = System.Drawing.Color.White;
            this.dgvView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvView.ColumnHeadersHeight = 80;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvView.EnableHeadersVisualStyles = false;
            this.dgvView.GridColor = System.Drawing.Color.LightGray;
            this.dgvView.Location = new System.Drawing.Point(12, 138);
            this.dgvView.Name = "dgvView";
            this.dgvView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvView.RowHeadersVisible = false;
            this.dgvView.RowTemplate.Height = 40;
            this.dgvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvView.Size = new System.Drawing.Size(873, 350);
            this.dgvView.TabIndex = 19;
            this.dgvView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellMouseEnter);
            this.dgvView.MouseEnter += new System.EventHandler(this.dgvView_MouseEnter);
            // 
            // lblAttendence
            // 
            this.lblAttendence.AutoSize = true;
            this.lblAttendence.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendence.ForeColor = System.Drawing.Color.Black;
            this.lblAttendence.Location = new System.Drawing.Point(202, 19);
            this.lblAttendence.Name = "lblAttendence";
            this.lblAttendence.Size = new System.Drawing.Size(355, 59);
            this.lblAttendence.TabIndex = 17;
            this.lblAttendence.Text = "View Attendence";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightCyan;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "N   Not Provided",
            "L    Leave",
            "A   Absent",
            "P   Present"});
            this.listBox1.Location = new System.Drawing.Point(12, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(112, 62);
            this.listBox1.TabIndex = 21;
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
            this.MainCalender.EntryDate = new System.DateTime(((long)(0)));
            this.MainCalender.FontForDay = new System.Drawing.Font("Lucida Sans", 11F);
            this.MainCalender.FontForMonth = new System.Drawing.Font("Lucida Sans", 11F);
            this.MainCalender.FontForWeek = new System.Drawing.Font("Arial", 9F);
            this.MainCalender.FontForYear = new System.Drawing.Font("Lucida Sans", 11F);
            this.MainCalender.ForeColorDays = System.Drawing.Color.Black;
            this.MainCalender.ForeColorWeek = System.Drawing.Color.Black;
            this.MainCalender.givePriortyForRecentSelect = true;
            this.MainCalender.Location = new System.Drawing.Point(614, 45);
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
            this.MainCalender.TabIndex = 20;
            this.MainCalender.calenderDateChanged += new System.ComponentModel.PropertyChangedEventHandler(this.MainCalender_calenderDateChanged);
            // 
            // AttendenceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(897, 500);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.MainCalender);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.lblAttendence);
            this.Name = "AttendenceView";
            this.Text = "AttendenceView";
            this.Load += new System.EventHandler(this.AttendenceView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Label lblAttendence;
        private User_Control.CustomCalender MainCalender;
        private System.Windows.Forms.ListBox listBox1;
    }
}