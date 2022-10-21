namespace Dream_Hotel.Design.Store
{
    partial class RequisitionVoucher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.pnlSupplier = new System.Windows.Forms.Panel();
            this.pnlPhoneNumber = new System.Windows.Forms.Panel();
            this.txtPhoneNumber = new Dream_Hotel.User_Control.CustomTextBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtType = new Dream_Hotel.User_Control.CustomTextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbSupplierName = new System.Windows.Forms.ComboBox();
            this.txtSubCity = new Dream_Hotel.User_Control.CustomTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKebele = new Dream_Hotel.User_Control.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWoreda = new Dream_Hotel.User_Control.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCity = new Dream_Hotel.User_Control.CustomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new Dream_Hotel.User_Control.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlSupplier.SuspendLayout();
            this.pnlPhoneNumber.SuspendLayout();
            this.pnlProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.pnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(56, 22);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(158, 49);
            this.lblSupplier.TabIndex = 2;
            this.lblSupplier.Text = "Supplier";
            // 
            // pnlSupplier
            // 
            this.pnlSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSupplier.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSupplier.Controls.Add(this.pnlPhoneNumber);
            this.pnlSupplier.Controls.Add(this.txtType);
            this.pnlSupplier.Controls.Add(this.lblType);
            this.pnlSupplier.Controls.Add(this.cmbSupplierName);
            this.pnlSupplier.Controls.Add(this.txtSubCity);
            this.pnlSupplier.Controls.Add(this.label7);
            this.pnlSupplier.Controls.Add(this.txtKebele);
            this.pnlSupplier.Controls.Add(this.label4);
            this.pnlSupplier.Controls.Add(this.txtWoreda);
            this.pnlSupplier.Controls.Add(this.label5);
            this.pnlSupplier.Controls.Add(this.txtCity);
            this.pnlSupplier.Controls.Add(this.label6);
            this.pnlSupplier.Controls.Add(this.label3);
            this.pnlSupplier.Controls.Add(this.txtEmail);
            this.pnlSupplier.Controls.Add(this.label2);
            this.pnlSupplier.Controls.Add(this.label1);
            this.pnlSupplier.Location = new System.Drawing.Point(16, 92);
            this.pnlSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSupplier.Name = "pnlSupplier";
            this.pnlSupplier.Size = new System.Drawing.Size(1069, 234);
            this.pnlSupplier.TabIndex = 3;
            // 
            // pnlPhoneNumber
            // 
            this.pnlPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPhoneNumber.AutoSize = true;
            this.pnlPhoneNumber.Controls.Add(this.txtPhoneNumber);
            this.pnlPhoneNumber.Controls.Add(this.txtPrefix);
            this.pnlPhoneNumber.Location = new System.Drawing.Point(739, 63);
            this.pnlPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPhoneNumber.Name = "pnlPhoneNumber";
            this.pnlPhoneNumber.Size = new System.Drawing.Size(303, 36);
            this.pnlPhoneNumber.TabIndex = 31;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPhoneNumber.IsPassword = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(65, 0);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.MinimumSize = new System.Drawing.Size(216, 26);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PlaceHolder = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(238, 30);
            this.txtPhoneNumber.TabIndex = 29;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // txtPrefix
            // 
            this.txtPrefix.BackColor = System.Drawing.Color.White;
            this.txtPrefix.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPrefix.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtPrefix.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtPrefix.ForeColor = System.Drawing.Color.Black;
            this.txtPrefix.Location = new System.Drawing.Point(0, 0);
            this.txtPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.ReadOnly = true;
            this.txtPrefix.Size = new System.Drawing.Size(65, 30);
            this.txtPrefix.TabIndex = 28;
            this.txtPrefix.Text = "+251";
            // 
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtType.IsPassword = false;
            this.txtType.Location = new System.Drawing.Point(727, 186);
            this.txtType.Margin = new System.Windows.Forms.Padding(4);
            this.txtType.Name = "txtType";
            this.txtType.PlaceHolder = "";
            this.txtType.Size = new System.Drawing.Size(317, 32);
            this.txtType.TabIndex = 20;
            this.txtType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(717, 140);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(148, 29);
            this.lblType.TabIndex = 19;
            this.lblType.Text = "Supplier Type";
            // 
            // cmbSupplierName
            // 
            this.cmbSupplierName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplierName.FormattingEnabled = true;
            this.cmbSupplierName.Location = new System.Drawing.Point(25, 63);
            this.cmbSupplierName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSupplierName.Name = "cmbSupplierName";
            this.cmbSupplierName.Size = new System.Drawing.Size(245, 32);
            this.cmbSupplierName.TabIndex = 18;
            this.cmbSupplierName.TextChanged += new System.EventHandler(this.cmbSupplierName_TextChanged);
            this.cmbSupplierName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            // 
            // txtSubCity
            // 
            this.txtSubCity.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtSubCity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSubCity.IsPassword = false;
            this.txtSubCity.Location = new System.Drawing.Point(229, 186);
            this.txtSubCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubCity.Name = "txtSubCity";
            this.txtSubCity.PlaceHolder = "";
            this.txtSubCity.Size = new System.Drawing.Size(149, 32);
            this.txtSubCity.TabIndex = 17;
            this.txtSubCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(220, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sub City";
            // 
            // txtKebele
            // 
            this.txtKebele.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtKebele.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtKebele.IsPassword = false;
            this.txtKebele.Location = new System.Drawing.Point(603, 186);
            this.txtKebele.Margin = new System.Windows.Forms.Padding(4);
            this.txtKebele.Name = "txtKebele";
            this.txtKebele.PlaceHolder = "";
            this.txtKebele.Size = new System.Drawing.Size(60, 32);
            this.txtKebele.TabIndex = 15;
            this.txtKebele.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(593, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kebele";
            // 
            // txtWoreda
            // 
            this.txtWoreda.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtWoreda.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtWoreda.IsPassword = false;
            this.txtWoreda.Location = new System.Drawing.Point(448, 186);
            this.txtWoreda.Margin = new System.Windows.Forms.Padding(4);
            this.txtWoreda.Name = "txtWoreda";
            this.txtWoreda.PlaceHolder = "";
            this.txtWoreda.Size = new System.Drawing.Size(63, 32);
            this.txtWoreda.TabIndex = 13;
            this.txtWoreda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Woreda";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtCity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCity.IsPassword = false;
            this.txtCity.Location = new System.Drawing.Point(25, 186);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.PlaceHolder = "";
            this.txtCity.Size = new System.Drawing.Size(141, 32);
            this.txtCity.TabIndex = 11;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "City";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(733, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone Number";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtEmail.IsPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(359, 63);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceHolder = "";
            this.txtEmail.Size = new System.Drawing.Size(317, 32);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Supplier Name";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(32, 375);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(152, 49);
            this.lblProduct.TabIndex = 4;
            this.lblProduct.Text = "Product";
            // 
            // pnlProduct
            // 
            this.pnlProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProduct.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlProduct.Controls.Add(this.dgvProduct);
            this.pnlProduct.Location = new System.Drawing.Point(21, 427);
            this.pnlProduct.Margin = new System.Windows.Forms.Padding(4);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(1064, 240);
            this.pnlProduct.TabIndex = 5;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.ColumnHeadersHeight = 40;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.GridColor = System.Drawing.Color.LightGray;
            this.dgvProduct.Location = new System.Drawing.Point(28, 49);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProduct.Name = "dgvProduct";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 40;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(983, 176);
            this.dgvProduct.TabIndex = 20;
            this.dgvProduct.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellEndEdit);
            this.dgvProduct.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProduct_DataError);
            this.dgvProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvProduct_KeyUp);
            this.dgvProduct.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvProduct_MouseUp);
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.btnFinish);
            this.pnlNavigation.Controls.Add(this.btnSelect);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 693);
            this.pnlNavigation.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(1184, 65);
            this.pnlNavigation.TabIndex = 6;
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnFinish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnFinish.Location = new System.Drawing.Point(1068, 11);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(100, 39);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnSelect.Location = new System.Drawing.Point(845, 12);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 39);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // Err
            // 
            this.Err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Err.ContainerControl = this;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(200, 378);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(41, 46);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "↺";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // RequisitionVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 758);
            this.ControlBox = false;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.pnlSupplier);
            this.Controls.Add(this.lblSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RequisitionVoucher";
            this.Text = "RequisitionVoucher";
            this.Load += new System.EventHandler(this.RequisitionVoucher_Load);
            this.MouseEnter += new System.EventHandler(this.RequisitionVoucher_MouseEnter);
            this.pnlSupplier.ResumeLayout(false);
            this.pnlSupplier.PerformLayout();
            this.pnlPhoneNumber.ResumeLayout(false);
            this.pnlPhoneNumber.PerformLayout();
            this.pnlProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.pnlNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Panel pnlSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private User_Control.CustomTextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private User_Control.CustomTextBox txtSubCity;
        private System.Windows.Forms.Label label7;
        private User_Control.CustomTextBox txtKebele;
        private System.Windows.Forms.Label label4;
        private User_Control.CustomTextBox txtWoreda;
        private System.Windows.Forms.Label label5;
        private User_Control.CustomTextBox txtCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.ComboBox cmbSupplierName;
        private User_Control.CustomTextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Panel pnlPhoneNumber;
        private User_Control.CustomTextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ErrorProvider Err;
        private System.Windows.Forms.Button btnRefresh;
    }
}