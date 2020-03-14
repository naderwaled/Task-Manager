using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Task_Manager;
namespace Task_Manager
{
    public partial class ViewEmpUC : UserControl
    {
        public static AddEmpUC editData = new AddEmpUC();
        public int _id = new int();
        public EmployeeClass emp = new EmployeeClass();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public ViewEmpUC()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void EditEmpLabelBtn_MouseClick(object sender, MouseEventArgs e)
        {
            
            editData.Show();
            editData.closeBtn.Visible = true;
            editData.Location = new Point(250, 200);
            string fname = "", lname = "";
            int j;
            for (j = 0; j < emp.name.Length; j++)
            {
                if (emp.name[j] == ' ')
                    break;
                fname += emp.name[j];
            }
            for (; j < emp.name.Length; j++)
            {
                lname += emp.name[j];
            }
            editData.FnameTextbox.Text = fname;
            editData.LnameTextbox.Text = lname;
            editData.PhoneNumTextbox.Text = emp.phone;
            editData.SalaryTextbox.Text = emp.salary.ToString();
            editData.AddressTextbox.Text = emp.address;
            editData.JoinDatePicker.Text = emp.join_date.ToString();
            editData.EmailTextbox.Text = emp.mail;
            editData.RankTextBox.Text = emp.rank;
            editData.emp = emp;
            if(emp.gender=="Male")
            editData.MaleCheck.Checked = true;
            if (emp.gender == "Female")
                editData.FemaleCheck.Checked = true;
            editData.PassTextbox.Text = emp.password;
            ParentForm.Controls.Add(editData);
            editData.FinishEmpBtn.Visible = false;
            editData.editemployee.Visible = true;
            editData.BringToFront();
        }



        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void deleteprojectbtn_MouseClick(object sender, MouseEventArgs e)
        {
            AdminClass adm = new AdminClass();
            adm.delete_project(_id);
            MessageBox.Show("Deleted Successfully");
        }

        private void deleteEmpLabelBtn_MouseClick(object sender, MouseEventArgs e)
        {
            AdminClass adm = new AdminClass();
            adm.delete_employee(_id);
            MessageBox.Show("Deleted Successfully");
        }
    }
}
