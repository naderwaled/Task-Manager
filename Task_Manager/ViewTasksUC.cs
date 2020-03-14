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
    public partial class ViewTasksUC : UserControl
    {
        
        public static ViewTasksUC taskDescription = new ViewTasksUC();
        public static CommentOrAssignUC cmtOrass = new CommentOrAssignUC();
        TaskClass Task = new TaskClass();
        public EmployeeClass employee = new EmployeeClass();
        List<EmployeeClass> emplist = new List<EmployeeClass>();


        public ViewTasksUC()
        {
            InitializeComponent();

        }

        public ViewTasksUC(TaskClass task)
        {
            InitializeComponent();
            //  Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Task = task;
        }
        public ViewTasksUC(TaskClass task,EmployeeClass empnow)
        {
            InitializeComponent();
            //  Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Task = task;
            employee = empnow;
        }

        private void InfoLabelBtn_MouseClick(object sender, MouseEventArgs e)
        {
            cmtOrass.Hide();
            cmtOrass.commentTextBox.Clear();
            taskDescription.ProjectName.Text = "Description :"+Task.description;
            taskDescription.ProjectName.ForeColor = Color.Black;
            taskDescription.startDuration.Text = "Comment :" + Task.comment;
            taskDescription.startDuration.ForeColor = Color.Black;
            taskDescription.TaskName.Visible = false;
            taskDescription.TaskEmpLabel.Visible = false;
            taskDescription.endDuration.Visible = false;
            taskDescription.InfoLabelBtn.Visible = false;
            taskDescription.CommentLabelBtn.Visible = false;
            taskDescription.AssignLabelBtn.Visible = false;
            taskDescription.TaskFinishedBtn.Visible = false;
            taskDescription.closeBtn.Visible = true;
            taskDescription.LightTask.BackColor = Color.Blue;
            taskDescription.BackColor = Color.Silver;
            ParentForm.Controls.Add(taskDescription);
            taskDescription.Location = new Point(500, 200);
            taskDescription.BringToFront();
            taskDescription.Show();


        }

        private void AssignLabelBtn_MouseClick(object sender, MouseEventArgs e)
        {
            taskDescription.Hide();
            cmtOrass.Hide();
            cmtOrass.commentTextBox.Clear();
            cmtOrass.commentTextBox.Visible = false;
            cmtOrass.AddConfirmBtn.Text = "Send";
            cmtOrass.empName.Visible = true;
            cmtOrass.chooseEmp.Visible = true;
            cmtOrass.Send_btn.Visible = true;
            emplist = employee.displayemployee(employee.id,employee.manager_id);
            for (int i = 0; i < emplist.Count; i++)
            {
                cmtOrass.chooseEmp.Items.Add(emplist[i].name);
            }
            ParentForm.Controls.Add(cmtOrass);
            cmtOrass.Location = new Point(500, 200);
            cmtOrass.BringToFront();
            cmtOrass.emplist = emplist;
            cmtOrass.Task = Task;
            //cmtOrass.CommentOrAssignUCrefer(Task, cmtOrass.chooseEmp.Text, emplist);
            cmtOrass.Show();
           
        }

        private void CommentLabelBtn_MouseClick(object sender, MouseEventArgs e)
        {
            taskDescription.Hide();
            cmtOrass.Hide();
            cmtOrass.commentTextBox.Clear();
            cmtOrass.commentTextBox.Visible = true;
            cmtOrass.AddConfirmBtn.Text = "Add";
            cmtOrass.empName.Visible = false;
            cmtOrass.chooseEmp.Visible = false;
            cmtOrass.AddConfirmBtn.Visible = true;
            ParentForm.Controls.Add(cmtOrass);
            cmtOrass.Location = new Point(500, 200);
            cmtOrass.BringToFront();
            cmtOrass.Task = Task;
            cmtOrass.Show();


        }

        private void TaskFinishedBtn_MouseClick(object sender, MouseEventArgs e)
        {
            taskDescription.Hide();
            Task.status = "Finish";
            Task.assign_employee = 0;
            employee.edittask(Task);
            employee.finishproject(Task.id_project);
            employee.calculatehour(Task, employee);
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            
        }
    }
}
