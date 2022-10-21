namespace Dream_Hotel.Design.Store
{
    partial class Proforma
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
            this.flwNavigation = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlApproved = new System.Windows.Forms.Panel();
            this.Approved = new System.Windows.Forms.Label();
            this.lblApproved = new System.Windows.Forms.Label();
            this.pnlDisapproved = new System.Windows.Forms.Panel();
            this.Disapproved = new System.Windows.Forms.Label();
            this.lblDisapproved = new System.Windows.Forms.Label();
            this.pnlPending = new System.Windows.Forms.Panel();
            this.Pending = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flwDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.flwNavigation.SuspendLayout();
            this.pnlApproved.SuspendLayout();
            this.pnlDisapproved.SuspendLayout();
            this.pnlPending.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwNavigation
            // 
            this.flwNavigation.Controls.Add(this.pnlApproved);
            this.flwNavigation.Controls.Add(this.pnlDisapproved);
            this.flwNavigation.Controls.Add(this.pnlPending);
            this.flwNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.flwNavigation.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwNavigation.Location = new System.Drawing.Point(0, 0);
            this.flwNavigation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flwNavigation.Name = "flwNavigation";
            this.flwNavigation.Size = new System.Drawing.Size(327, 617);
            this.flwNavigation.TabIndex = 0;
            // 
            // pnlApproved
            // 
            this.pnlApproved.Controls.Add(this.Approved);
            this.pnlApproved.Controls.Add(this.lblApproved);
            this.pnlApproved.Location = new System.Drawing.Point(4, 98);
            this.pnlApproved.Margin = new System.Windows.Forms.Padding(4, 98, 4, 4);
            this.pnlApproved.Name = "pnlApproved";
            this.pnlApproved.Size = new System.Drawing.Size(280, 59);
            this.pnlApproved.TabIndex = 0;
            // 
            // Approved
            // 
            this.Approved.BackColor = System.Drawing.Color.Coral;
            this.Approved.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.Approved.Location = new System.Drawing.Point(8, 16);
            this.Approved.Margin = new System.Windows.Forms.Padding(0);
            this.Approved.Name = "Approved";
            this.Approved.Size = new System.Drawing.Size(45, 28);
            this.Approved.TabIndex = 0;
            this.Approved.Text = "⌄";
            this.Approved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApproved
            // 
            this.lblApproved.AutoSize = true;
            this.lblApproved.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApproved.Location = new System.Drawing.Point(61, 16);
            this.lblApproved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApproved.Name = "lblApproved";
            this.lblApproved.Size = new System.Drawing.Size(208, 29);
            this.lblApproved.TabIndex = 0;
            this.lblApproved.Text = "Approved vouchers";
            // 
            // pnlDisapproved
            // 
            this.pnlDisapproved.Controls.Add(this.Disapproved);
            this.pnlDisapproved.Controls.Add(this.lblDisapproved);
            this.pnlDisapproved.Location = new System.Drawing.Point(4, 198);
            this.pnlDisapproved.Margin = new System.Windows.Forms.Padding(4, 37, 4, 4);
            this.pnlDisapproved.Name = "pnlDisapproved";
            this.pnlDisapproved.Size = new System.Drawing.Size(317, 59);
            this.pnlDisapproved.TabIndex = 1;
            // 
            // Disapproved
            // 
            this.Disapproved.BackColor = System.Drawing.Color.Coral;
            this.Disapproved.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.Disapproved.Location = new System.Drawing.Point(8, 16);
            this.Disapproved.Margin = new System.Windows.Forms.Padding(0);
            this.Disapproved.Name = "Disapproved";
            this.Disapproved.Size = new System.Drawing.Size(45, 28);
            this.Disapproved.TabIndex = 0;
            this.Disapproved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisapproved
            // 
            this.lblDisapproved.AutoSize = true;
            this.lblDisapproved.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisapproved.Location = new System.Drawing.Point(61, 16);
            this.lblDisapproved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisapproved.Name = "lblDisapproved";
            this.lblDisapproved.Size = new System.Drawing.Size(236, 29);
            this.lblDisapproved.TabIndex = 0;
            this.lblDisapproved.Text = "Disapproved vouchers";
            // 
            // pnlPending
            // 
            this.pnlPending.Controls.Add(this.Pending);
            this.pnlPending.Controls.Add(this.lblPending);
            this.pnlPending.Location = new System.Drawing.Point(4, 298);
            this.pnlPending.Margin = new System.Windows.Forms.Padding(4, 37, 4, 4);
            this.pnlPending.Name = "pnlPending";
            this.pnlPending.Size = new System.Drawing.Size(280, 59);
            this.pnlPending.TabIndex = 1;
            // 
            // Pending
            // 
            this.Pending.BackColor = System.Drawing.Color.Coral;
            this.Pending.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.Pending.Location = new System.Drawing.Point(8, 16);
            this.Pending.Margin = new System.Windows.Forms.Padding(0);
            this.Pending.Name = "Pending";
            this.Pending.Size = new System.Drawing.Size(45, 28);
            this.Pending.TabIndex = 0;
            this.Pending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.Location = new System.Drawing.Point(57, 16);
            this.lblPending.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(190, 29);
            this.lblPending.TabIndex = 0;
            this.lblPending.Text = "Pending vouchers";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flwDisplay);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(327, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 617);
            this.panel1.TabIndex = 1;
            // 
            // flwDisplay
            // 
            this.flwDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flwDisplay.AutoScroll = true;
            this.flwDisplay.Location = new System.Drawing.Point(0, 98);
            this.flwDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flwDisplay.Name = "flwDisplay";
            this.flwDisplay.Size = new System.Drawing.Size(872, 518);
            this.flwDisplay.TabIndex = 2;
            this.flwDisplay.MouseEnter += new System.EventHandler(this.flwDisplay_MouseEnter);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(8, 23);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(343, 49);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Approved vouchers";
            // 
            // Proforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flwNavigation);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Proforma";
            this.Text = "Proforma";
            this.Activated += new System.EventHandler(this.Proforma_Activated);
            this.Load += new System.EventHandler(this.Proforma_Load);
            this.flwNavigation.ResumeLayout(false);
            this.pnlApproved.ResumeLayout(false);
            this.pnlApproved.PerformLayout();
            this.pnlDisapproved.ResumeLayout(false);
            this.pnlDisapproved.PerformLayout();
            this.pnlPending.ResumeLayout(false);
            this.pnlPending.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwNavigation;
        private System.Windows.Forms.Panel pnlApproved;
        private System.Windows.Forms.Label lblApproved;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Approved;
        private System.Windows.Forms.Panel pnlDisapproved;
        private System.Windows.Forms.Label Disapproved;
        private System.Windows.Forms.Label lblDisapproved;
        private System.Windows.Forms.Panel pnlPending;
        private System.Windows.Forms.Label Pending;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.FlowLayoutPanel flwDisplay;
        private System.Windows.Forms.Label lblHeader;
    }
}