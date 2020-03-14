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
    public partial class AcceptRejectAssignedTask : UserControl
    {
        TaskClass Task = new TaskClass();
        EmployeeClass employee = new EmployeeClass();
        public AcceptRejectAssignedTask(TaskClass task)
        {
            InitializeComponent();
            //  Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Task = task;
        }

        private void AcceptBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Task.id_employee = Task.assign_employee;
            Task.assign_employee = 0;
            Task.status = "Running";
            employee.edittask(Task);
        }

        private void rejectBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Task.assign_employee = 0;
            Task.status = "Running";
            employee.edittask(Task);
        }
    }
}
