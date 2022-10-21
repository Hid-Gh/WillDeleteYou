using Dream_Hotel.All_Methods;
using Dream_Hotel.Design.Human_Resource;
using Dream_Hotel.Design.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dream_Hotel.Design
{
    public partial class HumanMainPage : Form
    {
        bool closed = true;

        public Panel indicator = new Panel {
            BackColor = Color.Black
        };
        public Form[] switchList;

        public HumanMainPage()
        {
            InitializeComponent();
            CenterToScreen();

            MDIClientSupport.SetBevel(this, false);
            HeaderPanel.Controls.Add(indicator);

            foreach (Control c in MenusPnl.Controls)
            {
                c.MouseClick += btnBook_MouseClick;
            }

        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                return;

            int i = Array.IndexOf(MdiChildren, ActiveMdiChild.FindForm());

            if (i >= MdiChildren.Length - 1)
                return;

            MdiChildren[i + 1].BringToFront();
            Refresh();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                return;

            int i = Array.IndexOf(MdiChildren, ActiveMdiChild.FindForm());

            if (i < 1)
                return;

            MdiChildren[i - 1].BringToFront();
            Refresh();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd , MMMM dd , yyy");
            switchList = new Form[MenusPnl.Controls.Count];
            Methods.SwitchForms<DisplayEmployee>(MenusPnl.Controls[0] as Button, indicator, this, switchList, Color.Transparent);
            indicator.Size = new Size(0, 6);

            lblUserName.Text = SignIn_Page.UserName;
        }


        private void btnBook_MouseClick(object sender, MouseEventArgs e)
        {

            Button btn = sender as Button;

            if (btn.Text == "Employee")
                Methods.SwitchForms<DisplayEmployee>(btn, indicator, this, switchList, Color.Transparent);

            else
                Methods.SwitchForms<AddEmployeePage>(btn, indicator, this, switchList, Color.Transparent);

        }

        private void StoreMainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closed)
                Application.Exit();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            closed = false;
            Close();
        }
    }
    }

