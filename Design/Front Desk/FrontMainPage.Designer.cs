namespace Dream_Hotel.Design
{
    partial class FrontMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontMainPage));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.empPic = new CircularPic();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.PicBoxLogo = new System.Windows.Forms.PictureBox();
            this.MenusPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnAttendence = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPic)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).BeginInit();
            this.MenusPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.HeaderPanel.Controls.Add(this.empPic);
            this.HeaderPanel.Controls.Add(this.btnBack);
            this.HeaderPanel.Controls.Add(this.btnForward);
            this.HeaderPanel.Controls.Add(this.panel2);
            this.HeaderPanel.Controls.Add(this.lblDate);
            this.HeaderPanel.Controls.Add(this.PicBoxLogo);
            this.HeaderPanel.Controls.Add(this.MenusPnl);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(859, 109);
            this.HeaderPanel.TabIndex = 0;
            // 
            // empPic
            // 
            this.empPic.BackColor = System.Drawing.Color.DarkGray;
            this.empPic.Dock = System.Windows.Forms.DockStyle.Right;
            this.empPic.Image = ((System.Drawing.Image)(resources.GetObject("empPic.Image")));
            this.empPic.Location = new System.Drawing.Point(785, 0);
            this.empPic.Name = "empPic";
            this.empPic.Size = new System.Drawing.Size(74, 74);
            this.empPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.empPic.TabIndex = 22;
            this.empPic.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(94, 40);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(27, 30);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "←";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.UseCompatibleTextRendering = true;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.ForeColor = System.Drawing.Color.White;
            this.btnForward.Location = new System.Drawing.Point(127, 40);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(27, 33);
            this.btnForward.TabIndex = 0;
            this.btnForward.Text = "→";
            this.btnForward.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnForward.UseCompatibleTextRendering = true;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.btnSignOut);
            this.panel2.Location = new System.Drawing.Point(615, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 27);
            this.panel2.TabIndex = 18;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(0, 0);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserName.MinimumSize = new System.Drawing.Size(0, 27);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(77, 27);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(77, 0);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(77, 27);
            this.btnSignOut.TabIndex = 0;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(90, 18);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(295, 27);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "Wednesday August 10 2022";
            // 
            // PicBoxLogo
            // 
            this.PicBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxLogo.Image")));
            this.PicBoxLogo.Location = new System.Drawing.Point(0, -1);
            this.PicBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PicBoxLogo.Name = "PicBoxLogo";
            this.PicBoxLogo.Size = new System.Drawing.Size(75, 73);
            this.PicBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxLogo.TabIndex = 20;
            this.PicBoxLogo.TabStop = false;
            // 
            // MenusPnl
            // 
            this.MenusPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(126)))), ((int)(((byte)(115)))));
            this.MenusPnl.Controls.Add(this.btnBook);
            this.MenusPnl.Controls.Add(this.btnAttendence);
            this.MenusPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenusPnl.Location = new System.Drawing.Point(0, 74);
            this.MenusPnl.Margin = new System.Windows.Forms.Padding(0);
            this.MenusPnl.Name = "MenusPnl";
            this.MenusPnl.Size = new System.Drawing.Size(859, 35);
            this.MenusPnl.TabIndex = 4;
            // 
            // btnBook
            // 
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(0, 0);
            this.btnBook.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(82, 35);
            this.btnBook.TabIndex = 0;
            this.btnBook.Text = "Booking";
            this.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.UseVisualStyleBackColor = true;
            // 
            // btnAttendence
            // 
            this.btnAttendence.FlatAppearance.BorderSize = 0;
            this.btnAttendence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnAttendence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon;
            this.btnAttendence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendence.Location = new System.Drawing.Point(86, 0);
            this.btnAttendence.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnAttendence.Name = "btnAttendence";
            this.btnAttendence.Size = new System.Drawing.Size(105, 35);
            this.btnAttendence.TabIndex = 1;
            this.btnAttendence.Text = "Attendence";
            this.btnAttendence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendence.UseVisualStyleBackColor = true;
            // 
            // FrontMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 432);
            this.Controls.Add(this.HeaderPanel);
            this.IsMdiContainer = true;
            this.Name = "FrontMainPage";
            this.Text = "MainPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrontMainPage_FormClosed);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).EndInit();
            this.MenusPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.FlowLayoutPanel MenusPnl;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnAttendence;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox PicBoxLogo;
        private CircularPic empPic;
    }
}