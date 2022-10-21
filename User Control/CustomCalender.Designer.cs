namespace Dream_Hotel.User_Control
{
    partial class CustomCalender
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
            this.DisplayHeader = new System.Windows.Forms.TableLayoutPanel();
            this.btnHeaderDisplay = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.DisplayArea = new System.Windows.Forms.TableLayoutPanel();
            this.DisplayMonth = new System.Windows.Forms.TableLayoutPanel();
            this.DisplayYear = new System.Windows.Forms.TableLayoutPanel();
            this.DisplayHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayHeader
            // 
            this.DisplayHeader.ColumnCount = 3;
            this.DisplayHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.DisplayHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DisplayHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.DisplayHeader.Controls.Add(this.btnHeaderDisplay, 1, 0);
            this.DisplayHeader.Controls.Add(this.btnLeft, 0, 0);
            this.DisplayHeader.Controls.Add(this.btnRight, 2, 0);
            this.DisplayHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.DisplayHeader.Location = new System.Drawing.Point(0, 0);
            this.DisplayHeader.Name = "DisplayHeader";
            this.DisplayHeader.RowCount = 1;
            this.DisplayHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DisplayHeader.Size = new System.Drawing.Size(307, 57);
            this.DisplayHeader.TabIndex = 0;
            // 
            // btnHeaderDisplay
            // 
            this.btnHeaderDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHeaderDisplay.FlatAppearance.BorderSize = 0;
            this.btnHeaderDisplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnHeaderDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHeaderDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderDisplay.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeaderDisplay.Location = new System.Drawing.Point(50, 3);
            this.btnHeaderDisplay.Name = "btnHeaderDisplay";
            this.btnHeaderDisplay.Size = new System.Drawing.Size(207, 51);
            this.btnHeaderDisplay.TabIndex = 0;
            this.btnHeaderDisplay.Text = "Month Year";
            this.btnHeaderDisplay.UseVisualStyleBackColor = true;
            this.btnHeaderDisplay.Click += new System.EventHandler(this.btnHeaderDisplay_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(3, 3);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(41, 51);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(263, 3);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(41, 51);
            this.btnRight.TabIndex = 0;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // DisplayArea
            // 
            this.DisplayArea.ColumnCount = 2;
            this.DisplayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DisplayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DisplayArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayArea.Location = new System.Drawing.Point(0, 57);
            this.DisplayArea.Name = "DisplayArea";
            this.DisplayArea.RowCount = 2;
            this.DisplayArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DisplayArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DisplayArea.Size = new System.Drawing.Size(307, 197);
            this.DisplayArea.TabIndex = 1;
            // 
            // DisplayMonth
            // 
            this.DisplayMonth.ColumnCount = 2;
            this.DisplayMonth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DisplayMonth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DisplayMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayMonth.Location = new System.Drawing.Point(0, 57);
            this.DisplayMonth.Name = "DisplayMonth";
            this.DisplayMonth.RowCount = 2;
            this.DisplayMonth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DisplayMonth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DisplayMonth.Size = new System.Drawing.Size(307, 197);
            this.DisplayMonth.TabIndex = 0;
            // 
            // DisplayYear
            // 
            this.DisplayYear.ColumnCount = 2;
            this.DisplayYear.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DisplayYear.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DisplayYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayYear.Location = new System.Drawing.Point(0, 57);
            this.DisplayYear.Name = "DisplayYear";
            this.DisplayYear.RowCount = 2;
            this.DisplayYear.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DisplayYear.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DisplayYear.Size = new System.Drawing.Size(307, 197);
            this.DisplayYear.TabIndex = 0;
            // 
            // CustomCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DisplayYear);
            this.Controls.Add(this.DisplayMonth);
            this.Controls.Add(this.DisplayArea);
            this.Controls.Add(this.DisplayHeader);
            this.Name = "CustomCalender";
            this.Size = new System.Drawing.Size(307, 254);
            this.DisplayHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel DisplayHeader;
        private System.Windows.Forms.TableLayoutPanel DisplayArea;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnHeaderDisplay;
        private System.Windows.Forms.TableLayoutPanel DisplayMonth;
        private System.Windows.Forms.TableLayoutPanel DisplayYear;
    }
}
