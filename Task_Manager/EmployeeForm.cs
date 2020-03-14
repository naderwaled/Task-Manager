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
    public partial class EmployeeForm : Form
    {
        public EmployeeClass empnow = new EmployeeClass();

        public EmployeeForm(EmployeeClass empnow)
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Clear();

            OnHome.Visible = true;
            OnViewProj.Visible = false;
            //ViewTasksUC view = new ViewTasksUC();

            EmployeeClass tasklist = new EmployeeClass();
            List<TaskClass> list = new List<TaskClass>();
            tasklist.displaytasks(ref list, empnow.id);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].status != "Finish")
                {
                    ViewTasksUC view = new ViewTasksUC(list[i],empnow);
                    view.taskStatus.Visible = true;
                    view.ProjectName.Text = list[i].project_name;
                    view.TaskName.Text = list[i].name;
                    view.TaskEmpLabel.Text = list[i].employee_name;
                    view.startDuration.Text = "start on " + list[i].start_time.ToString();
                    view.endDuration.Text = "end on " + list[i].end_time.ToString();
                    view.taskStatus.Text = list[i].status;
                    flowLayoutPanel1.Controls.Add(view);
                }
            }

        }

        private void CloseBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void HomeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ViewTasksUC.taskDescription.Hide();
            ViewTasksUC.cmtOrass.commentTextBox.Clear();
            ViewTasksUC.cmtOrass.Hide();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.BringToFront();
            OnHome.Visible = true;
            OnViewProj.Visible = false;

            //ViewTasksUC view = new ViewTasksUC();
            //flowLayoutPanel1.Controls.Add(view);
            EmployeeClass tasklist = new EmployeeClass();
            List<TaskClass> list = new List<TaskClass>();
            tasklist.displaytasks(ref list, empnow.id);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].status != "Finish")
                {
                    ViewTasksUC view = new ViewTasksUC(list[i],empnow);
                    view.taskStatus.Visible = true;
                    view.ProjectName.Text = list[i].project_name;
                    view.TaskName.Text = list[i].name;
                    view.TaskEmpLabel.Text = list[i].employee_name;
                    view.startDuration.Text = "start on " + list[i].start_time.ToString();
                    view.endDuration.Text = "end on " + list[i].end_time.ToString();
                    view.taskStatus.Text = list[i].status;
                    flowLayoutPanel1.Controls.Add(view);
                }
            }
        }

        private void ViewTasksBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ViewTasksUC.taskDescription.Hide();
            ViewTasksUC.cmtOrass.commentTextBox.Clear();
            ViewTasksUC.cmtOrass.Hide();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.BringToFront();
            OnHome.Visible = false;
            OnViewProj.Visible = true;

            //ViewTasksUC view = new ViewTasksUC();

            EmployeeClass tasklist = new EmployeeClass();
            List<TaskClass> list = new List<TaskClass>();
            tasklist.displaytasks(ref list, empnow.id);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].status == "Finish")
                {
                    ViewTasksUC view = new ViewTasksUC(list[i]);
                    view.TaskFinishedBtn.Visible = false;
                    view.AssignLabelBtn.Visible = false;
                    view.CommentLabelBtn.Visible = false;
                    view.taskStatus.Visible = true;
                    view.ProjectName.Text = list[i].project_name;
                    view.TaskName.Text = list[i].name;
                    view.TaskEmpLabel.Text = list[i].employee_name;
                    view.startDuration.Text = "start on " + list[i].start_time.ToString();
                    view.endDuration.Text = "end on " + list[i].end_time.ToString();
                    view.taskStatus.Text = list[i].status;
                    flowLayoutPanel1.Controls.Add(view);
                }
            }

        }

        private void LogoutBtn_MouseClick(object sender, MouseEventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Close();
            log.Show();
            LoginForm.isAdmin = false;
            LoginForm.isManager = false;
            LoginForm.isEmployee = false;
        }

        private void assignedTaskToMe_MouseClick(object sender, MouseEventArgs e)
        {
            OnHome.Visible = false;
            OnViewProj.Visible = false;
            ViewTasksUC.taskDescription.Hide();
            ViewTasksUC.cmtOrass.commentTextBox.Clear();
            ViewTasksUC.cmtOrass.Hide();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.BringToFront();

            //AcceptRejectAssignedTask accrej = new AcceptRejectAssignedTask();
            //flowLayoutPanel1.Controls.Add(accrej);
            EmployeeClass tasklist = new EmployeeClass();
            List<TaskClass> list = new List<TaskClass>();
            tasklist.display_assigntasks(ref list, empnow.id);
            for (int i = 0; i < list.Count; i++)
            {
                    AcceptRejectAssignedTask view = new AcceptRejectAssignedTask(list[i]);
                    view.ProjectName.Text = list[i].project_name;
                    view.TaskName.Text = list[i].name;
                    view.startDuration.Text = "start on " + list[i].start_time.ToString();
                    view.endDuration.Text = "end on " + list[i].end_time.ToString();
                    view.descriptionTask.Text = list[i].description;
                    view.assignedDetails.Text = "This Task Is Assgined To You By " + list[i].employee_name;
                    flowLayoutPanel1.Controls.Add(view);
            }
        }
    }
}
