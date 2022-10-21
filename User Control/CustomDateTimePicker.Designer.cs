namespace Dream_Hotel.User_Control
{
    partial class CustomDateTimePicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDateTimePicker));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblShowDate = new System.Windows.Forms.Label();
            this.btnDropCal = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblShowDate);
            this.panel2.Controls.Add(this.btnDropCal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 27);
            this.panel2.TabIndex = 16;
            // 
            // lblShowDate
            // 
            this.lblShowDate.AutoSize = true;
            this.lblShowDate.BackColor = System.Drawing.Color.White;
            this.lblShowDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShowDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDate.Location = new System.Drawing.Point(0, 0);
            this.lblShowDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblShowDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblShowDate.Name = "lblShowDate";
            this.lblShowDate.Size = new System.Drawing.Size(75, 25);
            this.lblShowDate.TabIndex = 14;
            this.lblShowDate.Text = "Full Date    ";
            this.lblShowDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDropCal
            // 
            this.btnDropCal.BackColor = System.Drawing.Color.White;
            this.btnDropCal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDropCal.BackgroundImage")));
            this.btnDropCal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDropCal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDropCal.FlatAppearance.BorderSize = 0;
            this.btnDropCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDropCal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropCal.Location = new System.Drawing.Point(75, 0);
            this.btnDropCal.Margin = new System.Windows.Forms.Padding(0);
            this.btnDropCal.Name = "btnDropCal";
            this.btnDropCal.Size = new System.Drawing.Size(30, 25);
            this.btnDropCal.TabIndex = 0;
            this.btnDropCal.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDropCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDropCal.UseVisualStyleBackColor = false;
            this.btnDropCal.Click += new System.EventHandler(this.btnDropCal_Click);
            // 
            // CustomDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CustomDateTimePicker";
            this.Size = new System.Drawing.Size(107, 27);
            this.Load += new System.EventHandler(this.CustomDateTimePicker_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblShowDate;
        private System.Windows.Forms.Button btnDropCal;
    }
}
