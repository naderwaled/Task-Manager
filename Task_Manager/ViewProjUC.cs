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

namespace Task_Manager
{
    
    public partial class ViewProjUC : UserControl
    {
        public static ViewEmpUC projInfo = new ViewEmpUC();
        public static AddProjUC editProj = new AddProjUC();
        public static ViewTasksUC viewtasks = new ViewTasksUC();
        public static FlowLayoutPanel tasksPanel = new FlowLayoutPanel();

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
        public ViewProjUC()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
            tasksPanel.Show();
            tasksPanel.BringToFront();
            viewtasks.taskStatus.Visible = true;
            viewtasks.InfoLabelBtn.Visible = false;
            viewtasks.AssignLabelBtn.Visible = false;
            viewtasks.CommentLabelBtn.Visible = false;
            viewtasks.TaskFinishedBtn.Visible = false;
            tasksPanel.Controls.Add(viewtasks);
            viewtasks.Show();

            
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
        }

        private void InfoLabelBtn_MouseClick(object sender, MouseEventArgs e)
        {
            editProj.Hide();
            tasksPanel.Hide();
            projInfo.ViewFName.Text = "Project Name :";
            projInfo.ViewLName.Text = "Start Date :";
            projInfo.ViewGender.Text = "End Date :";
            projInfo.ViewEmail.Text = "Client Name :";
            projInfo.ViewAddress.Text = "Client Phone :";
            projInfo.ViewSalary.Text = "Client E-mail :";
            projInfo.ViewPhoneNum.Text = "Description :";
            projInfo.ViewHours.Visible = false;
            projInfo.viewRank.Visible = false;
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

