using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Task_Manager
{
    public partial class LoginForm : Form
    {

        public static bool isAdmin = false;
        public static bool isManager = false;
        public static bool isEmployee = false;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void CloseBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void usernameTextbox_Click(object sender, EventArgs e)
        {

            if (usernameTextbox.Text == "Username")
            {
                usernameTextbox.Text = "";
            }
            usernamePic.Image = Properties.Resources.userCyan;
            passwordPic.Image = Properties.Resources.passWhite;
            if (passwordTextbox.Text == "")
            {
                passwordTextbox.Text = "Password";
            }

        }

        private void passwordTextbox_Click(object sender, EventArgs e)
        {
            if (passwordTextbox.Text == "Password")
            {
                passwordTextbox.Text = "";
                passwordTextbox.PasswordChar = '*';

            }
            passwordPic.Image = Properties.Resources.passCyan;
            usernamePic.Image = Properties.Resources.userWhite;
            if (usernameTextbox.Text == "")
            {
                usernameTextbox.Text = "Username";
            }
        }

        private void loginBtn_MouseClick(object sender, MouseEventArgs e)
        {
            

            if (isAdmin)
            {
                AdminClass admin = new AdminClass();
                bool isadmin = admin.loginadmin(usernameTextbox.Text,passwordTextbox.Text,ref admin);
                if (isadmin)
                {
                    this.Hide();
                    AdminForm showAdmin = new AdminForm();
                  
                    showAdmin.WelcomeLabel.Text = "Welcome, "+admin.username;
                    showAdmin.Show();
                }
                else
                {
                    MessageBox.Show("invalid name and password");
                }
            }

            else if (isManager)
            {
                EmployeeClass manager = new EmployeeClass();
                bool isemanager = manager.login(usernameTextbox.Text,passwordTextbox.Text,"Manager",ref manager);
                if (isemanager == true)
                {
                    this.Hide();
                    ManagerForm showManager = new ManagerForm(manager.id);
                    showManager.empnow = manager;
                    showManager.WelcomeLabel.Text = "welcome, "+manager.name;
                    showManager.Show();
                }
                else
                    MessageBox.Show("invalid username and password");
            }

            else if (isEmployee)
            {
                EmployeeClass employee = new EmployeeClass();
                bool isemanager = employee.login(usernameTextbox.Text, passwordTextbox.Text,"Employee", ref employee);
                if (isemanager == true)
                {
                    this.Hide();
                    EmployeeForm showEmployee = new EmployeeForm(employee);
                    showEmployee.empnow = employee;
                    showEmployee.WelcomeLabel.Text = "welcome, " + employee.name;
                    showEmployee.Show();
                }
                else
                    MessageBox.Show("invalid username and password");
            }


            }

        private void LoginForm_MouseClick(object sender, MouseEventArgs e)
        {
            TaskManagerLogo.Focus();
            usernamePic.Image = Properties.Resources.userWhite;
            passwordPic.Image = Properties.Resources.passWhite;
            if (usernameTextbox.Text == "")
            {
                usernameTextbox.Text = "Username";
            }
            if (passwordTextbox.Text == "")
            {
                passwordTextbox.Text = "Password";
                passwordTextbox.PasswordChar = '\0';
            }
        }

        private void AsAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            isAdmin = true;
            AsAdmin.Visible = false;
            AsManager.Visible = false;
            AsEmp.Visible = false;
            usernameTextbox.Visible = true;
            usernamePic.Visible = true;
            passwordTextbox.Visible = true;
            passwordPic.Visible = true;
            panel1.Visible = true;
            loginBtn.Visible = true;
        }

        private void AsManager_MouseClick(object sender, MouseEventArgs e)
        {
            isManager = true;
            AsAdmin.Visible = false;
            AsManager.Visible = false;
            AsEmp.Visible = false;
            usernameTextbox.Visible = true;
            usernamePic.Visible = true;
            passwordTextbox.Visible = true;
            passwordPic.Visible = true;
            panel1.Visible = true;
            loginBtn.Visible = true;
        }

        private void AsEmp_MouseClick(object sender, MouseEventArgs e)
        {
            isEmployee = true;
            AsAdmin.Visible = false;
            AsManager.Visible = false;
            AsEmp.Visible = false;
            usernameTextbox.Visible = true;
            usernamePic.Visible = true;
            passwordTextbox.Visible = true;
            passwordPic.Visible = true;
            panel1.Visible = true;
            loginBtn.Visible = true;
        }

        private void BackBtn_MouseClick(object sender, MouseEventArgs e)
        {
            usernamePic.Image = Properties.Resources.userWhite;
            passwordPic.Image = Properties.Resources.passWhite;
            if (passwordTextbox.Text != "Password")
            {
                passwordTextbox.Clear();
                passwordTextbox.Text = "Password";
                passwordTextbox.PasswordChar = '\0';
            }
            if (usernameTextbox.Text != "Username")
            {
                usernameTextbox.Clear();
                usernameTextbox.Text = "Username";
            }
            isAdmin = isManager = isEmployee = false;
            AsAdmin.Visible = true;
            AsManager.Visible = true;
            AsEmp.Visible = true;
            usernameTextbox.Visible = false;
            usernamePic.Visible = false;
            passwordTextbox.Visible = false;
            passwordPic.Visible = false;
            panel1.Visible = false;
            loginBtn.Visible = false;
        }

  
    }
}
