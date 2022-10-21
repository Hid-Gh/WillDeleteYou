using Dream_Hotel.DataBase;
using Dream_Hotel.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dream_Hotel
{
    public partial class SignIn_Page : Form
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

        static public int Id { get; private set; } = 4;

        static public string UserName { get; set; }
        static public string Departement { get; set; }


        public SignIn_Page()
        {
            InitializeComponent();
        }

        private void SignIn_Page_Load(object sender, EventArgs e)
        {
            DataTable t = FetchInfo.SelectDepartement();
            if (t.Rows.Count <= 0)
                return;

            var depName = t.AsEnumerable().Select(tt => tt["name"]).OrderBy(tt => tt).ToList();
            cmbDepartement.DataSource = depName;

            cmbDepartement.SelectedIndex = -1;

            CenterToScreen();

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            UserName = txtUserName.Text;

            if (cmbDepartement.SelectedItem != null)
                Departement = cmbDepartement.SelectedItem.ToString();


            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.Refresh();

            if (Departement == "Front Desk")
                new FrontMainPage().Show();

            else if (Departement == "CEO")
                new ManagerMainPage().Show();

            else if (Departement == "HR Office")
                new HumanMainPage().Show();

            else
                new StoreMainPage().Show();

            Hide();
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.Refresh();

        }

    }
}
