using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class AddEmpUC : UserControl
    {
        string gender = "";
        public AddEmpUC()
        {
            InitializeComponent();
        }

        private void AddEmpUC_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {

        }

        private void FinishEmpBtn_Click(object sender, EventArgs e)
        {
           
            EmployeeClass emp = new EmployeeClass();
            emp.name = FnameTextbox.Text + " " + LnameTextbox.Text;
            emp.password = PassTextbox.Text;
            emp.phone = PhoneNumTextbox.Text;
            emp.rank = RankTextBox.Text;
            emp.salary = Convert.ToInt16(SalaryTextbox.Text);
            emp.gender = gender;
            emp.address = AddressTextbox.Text;
            emp.admin_id = 1;
            emp.join_date = Convert.ToDateTime(JoinDatePicker.Text);
          //  MessageBox.Show(emp.join_date.ToString());
            emp.mail = EmailTextbox.Text;
            AdminClass newmanger = new AdminClass();
            newmanger.addmanager(emp);
            



        }

        private void MaleCheck_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void FemaleCheck_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void closeBtn_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.Hide();
        }
    }
}
