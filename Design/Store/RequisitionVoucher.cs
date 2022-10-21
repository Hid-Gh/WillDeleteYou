using Dream_Hotel.DataBase;
using Dream_Hotel.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dream_Hotel.Design.Store
{
    public partial class RequisitionVoucher : Form
    {

        #region .. code for Flucuring ..
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion


        DataTable t;
        private int _id = -1;
        private char _status;
        public int updateId { get; set; } = -1;

        public int ID
        {
            get { return _id; }
            set {
                _id = value;
                if (value <= 0)
                    PopulateNew();

                else
                    fillProduct();
            }
        }


        public char Status
        {
            get { return _status; }
            set {
                _status = value;

                if (value == 'A' || value == 'D')
                {
                    makeTextReadOnly();
                    cmbSupplierName.Enabled = false;
                    dgvProduct.AllowUserToDeleteRows = false;
                }
                else
                {
                    makeTextReadOnly(false);
                    cmbSupplierName.Enabled = true;
                    dgvProduct.AllowUserToDeleteRows = true;

                }

            }
        }


        protected override Point ScrollToControl(Control activeControl)
        {
            return DisplayRectangle.Location;
        }

        public RequisitionVoucher()
        {
            InitializeComponent();

        }


        private void RequisitionVoucher_Load(object sender, EventArgs e)
        {
            Err.Icon = Methods.ResizeIcon(Properties.Resources.error, SystemInformation.SmallIconSize);
            var lis = FetchInfo.SelectSupplier().Select(t => t.Name).OrderBy(t => t).ToList(); 
            cmbSupplierName.DataSource = lis;
            ActiveControl = lblSupplier;
        }


        private void PopulateNew()
        {
            dgvProduct.DefaultCellStyle.SelectionBackColor = Color.LightGray;
          
            t = FetchInfo.SelectListOfProduct();
            t.RowDeleted += T_RowDeleted;

            dgvProduct.DataSource = null;

            DataColumn select = new DataColumn("Selected", typeof(bool));
            select.DefaultValue = false;
            t.Columns.Add(select);

            t.Columns["id"].ReadOnly = true;
            t.Columns["Name"].ReadOnly = true;
            t.Columns["Type Name"].ReadOnly = true;
            t.Columns["Catagory Name"].ReadOnly = true;
            t.Columns["Quantity"].AllowDBNull = false;

            dgvProduct.DataSource = t;
            dgvProduct.Columns["Quantity"].Visible = false;
            dgvProduct.Columns["Selected"].ReadOnly = true;

            btnSelect.Visible = true;
            resizeProduct();

        }

        private void T_RowDeleted(object sender, DataRowChangeEventArgs e)
        {
            t.AcceptChanges(); 
            resizeProduct();
        }

        private void fillProduct()
        {
            dgvProduct.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvProduct.DefaultCellStyle.SelectionForeColor = Color.Black;

            t = FetchInfo.SelectListOfProforma(ID);
            t.Columns["id"].ReadOnly = true;
            t.Columns["Product Name"].ReadOnly = true;
            t.Columns["Type"].ReadOnly = true;

            t.Columns["Quantity"].AllowDBNull = false;
            t.Columns["Unit Price"].AllowDBNull = false;
            t.Columns["Quantity Of Type"].AllowDBNull = false;

            t.Columns.Add("Total Price", typeof(decimal), "[Unit Price] * Quantity");
           
            t.RowDeleted += T_RowDeleted;

            dgvProduct.DataSource = null;
            dgvProduct.DataSource = t;
            dgvProduct.Columns["ProformaId"].Visible = false;
            var sup = FetchInfo.SelectSupplier(ID);

            cmbSupplierName.Text = sup.Name;
            txtType.Text = sup.SType;
            txtPhoneNumber.Text = sup.phoneNumber;
            txtEmail.Text = sup.Email;
            txtCity.Text = sup.City;
            txtSubCity.Text = sup.SubCity;
            txtWoreda.Text = sup.Woreda;
            txtKebele.Text = sup.Kebele;           
            
            resizeProduct();
        }

        private void makeTextReadOnly(bool readOnly = true)
        {
            foreach (CustomTextBox c in pnlSupplier.Controls.OfType<CustomTextBox>())
            {
                c.ReadOnly = readOnly;
                c.BackColor = Color.White;

                btnFinish.Visible = !readOnly;
                btnRefresh.Visible = !readOnly;
                btnSelect.Visible = !readOnly;

                if (Status == 'P')
                    btnSelect.Visible = false;
                

                dgvProduct.ReadOnly = readOnly;

                if (Status == 'N')
                    c.Text = "";
            }

            if (Status == 'N')
            {
                txtPhoneNumber.Text = "";
                cmbSupplierName.Text = "";
            }

        }


        private void resizeProduct()
        {

            int totalHeight = (t.Rows.Count) * dgvProduct.RowTemplate.Height;
            totalHeight += dgvProduct.ColumnHeadersHeight;

             int vert = VerticalScroll.Value;
            lblSupplier.Focus();

            dgvProduct.SuspendLayout();

            pnlProduct.Height -= dgvProduct.Height;
            dgvProduct.Height = totalHeight;
            pnlProduct.Height += totalHeight;

            dgvProduct.ResumeLayout();

            VerticalScroll.Value = vert;
            dgvProduct.Focus();
        }

        private void dgvProduct_MouseUp(object sender, MouseEventArgs e)
        {
            if (Status == 'A' || Status == 'D')
                return;

            foreach (DataGridViewRow row in dgvProduct.SelectedRows)
            {
                try {
                    if (row.Cells["Selected"].Value.ToString() == "True")
                        row.Cells["Selected"].Value = false;

                    else
                        row.Cells["Selected"].Value = true;
                }
                catch { }
            }
        }

        private void dgvProduct_KeyUp(object sender, KeyEventArgs e)
        {
            return; ///Not Here

            if (Status == 'A' || Status == 'D' || Status == 'P')
                return;

            if (e.Control && e.KeyCode == Keys.V)
            {
                foreach( DataGridViewRow r in dgvProduct.SelectedRows)
                {
                    var row = ((DataRowView) r.DataBoundItem).Row;
                    
                    var desRow = t.NewRow();
                    desRow.ItemArray = row.ItemArray.Clone() as object[];
                    t.Rows.InsertAt(desRow, t.Rows.IndexOf(row) + 1);
                    resizeProduct();

                }

            }
        }

        private void RequisitionVoucher_MouseEnter(object sender, EventArgs e)
        {
            lblSupplier.Focus();
        }

        private void dgvProduct_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Invalid Input");
        }


        private void cmbSupplierName_TextChanged(object sender, EventArgs e)
        {

            if (cmbSupplierName.Text.Trim() == "")
                return;

            
            var lis = FetchInfo.SelectSupplier();
            var list1 = (List<string>)cmbSupplierName.DataSource;

            var checkvalues = list1.OrderBy(t => t).Except(lis.Select(t => t.Name).OrderBy(t => t) ).ToList();
            var checkvalues1 = lis.Select(t => t.Name).OrderBy(t => t).Except(list1.OrderBy(t => t)).ToList();

            if(checkvalues.Any() || checkvalues1.Any())
            {
                var c = lis.Select(t => t.Name).OrderBy(t => t).ToList();
                string text = cmbSupplierName.Text;
                cmbSupplierName.DataSource = null;
                cmbSupplierName.DataSource = c;
                cmbSupplierName.Text = text;
            }


            if (lis.Any(t => t.Name.Trim().ToLower() == cmbSupplierName.Text.Trim().ToLower()))
                {
                    var sup = lis.Find(t => t.Name.Trim().ToLower() == cmbSupplierName.Text.Trim().ToLower());

                    cmbSupplierName.Text = sup.Name;
                    txtType.Text = sup.SType;
                    txtPhoneNumber.Text = sup.phoneNumber;
                    txtEmail.Text = sup.Email;
                    txtCity.Text = sup.City;
                    txtSubCity.Text = sup.SubCity;
                    txtWoreda.Text = sup.Woreda;
                    txtKebele.Text = sup.Kebele;
                    Err.Clear();

                }
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dgvProduct.DefaultCellStyle.SelectionBackColor = Color.White;

            for (int i = 0; i < t.Rows.Count; i++)
            {
                DataRow row = t.Rows[i];
                if (row["Selected"].ToString() == "False")
                {
                    row.Delete();
                    i--;
                }
            }

            t.Columns.Remove("Selected");

            DataColumn QuntityOfType = new DataColumn("Quantity Of Type", typeof(double));
            QuntityOfType.DefaultValue = 1;
            QuntityOfType.AllowDBNull = false;
            t.Columns.Add(QuntityOfType);

            DataColumn price = new DataColumn("Unit Price", typeof(double));
            price.DefaultValue = 1;
            price.AllowDBNull = false;
            t.Columns.Add(price);

            t.Columns.Add("Total Price", typeof(decimal), "[Unit Price] * Quantity");



            dgvProduct.Columns["Quantity"].Visible = true;
            dgvProduct.Columns["Unit Price"].DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            dgvProduct.Columns["Quantity"].DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            dgvProduct.Columns["Quantity Of Type"].DefaultCellStyle.SelectionBackColor = Color.Gainsboro;

            dgvProduct.Columns["Quantity Of Type"].DisplayIndex = 3;

            btnSelect.Visible = false;

        }

        private void dgvProduct_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
             string headerText = dgvProduct.Columns[e.ColumnIndex].HeaderText;

            if (headerText == "Quantity Of Type" || headerText == "Unit Price" || headerText == "Quantity")
            {
                try {
                    if (double.Parse(dgvProduct[e.ColumnIndex, e.RowIndex].Value.ToString()) <= 0)
                        dgvProduct[e.ColumnIndex, e.RowIndex].Value = 1;
                }
                catch { }
            }
        }

   
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            CustomTextBox c = sender as CustomTextBox;

            if ((int)e.KeyChar == 22 && Control.ModifierKeys == Keys.Control)
            {
                string paste = Clipboard.GetDataObject().GetData(DataFormats.Text) + "";

                if (!paste.Contains(" "))
                {
                    Err.SetError(c, "");
                    return;
                }

                else
                    e.KeyChar = '\0';
            }

            else if (!char.IsWhiteSpace(e.KeyChar) )
            {
                Err.SetError(c, "");
                return;
            }
            else
                e.KeyChar = '\0';
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control c = sender as Control;
            if (c == txtPhoneNumber)
                c = c.Parent;

            if (e.KeyChar == 22 && ModifierKeys == Keys.Control)
            {
                string paste = Clipboard.GetDataObject().GetData(DataFormats.Text) + "";

                try
                {
                    long.Parse(paste);
                    Err.SetError(c, "");
                    return;
                }
                catch
                {
                    e.KeyChar = '\0';
                }
            }

            else if (char.IsDigit(e.KeyChar))
            {
                Err.SetError(c, "");
                return;
            }

            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = '\0';
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control c = sender as Control;

            if (e.KeyChar == 22 && ModifierKeys == Keys.Control)
            {
                string paste = Clipboard.GetDataObject().GetData(DataFormats.Text) + "";

                if (Regex.IsMatch(paste, @"^[a-zA-Z\s]+$"))
                {
                    Err.SetError(c, "");
                    return;
                }

                else
                    e.KeyChar = '\0';
            }

            else if (char.IsWhiteSpace(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                Err.SetError(c, "");
                return;
            }
            else
                e.KeyChar = '\0';
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateNew();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            var lis = FetchInfo.SelectSupplier();

            var list1 = (List<string>)cmbSupplierName.DataSource;

            var checkvalues = list1.OrderBy(t => t).Except(lis.Select(t => t.Name).OrderBy(t => t)).ToList();
            var checkvalues1 = lis.Select(t => t.Name).OrderBy(t => t).Except(list1.OrderBy(t => t)).ToList();

            if (checkvalues.Any() || checkvalues1.Any())
            {
                var c1 = lis.Select(t => t.Name).OrderBy(t => t).ToList();
                cmbSupplierName.DataSource = c1;
            }

            Control c = sender as Control;

            bool exists = lis.Any(t => t.Email.Trim().ToLower() == c.Text.Trim().ToLower());

            if (c == txtPhoneNumber)
                exists = lis.Any(t => t.phoneNumber.Trim().ToLower() == c.Text.Trim().ToLower());

            if (exists)
            {
                var sup = lis.Find(t => t.Email.Trim().ToLower() == c.Text.Trim().ToLower());

                if (c == txtPhoneNumber)
                    sup = lis.Find(t => t.phoneNumber.Trim().ToLower() == c.Text.Trim().ToLower());

                cmbSupplierName.Text = sup.Name;
                txtType.Text = sup.SType;
                txtPhoneNumber.Text = sup.phoneNumber;
                txtEmail.Text = sup.Email;
                txtCity.Text = sup.City;
                txtSubCity.Text = sup.SubCity;
                txtWoreda.Text = sup.Woreda;
                txtKebele.Text = sup.Kebele;
                Err.Clear();

            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            bool foundError = false;

            foreach (var txt in pnlSupplier.Controls.OfType<CustomTextBox>())
            {
                if (txt.Text.Trim() == "")
                {
                    Err.SetError(txt, "Please Write Valid input");
                    foundError = true;
                }
            }

            if (cmbSupplierName.Text.Trim() == "")
            {
                Err.SetError(cmbSupplierName, "Please Write Valid input");
                foundError = true;
            }

            if (txtPhoneNumber.Text.Trim() == "")
            {
                Err.SetError(pnlPhoneNumber, "Please Write Valid input");
                foundError = true;
            }

            if (btnSelect.Visible)
            {
                MessageBox.Show("Product was not Selected!", "Warning");
                foundError = true;
            }
            else if (t.Rows.Count < 1)
            {
                MessageBox.Show("There is not product!", "Warning");
                PopulateNew();
                foundError = true;
            }

            if (foundError)
                return;

            string IssuedDate = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");

            var lis = t.AsEnumerable().Select(t => new
            {
                ProductId = t["Id"],
                Price = t["Unit Price"],
                Quantity = t["Quantity"],
                EmpId = SignIn_Page.Id,
                IssueDate = IssuedDate,
                QuntityOfType = t["Quantity Of Type"]


            }).ToList();

            var xml = Methods.ConvertToXml(lis, "");

            if (Connect.Connection.State != ConnectionState.Closed)
                Connect.Connection.Close();

            Connect.Connection.Open();
            try
            {
                var listOfSupplier = FetchInfo.SelectSupplier();

                SqlTransaction transaction = Connect.Connection.BeginTransaction();
                Methods.cudOperation(xml , "InsertForAll", "Proforma", transaction);

                int sup = listOfSupplier.Find(t => t.Name.Trim().ToLower() == cmbSupplierName.Text.Trim().ToLower()).ID;

                if (sup < 1)
                {
                    var lisSup = new List<dynamic> {
                        new
                        {
                            Name = cmbSupplierName.Text,
                            SType = txtType.Text,
                            phoneNumber = txtPhoneNumber.Text,
                            Email = txtEmail.Text,
                            City = txtCity.Text,
                            SubCity = txtSubCity.Text,
                            Woreda = txtWoreda.Text,
                            Kebele = txtKebele.Text
                        }};

                    var xmlSup = Methods.ConvertToXml(lisSup, "");
                    sup = Methods.cudOperation(xmlSup, "InsertForAll", "Supplier", transaction);
     
                }

                var ApprovalList = new List<dynamic>();

                if (ID > 0)
                {
                    ApprovalList.Add(new
                    {
                        SupplierId = sup,
                        EmpId = SignIn_Page.Id,
                        IssueDate = IssuedDate,
                        Stas = 'P',
                        DateStatChanged = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"),
                        IsUpdatedId = updateId > 0? updateId : ID
                    });
                }
                else
                {
                    ApprovalList.Add(new
                    {
                        SupplierId = sup,
                        EmpId = SignIn_Page.Id,
                        IssueDate = IssuedDate,
                        Stas = 'P',
                        DateStatChanged = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
                });
                }
                xml = Methods.ConvertToXml(ApprovalList , "");

                Methods.cudOperation(xml , "InsertForAll", "Proforma_Approval", transaction);
                transaction.Commit();

                Methods.Display(this, "Operation was successful", Color.Black, Color.LightGreen, new Size(200, 200), new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0), 200);

            }
            catch (Exception ex) {
                        MessageBox.Show("Failed " + ex.Message);
            }

           Connect.Connection.Close();
            
        }

      
    }
}
