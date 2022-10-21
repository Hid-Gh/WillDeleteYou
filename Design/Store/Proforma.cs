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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dream_Hotel.Design.Store
{
    public partial class Proforma : Form
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

        public Proforma()
        {
            InitializeComponent();
        }

        private void Proforma_Load(object sender, EventArgs e)
        {

            foreach (Control pnl in flwNavigation.Controls)
            {
                pnl.Click += PnlStatus_Click;
                foreach (Control c in pnl.Controls)
                    c.Click += PnlStatus_Click;
            }

            populate('A');
        }

        private void clearNavigator()
        {
            foreach (Control pnl in flwNavigation.Controls)
            {
                pnl.Controls[0].Text = "";
            }
        }

        private void PnlStatus_Click(object sender, EventArgs e)
        {
            Control c = sender as Control;
            char stat;

            clearNavigator();

            if (c.Parent == flwNavigation)
            {
                stat = c.Controls[0].Name[0];
                c.Controls[0].Text = "⌄";
                lblHeader.Text = c.Controls[1].Text;
            }
            else
            {
                stat = c.Parent.Controls[0].Name[0];
                c.Parent.Controls[0].Text = "⌄";
                lblHeader.Text = c.Parent.Controls[1].Text;

            }

            populate(stat);

        }

        private void populate(char c)
        {
            var items = FetchInfo.SelectVoucher(c);
            flwDisplay.Controls.Clear();

            if (items == null)
                return;

            foreach (var item in items)
            {
                Voucher v = new Voucher();
                v.Id = item.Item1;
                v.UpdateId = item.Item2;
                v.Companyname = item.Item3;
                v.CompanyType = item.Item4;
                v.Date = item.Item5;
                v.Tooltip = item.Item6;
                v.Status = c;
                v.BackColor = Color.Silver;
                v.Clicked += C_Click;

                if (c == 'P') 
                {
                    if (v.UpdateId > 0)
                    {
                        v.VoucherStatus = "Updated";
                        v.ForeColor = Color.White;
                        v.BackColor = Color.Brown;
                    }
                    ContextMenu cm = new ContextMenu();

                    if (v.UpdateId > 0)
                        cm.MenuItems.Add("View History" , OnClick);
                    cm.MenuItems.Add("Delete" , OnClick);

                    v.ContextMenu = cm;
                }

                flwDisplay.Controls.Add(v);
            }
        }

        private void OnClick(object sender, EventArgs e)
        {
            var c = (sender as MenuItem).Parent as ContextMenu;
            Voucher vou = c.SourceControl as Voucher;

            if ((sender as MenuItem).Text == "View History")
            {
                lblHeader.Text = "History Of Voucher";
                var items = FetchInfo.SelectHistoryOfVoucher(vou.UpdateId);
                flwDisplay.Controls.Clear();

                if (items == null)
                    return;

                foreach (var item in items)
                {
                    Voucher v = new Voucher();
                    v.Id = item.Item1;
                    v.UpdateId = item.Item2;
                    v.Companyname = item.Item3;
                    v.CompanyType = item.Item4;
                    v.Date = item.Item5;
                    v.Tooltip = item.Item6;

                    v.Status = 'A';
                    v.BackColor = Color.Silver;
                    v.Clicked += C_Click;

                    if (v.UpdateId > 0)
                    {
                        v.VoucherStatus = "Updated";
                        v.ForeColor = Color.White;
                        v.BackColor = Color.Brown;
                    }

                    flwDisplay.Controls.Add(v);
                }
            }
            else
            {
                if (!FetchInfo.SelectVoucher('P').Any(t => t.Item1 == vou.Id))
                    return;

                var delProforma = FetchInfo.SelectListOfProforma(vou.Id).AsEnumerable().Select(t => new {ID = t.Field<int>("ProformaId") }).ToList();
                var xml = Methods.ConvertToXml(delProforma, "ID");

                var lis = new List<dynamic> { new { ID = vou.Id } };
                var xml1 = Methods.ConvertToXml(lis, "ID");

                if (Connect.Connection.State != ConnectionState.Closed)
                    Connect.Connection.Close();

                Connect.Connection.Open();
                try
                {
                    int sup = FetchInfo.SelectSupplier(vou.Id).ID;
                    SqlTransaction transaction = Connect.Connection.BeginTransaction();

                    Methods.cudOperation(xml , "DELETEForAll", "Proforma", transaction);
                    Methods.cudOperation(xml1, "DELETEForAll", "Proforma_Approval", transaction);

                    try
                    {
                        var list1 = new List<dynamic> { new { ID = sup } };
                        var xml2 = Methods.ConvertToXml(list1, "ID");
                        Methods.cudOperation(xml2, "DELETEForAll", "Supplier", transaction);


                    }
                    catch { }

                    transaction.Commit();
                    Methods.Display(this, "Operation was successful", Color.White, Color.Brown, new Size(200, 200), new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0), 200);
                    populate('P');
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Failed " + ex.Message);
                }
                Connect.Connection.Close();

            }
        }

        private void C_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                return;

            Voucher v = sender as Voucher;
            StoreMainPage st = MdiParent as StoreMainPage;

            RequisitionVoucher form = Methods.SwitchForms<RequisitionVoucher>(st.btnReq , st.indicator, st , st.switchList, Color.Transparent) as RequisitionVoucher;
            form.ID = v.Id;
            form.updateId = v.UpdateId;
            form.Status = v.Status;

        }


        private void flwDisplay_MouseEnter(object sender, EventArgs e)
        {
            (sender as Control).Focus();
        }

        private void Proforma_Activated(object sender, EventArgs e)
        {
            char c = lblHeader.Text[0];
            if (c == 'P' || c == 'D' || c == 'A')
              populate(c);
        }
    }
}
