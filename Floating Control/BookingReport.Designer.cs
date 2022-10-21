namespace Dream_Hotel
{
    partial class BookingReport
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
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.CodeTag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkIn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkOut = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblRoomNumber.Location = new System.Drawing.Point(152, 16);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(47, 22);
            this.lblRoomNumber.TabIndex = 0;
            this.lblRoomNumber.Text = "Num";
            // 
            // CodeTag
            // 
            this.CodeTag.AutoSize = true;
            this.CodeTag.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeTag.Location = new System.Drawing.Point(12, 18);
            this.CodeTag.Name = "CodeTag";
            this.CodeTag.Size = new System.Drawing.Size(141, 18);
            this.CodeTag.TabIndex = 1;
            this.CodeTag.Text = "Room Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room Type:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblRoomType.Location = new System.Drawing.Point(124, 45);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(95, 22);
            this.lblRoomType.TabIndex = 2;
            this.lblRoomType.Text = "Room Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Check in:";
            // 
            // checkIn
            // 
            this.checkIn.AutoSize = true;
            this.checkIn.Font = new System.Drawing.Font("Open Sans", 12F);
            this.checkIn.Location = new System.Drawing.Point(109, 79);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(46, 22);
            this.checkIn.TabIndex = 4;
            this.checkIn.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Check out:";
            // 
            // checkOut
            // 
            this.checkOut.AutoSize = true;
            this.checkOut.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut.Location = new System.Drawing.Point(126, 111);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(46, 22);
            this.checkOut.TabIndex = 6;
            this.checkOut.Text = "Date";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(12, 141);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(58, 22);
            this.lblPay.TabIndex = 9;
            this.lblPay.Text = "Status";
            // 
            // BookingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 172);
            this.ControlBox = false;
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.CodeTag);
            this.Controls.Add(this.lblRoomNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BookingReport";
            this.Opacity = 0.9D;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label CodeTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label checkIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label checkOut;
        private System.Windows.Forms.Label lblPay;
    }
}
