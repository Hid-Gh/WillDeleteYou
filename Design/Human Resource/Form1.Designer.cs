namespace Dream_Hotel.Design.Human_Resource
{
    partial class Form1
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
            this.lblSupplier = new System.Windows.Forms.Label();
            this.pnlDisplayEmployee = new System.Windows.Forms.Panel();
            this.dgvDisplayEmplooyee = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblindicator = new System.Windows.Forms.Label();
            this.pnlUpdateEmp = new System.Windows.Forms.Panel();
            this.lblUpdateEmployee = new System.Windows.Forms.Label();
            this.pnlFireEmp = new System.Windows.Forms.Panel();
            this.lblFireEmployee = new System.Windows.Forms.Label();
            this.pnlAddEmp = new System.Windows.Forms.Panel();
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.pnlDisplayEmp = new System.Windows.Forms.Panel();
            this.lblDispayEmployee = new System.Windows.Forms.Label();
            this.pnlDisplayEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayEmplooyee)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlUpdateEmp.SuspendLayout();
            this.pnlFireEmp.SuspendLayout();
            this.pnlAddEmp.SuspendLayout();
            this.pnlDisplayEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(58, 33);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(187, 49);
            this.lblSupplier.TabIndex = 4;
            this.lblSupplier.Text = "Employee";
            // 
            // pnlDisplayEmployee
            // 
            this.pnlDisplayEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.pnlDisplayEmployee.Controls.Add(this.panel2);
            this.pnlDisplayEmployee.Controls.Add(this.dgvDisplayEmplooyee);
            this.pnlDisplayEmployee.Location = new System.Drawing.Point(67, 128);
            this.pnlDisplayEmployee.Name = "pnlDisplayEmployee";
            this.pnlDisplayEmployee.Size = new System.Drawing.Size(1151, 624);
            this.pnlDisplayEmployee.TabIndex = 5;
            // 
            // dgvDisplayEmplooyee
            // 
            this.dgvDisplayEmplooyee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayEmplooyee.BackgroundColor = System.Drawing.Color.White;
            this.dgvDisplayEmplooyee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisplayEmplooyee.ColumnHeadersHeight = 40;
            this.dgvDisplayEmplooyee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDisplayEmplooyee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.FirstName,
            this.LastName,
            this.DepartmentName});
            this.dgvDisplayEmplooyee.Location = new System.Drawing.Point(30, 34);
            this.dgvDisplayEmplooyee.Name = "dgvDisplayEmplooyee";
            this.dgvDisplayEmplooyee.RowHeadersVisible = false;
            this.dgvDisplayEmplooyee.RowHeadersWidth = 51;
            this.dgvDisplayEmplooyee.RowTemplate.Height = 24;
            this.dgvDisplayEmplooyee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvDisplayEmplooyee.Size = new System.Drawing.Size(1071, 562);
            this.dgvDisplayEmplooyee.TabIndex = 0;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            // 
            // DepartmentName
            // 
            this.DepartmentName.HeaderText = "Department";
            this.DepartmentName.MinimumWidth = 6;
            this.DepartmentName.Name = "DepartmentName";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.lblindicator);
            this.panel2.Controls.Add(this.pnlUpdateEmp);
            this.panel2.Controls.Add(this.pnlFireEmp);
            this.panel2.Controls.Add(this.pnlAddEmp);
            this.panel2.Controls.Add(this.pnlDisplayEmp);
            this.panel2.Location = new System.Drawing.Point(391, -239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 1102);
            this.panel2.TabIndex = 8;
            // 
            // lblindicator
            // 
            this.lblindicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.lblindicator.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblindicator.Location = new System.Drawing.Point(0, 374);
            this.lblindicator.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblindicator.Name = "lblindicator";
            this.lblindicator.Size = new System.Drawing.Size(10, 59);
            this.lblindicator.TabIndex = 7;
            this.lblindicator.Text = "label1";
            // 
            // pnlUpdateEmp
            // 
            this.pnlUpdateEmp.Controls.Add(this.lblUpdateEmployee);
            this.pnlUpdateEmp.Location = new System.Drawing.Point(13, 374);
            this.pnlUpdateEmp.Margin = new System.Windows.Forms.Padding(4, 37, 4, 4);
            this.pnlUpdateEmp.Name = "pnlUpdateEmp";
            this.pnlUpdateEmp.Size = new System.Drawing.Size(352, 59);
            this.pnlUpdateEmp.TabIndex = 4;
            // 
            // lblUpdateEmployee
            // 
            this.lblUpdateEmployee.AutoSize = true;
            this.lblUpdateEmployee.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateEmployee.Location = new System.Drawing.Point(11, 13);
            this.lblUpdateEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateEmployee.Name = "lblUpdateEmployee";
            this.lblUpdateEmployee.Size = new System.Drawing.Size(191, 29);
            this.lblUpdateEmployee.TabIndex = 0;
            this.lblUpdateEmployee.Text = "Update Employee";
            // 
            // pnlFireEmp
            // 
            this.pnlFireEmp.Controls.Add(this.lblFireEmployee);
            this.pnlFireEmp.Location = new System.Drawing.Point(13, 274);
            this.pnlFireEmp.Margin = new System.Windows.Forms.Padding(4, 37, 4, 4);
            this.pnlFireEmp.Name = "pnlFireEmp";
            this.pnlFireEmp.Size = new System.Drawing.Size(352, 59);
            this.pnlFireEmp.TabIndex = 5;
            // 
            // lblFireEmployee
            // 
            this.lblFireEmployee.AutoSize = true;
            this.lblFireEmployee.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFireEmployee.Location = new System.Drawing.Point(11, 13);
            this.lblFireEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFireEmployee.Name = "lblFireEmployee";
            this.lblFireEmployee.Size = new System.Drawing.Size(155, 29);
            this.lblFireEmployee.TabIndex = 0;
            this.lblFireEmployee.Text = "Fire Employee";
            // 
            // pnlAddEmp
            // 
            this.pnlAddEmp.Controls.Add(this.lblAddEmployee);
            this.pnlAddEmp.Location = new System.Drawing.Point(13, 74);
            this.pnlAddEmp.Margin = new System.Windows.Forms.Padding(4, 98, 4, 4);
            this.pnlAddEmp.Name = "pnlAddEmp";
            this.pnlAddEmp.Size = new System.Drawing.Size(352, 59);
            this.pnlAddEmp.TabIndex = 2;
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.Location = new System.Drawing.Point(11, 15);
            this.lblAddEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(158, 29);
            this.lblAddEmployee.TabIndex = 0;
            this.lblAddEmployee.Text = "Add Employee";
            // 
            // pnlDisplayEmp
            // 
            this.pnlDisplayEmp.Controls.Add(this.lblDispayEmployee);
            this.pnlDisplayEmp.Location = new System.Drawing.Point(13, 174);
            this.pnlDisplayEmp.Margin = new System.Windows.Forms.Padding(4, 37, 4, 4);
            this.pnlDisplayEmp.Name = "pnlDisplayEmp";
            this.pnlDisplayEmp.Size = new System.Drawing.Size(352, 59);
            this.pnlDisplayEmp.TabIndex = 3;
            // 
            // lblDispayEmployee
            // 
            this.lblDispayEmployee.AutoSize = true;
            this.lblDispayEmployee.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispayEmployee.Location = new System.Drawing.Point(11, 15);
            this.lblDispayEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDispayEmployee.Name = "lblDispayEmployee";
            this.lblDispayEmployee.Size = new System.Drawing.Size(184, 29);
            this.lblDispayEmployee.TabIndex = 0;
            this.lblDispayEmployee.Text = "Dispay Employee";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 881);
            this.Controls.Add(this.pnlDisplayEmployee);
            this.Controls.Add(this.lblSupplier);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlDisplayEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayEmplooyee)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlUpdateEmp.ResumeLayout(false);
            this.pnlUpdateEmp.PerformLayout();
            this.pnlFireEmp.ResumeLayout(false);
            this.pnlFireEmp.PerformLayout();
            this.pnlAddEmp.ResumeLayout(false);
            this.pnlAddEmp.PerformLayout();
            this.pnlDisplayEmp.ResumeLayout(false);
            this.pnlDisplayEmp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Panel pnlDisplayEmployee;
        private System.Windows.Forms.DataGridView dgvDisplayEmplooyee;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblindicator;
        private System.Windows.Forms.Panel pnlUpdateEmp;
        private System.Windows.Forms.Label lblUpdateEmployee;
        private System.Windows.Forms.Panel pnlFireEmp;
        public System.Windows.Forms.Label lblFireEmployee;
        private System.Windows.Forms.Panel pnlAddEmp;
        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.Panel pnlDisplayEmp;
        private System.Windows.Forms.Label lblDispayEmployee;
    }
}