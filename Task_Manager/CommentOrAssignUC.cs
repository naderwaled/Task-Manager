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
    public partial class CommentOrAssignUC : UserControl
    {
        public TaskClass Task = new TaskClass();
        public EmployeeClass empnow = new EmployeeClass();
        public List<EmployeeClass> emplist = new List<EmployeeClass>();
        public CommentOrAssignUC()
        {
            InitializeComponent();
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            commentTextBox.Clear();
            this.Hide();
        }

        private void AddConfirmBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Task.comment = commentTextBox.Text;
            empnow.edittask(Task);
        }

        private void Send_btn_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < emplist.Count; i++)
            {
                if (emplist[i].name == chooseEmp.Text)
                {
                    empnow = emplist[i];
                    break;
                }
            }
            Task.assign_employee = empnow.id;
            Task.status = "Waitting";
            empnow.edittask(Task);
            MessageBox.Show("Task Sended");
            this.Hide();
        }
    }
}
