namespace Dream_Hotel.Design.Human_Resource
{
    partial class DisplayEmployee
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
            this.cmbHRDepartment = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtEmpSearchBox = new System.Windows.Forms.TextBox();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.pnlDisplayEmployee = new try13102022.CircularPanel();
            this.btnFireSelectedEmployee = new System.Windows.Forms.Button();
            this.btnUpdateSelectedEmployee = new System.Windows.Forms.Button();
            this.dgvDisplayEmplooyee = new System.Windows.Forms.DataGridView();
            this.pnlDisplayEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayEmplooyee)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHRDepartment
            // 
            this.cmbHRDepartment.FormattingEnabled = true;
            this.cmbHRDepartment.Location = new System.Drawing.Point(1635, 37);
            this.cmbHRDepartment.Name = "cmbHRDepartment";
            this.cmbHRDepartment.Size = new System.Drawing.Size(211, 24);
            this.cmbHRDepartment.TabIndex = 5;
            this.cmbHRDepartment.Text = "Department";
            this.cmbHRDepartment.SelectionChangeCommitted += new System.EventHandler(this.cmbHRDepartment_SelectionChangeCommitted);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(56, 86);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(187, 49);
            this.lblEmployee.TabIndex = 3;
            this.lblEmployee.Text = "Employee";
            // 
            // txtEmpSearchBox
            // 
            this.txtEmpSearchBox.Location = new System.Drawing.Point(507, 37);
            this.txtEmpSearchBox.Name = "txtEmpSearchBox";
            this.txtEmpSearchBox.Size = new System.Drawing.Size(551, 22);
            this.txtEmpSearchBox.TabIndex = 6;
            this.txtEmpSearchBox.Click += new System.EventHandler(this.txtEmpSearchBox_Click);
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(126)))), ((int)(((byte)(115)))));
            this.btnSearchEmployee.FlatAppearance.BorderSize = 0;
            this.btnSearchEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmployee.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmployee.Location = new System.Drawing.Point(1006, 37);
            this.btnSearchEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(79, 25);
            this.btnSearchEmployee.TabIndex = 7;
            this.btnSearchEmployee.Text = "Search";
            this.btnSearchEmployee.UseVisualStyleBackColor = false;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // pnlDisplayEmployee
            // 
            this.pnlDisplayEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.pnlDisplayEmployee.BorderColor = System.Drawing.Color.White;
            this.pnlDisplayEmployee.Controls.Add(this.btnFireSelectedEmployee);
            this.pnlDisplayEmployee.Controls.Add(this.btnUpdateSelectedEmployee);
            this.pnlDisplayEmployee.Controls.Add(this.dgvDisplayEmplooyee);
            this.pnlDisplayEmployee.Edge = 20;
            this.pnlDisplayEmployee.Location = new System.Drawing.Point(84, 181);
            this.pnlDisplayEmployee.Name = "pnlDisplayEmployee";
            this.pnlDisplayEmployee.Size = new System.Drawing.Size(1828, 778);
            this.pnlDisplayEmployee.TabIndex = 0;
            // 
            // btnFireSelectedEmployee
            // 
            this.btnFireSelectedEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(126)))), ((int)(((byte)(115)))));
            this.btnFireSelectedEmployee.FlatAppearance.BorderSize = 0;
            this.btnFireSelectedEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFireSelectedEmployee.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireSelectedEmployee.Location = new System.Drawing.Point(1595, 12);
            this.btnFireSelectedEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnFireSelectedEmployee.Name = "btnFireSelectedEmployee";
            this.btnFireSelectedEmployee.Size = new System.Drawing.Size(157, 30);
            this.btnFireSelectedEmployee.TabIndex = 8;
            this.btnFireSelectedEmployee.Text = "Fire Employee";
            this.btnFireSelectedEmployee.UseVisualStyleBackColor = false;
            // 
            // btnUpdateSelectedEmployee
            // 
            this.btnUpdateSelectedEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(126)))), ((int)(((byte)(115)))));
            this.btnUpdateSelectedEmployee.FlatAppearance.BorderSize = 0;
            this.btnUpdateSelectedEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSelectedEmployee.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSelectedEmployee.Location = new System.Drawing.Point(1379, 12);
            this.btnUpdateSelectedEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateSelectedEmployee.Name = "btnUpdateSelectedEmployee";
            this.btnUpdateSelectedEmployee.Size = new System.Drawing.Size(157, 30);
            this.btnUpdateSelectedEmployee.TabIndex = 9;
            this.btnUpdateSelectedEmployee.Text = "Update Employee";
            this.btnUpdateSelectedEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateSelectedEmployee.Click += new System.EventHandler(this.btnUpdateSelectedEmployee_Click);
            // 
            // dgvDisplayEmplooyee
            // 
            this.dgvDisplayEmplooyee.AllowUserToAddRows = false;
            this.dgvDisplayEmplooyee.AllowUserToDeleteRows = false;
            this.dgvDisplayEmplooyee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayEmplooyee.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvDisplayEmplooyee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisplayEmplooyee.ColumnHeadersHeight = 40;
            this.dgvDisplayEmplooyee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDisplayEmplooyee.Location = new System.Drawing.Point(66, 61);
            this.dgvDisplayEmplooyee.Name = "dgvDisplayEmplooyee";
            this.dgvDisplayEmplooyee.RowHeadersVisible = false;
            this.dgvDisplayEmplooyee.RowHeadersWidth = 51;
            this.dgvDisplayEmplooyee.RowTemplate.Height = 24;
            this.dgvDisplayEmplooyee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvDisplayEmplooyee.Size = new System.Drawing.Size(1669, 668);
            this.dgvDisplayEmplooyee.TabIndex = 0;
            this.dgvDisplayEmplooyee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayEmplooyee_CellDoubleClick);
            this.dgvDisplayEmplooyee.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayEmplooyee_CellLeave);
            this.dgvDisplayEmplooyee.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDisplayEmplooyee_CellMouseClick);
            // 
            // DisplayEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pnlDisplayEmployee);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.txtEmpSearchBox);
            this.Controls.Add(this.cmbHRDepartment);
            this.Controls.Add(this.lblEmployee);
            this.Name = "DisplayEmployee";
            this.Text = "DispalyEmployee";
            this.Load += new System.EventHandler(this.DisplayEmployee_Load);
            this.pnlDisplayEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayEmplooyee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbHRDepartment;
        private System.Windows.Forms.DataGridView dgvDisplayEmplooyee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox txtEmpSearchBox;
        private System.Windows.Forms.Button btnSearchEmployee;
        private try13102022.CircularPanel pnlDisplayEmployee;
        private System.Windows.Forms.Button btnFireSelectedEmployee;
        private System.Windows.Forms.Button btnUpdateSelectedEmployee;
    }
}