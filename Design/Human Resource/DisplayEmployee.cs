using Dream_Hotel.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dream_Hotel.Design.Human_Resource
{
    public partial class DisplayEmployee : Form
    {
        static public string Department { get; set; }
        static public string Search { get; set; }
        static public int EmpId { get; set; }
        int StringToIntResult;
        public DisplayEmployee()
        {
            InitializeComponent();
        }



        private void pnlAddEmp_Click(object sender, EventArgs e)
        {
           
           
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            HumanMainPage hm = MdiParent as HumanMainPage;
            AddEmployeePage AddEmp = new AddEmployeePage();
            AddEmp.MdiParent = hm;
            
            AddEmp.Show();

        }
        private void pnlDisplayEmp_Click(object sender, EventArgs e)
        {
            
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            HumanMainPage hm = MdiParent as HumanMainPage;
            DisplayEmployee dispEmp = new DisplayEmployee();
            dispEmp.MdiParent = hm;
            
            dispEmp.Show();
        }

        private void pnlFireEmp_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            HumanMainPage hm = MdiParent as HumanMainPage;
            FireEmployee FireEmp = new FireEmployee();
            FireEmp.MdiParent = hm;
            
            FireEmp.Show();
        }

        private void pnlUpdateEmp_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            HumanMainPage hm = MdiParent as HumanMainPage;
            UpdateEmployee UpdateEmp = new UpdateEmployee();
            UpdateEmp.MdiParent = hm;
            
            UpdateEmp.Show();
        }
        
        private void DisplayEmployee_Load(object sender, EventArgs e)
        {
            txtEmpSearchBox.Text = "Search for Employee by ID";
            btnFireSelectedEmployee.Visible = false;
            btnUpdateSelectedEmployee.Visible = false;


            DataTable t = FetchInfo.SelectDepartement();
            if (t.Rows.Count <= 0)
                return;

            var depName = t.AsEnumerable().Select(tt => tt["name"]).OrderBy(tt => tt).ToList();
            cmbHRDepartment.DataSource = depName;

            cmbHRDepartment.SelectedIndex = -1;
            return;
            // CenterToScreen();

            //..dgvDisplayEmplooyee.DataSource = FetchInfo.SelectEmpolyee();

            /* var wer = new List<dynamic>
             {
                 new
                 {
                     hery = "Woow",
                     id = 2
                 }
             };*/
        }

        private void cmbHRDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtEmpSearchBox.Text = "Search for Employee by ID";
            Department = cmbHRDepartment.SelectedItem.ToString();
            dgvDisplayEmplooyee.DataSource = FetchInfo.SelectEmpolyeeByDepartment(Department);
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            bool result;
            if (txtEmpSearchBox.Text == "")
            {
                txtEmpSearchBox.Text = "Search for Employee by ID";
            }
            else if (result = int.TryParse(txtEmpSearchBox.Text, out StringToIntResult))
            {
                EmpId = StringToIntResult;
                dgvDisplayEmplooyee.DataSource = FetchInfo.SearchEmployeeByID(EmpId);
                if(dgvDisplayEmplooyee.Rows.Count == 0)
                {
                    MessageBox.Show("Employee Not Found");
                }
            }
            else
            {
                txtEmpSearchBox.Text = "Please enter only Employee Id";
            }
        }

        private void txtEmpSearchBox_Click(object sender, EventArgs e)
        {
            if(txtEmpSearchBox.Text == "Search for Employee by ID" || (txtEmpSearchBox.Text == "Please enter only Employee Id"))
                {
                txtEmpSearchBox.Text = "";
            }
        }

        private void dgvDisplayEmplooyee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvDisplayEmplooyee.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(177, 174, 174);
            dgvDisplayEmplooyee.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 126, 115);
            dgvDisplayEmplooyee.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void dgvDisplayEmplooyee_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvDisplayEmplooyee.CurrentRow.DefaultCellStyle.BackColor = Color.White;
            dgvDisplayEmplooyee.DefaultCellStyle.SelectionBackColor = Color.White;
           
        }

        private void dgvDisplayEmplooyee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnFireSelectedEmployee.Visible = true;
            btnUpdateSelectedEmployee.Visible = true;
            dgvDisplayEmplooyee.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(177, 174, 174);
            dgvDisplayEmplooyee.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 126, 115);
            dgvDisplayEmplooyee.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void dgvDisplayEmplooyee_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            btnFireSelectedEmployee.Visible = false;
            btnUpdateSelectedEmployee.Visible = false;
            dgvDisplayEmplooyee.CurrentRow.DefaultCellStyle.BackColor = Color.White;
            dgvDisplayEmplooyee.DefaultCellStyle.SelectionBackColor = Color.White;
        }

        private void btnUpdateSelectedEmployee_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmp = new UpdateEmployee();
            updateEmp.Show();
        }
    }
}
