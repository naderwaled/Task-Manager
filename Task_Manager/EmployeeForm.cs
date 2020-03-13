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

        public FlowLayoutPanel flowPanel = new FlowLayoutPanel();
        public EmployeeForm()
        {
            InitializeComponent();

            
            OnHome.Visible = true;
            OnViewProj.Visible = false;
            ViewTasksUC view = new ViewTasksUC();
            flowLayoutPanel1.Controls.Add(view);
        }

        private void CloseBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void HomeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            OnHome.Visible = true;
            OnViewProj.Visible = false;


            flowPanel.Dock = DockStyle.Fill;
            flowPanel.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(flowPanel);
            ViewTasksUC view = new ViewTasksUC();
            flowPanel.Controls.Add(view);


        }

        private void ViewTasksBtn_MouseClick(object sender, MouseEventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            OnHome.Visible = false;
            OnViewProj.Visible = true;

            flowPanel.Controls.Clear();
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.AutoScroll = true;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            splitContainer2.Panel2.Controls.Add(flowPanel);

            ViewTasksUC view = new ViewTasksUC();
            view.TaskFinishedBtn.Visible = false;
            view.AssignLabelBtn.Visible = false;
            view.CommentLabelBtn.Visible = false;
            flowPanel.Controls.Add(view);
        }

        private void LogoutBtn_MouseClick(object sender, MouseEventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Close();
            log.Show();
        }
    }
}
