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
    
    public partial class ViewProjUC : UserControl
    {
        public static ViewEmpUC projInfo = new ViewEmpUC();
        public static AddProjUC editProj = new AddProjUC("edit");
        //public static ViewTasksUC viewtasks = new ViewTasksUC();
        public static FlowLayoutPanel tasksPanel = new FlowLayoutPanel();
        ProjectClass project = new ProjectClass();
        public int project_id = new int();

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
        public ViewProjUC(ProjectClass pro)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            project = pro;
        }
       

        private void MoreLabelBtn_MouseClick(object sender, MouseEventArgs e)
        {
            projInfo.Hide();
            editProj.Hide();
            tasksPanel.Size = new Size(850, 400);
            tasksPanel.AutoScroll = true;
            tasksPanel.Location = new Point(350, 200);
            tasksPanel.BackColor = Color.Silver;
            ParentForm.Controls.Add(tasksPanel);
            tasksPanel.Controls.Clear();
            tasksPanel.Show();
            tasksPanel.BringToFront();
            //here
            AdminClass adm = new AdminClass();
            List<TaskClass> tasklist = new List<TaskClass>();
            adm.showtask(ref tasklist,project.id);
            for (int i = 0; i < tasklist.Count; i++)
            {
                ViewTasksUC task = new ViewTasksUC();
                task.taskStatus.Visible = true;
                task.InfoLabelBtn.Visible = false;
                task.AssignLabelBtn.Visible = false;
                task.CommentLabelBtn.Visible = false;
                task.TaskFinishedBtn.Visible = false;
                //here
                task.TaskName.Text = tasklist[i].name;
                task.ProjectName.Text = tasklist[i].project_name;
                task.TaskEmpLabel.Text = tasklist[i].employee_name;
                task.startDuration.Text = "Start on " + tasklist[i].start_time.Day + " / " + tasklist[i].start_time.Month + " / " + tasklist[i].start_time.Year;
                task.endDuration.Text = "End on " + tasklist[i].end_time.Day + " / " + tasklist[i].end_time.Month + " / " + tasklist[i].end_time.Year;
                task.taskStatus.Text = tasklist[i].status;
                tasksPanel.Controls.Add(task);
            }
        }

        private void EditLabelBtn_MouseClick(object sender, MouseEventArgs e)
        {
            projInfo.Hide();
            tasksPanel.Hide();
            editProj.Location = new Point(250, 200);
            ParentForm.Controls.Add(editProj);
            editProj.closeBtn.Visible = true;
            editProj.Show();
            editProj.BringToFront();
            editProj.ProjNameTextbox.Text = project.name;
            editProj.startTime.Text = project.start_time.Day + " / " + project.start_time.Month + " / " + project.start_time.Year;
            editProj.EndTime.Text = project.end_time.Day + " / " + project.end_time.Month + " / " + project.end_time.Year;
            //here
            editProj.comboBox1.Text = project.manger_name;
            editProj.ProjDescription.Text = project.description;
            editProj.project_id = project.id;
        }

        private void InfoLabelBtn_MouseClick(object sender, MouseEventArgs e)
        {
            editProj.Hide();
            tasksPanel.Hide();
            project_id = project.id;
            projInfo._id = project.id;
            projInfo.ViewFName.Text = "Project Name :"+" "+ project.name;
            projInfo.ViewLName.Text = "Start Date :"+" "+ project.start_time.Day + " / " + project.start_time.Month + " / " + project.start_time.Year;
            projInfo.ViewGender.Text = "End Date :" + " " + project.end_time.Day + " / " + project.end_time.Month + " / " + project.end_time.Year;
            projInfo.ViewEmail.Text = "Client Name :"+" "+project.clinet_name;
            projInfo.ViewAddress.Text = "Client Phone :"+" "+project.client_phone;
            projInfo.ViewSalary.Text = "Client E-mail :"+ " "+project.client_mail;
            projInfo.ViewPhoneNum.Text = "Description :"+" "+project.description ;
            projInfo.ViewHours.Visible = false;
            projInfo.viewRank.Visible = false;
            projInfo.deleteEmpLabelBtn.Visible = false;
            projInfo.deleteprojectbtn.Visible = true;
            projInfo.ViewJoinDate.Visible = false;
            projInfo.EditEmpLabelBtn.Visible = false;
            projInfo.deleteEmpLabelBtn.Location = new Point(projInfo.EditEmpLabelBtn.Location.X-25, projInfo.EditEmpLabelBtn.Location.Y);
            projInfo.Location = new Point(300, 200);
            ParentForm.Controls.Add(projInfo);
            projInfo.Show();
            projInfo.BringToFront();
        }
    }

        
}

