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
    public partial class ManagerForm : Form
    {

        public FlowLayoutPanel flowPanel = new FlowLayoutPanel();

        public ManagerForm()
        {
            InitializeComponent();
            ViewProjUC view = new ViewProjUC();
            flowLayoutPanel1.Controls.Add(view);
        }

        private void CloseBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void HomeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ViewProjUC.editProj.Hide();
            ViewProjUC.projInfo.Hide();
            ViewProjUC.viewtasks.Hide();
            ViewProjUC.tasksPanel.Hide();
            ViewEmpUC.editData.Hide();
            splitContainer2.Panel2.Controls.Clear();
            OnHome.Visible = true;
            OnAddMng.Visible = false;
            OnAddProj.Visible = false;
            OnViewEmp.Visible = false;
            OnViewProj.Visible = false;



            flowPanel.Dock = DockStyle.Fill;
            flowPanel.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(flowPanel);
            ViewProjUC view = new ViewProjUC();
            flowPanel.Controls.Add(view);


        }

        private void AddEmployeeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ViewProjUC.editProj.Hide();
            ViewProjUC.projInfo.Hide();
            ViewProjUC.viewtasks.Hide();
            ViewProjUC.tasksPanel.Hide();
            ViewEmpUC.editData.Hide();
            splitContainer2.Panel2.Controls.Clear();
            OnHome.Visible = false;
            OnAddMng.Visible = true;
            OnAddProj.Visible = false;
            OnViewEmp.Visible = false;
            OnViewProj.Visible = false;

            AddEmpUC addEmp = new AddEmpUC();
            addEmp.Dock = DockStyle.Fill;
            splitContainer2.Panel2.BackColor = Color.White;
            splitContainer2.Panel2.Controls.Add(addEmp);
        }

        private void AssignTasksBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ViewProjUC.editProj.Hide();
            ViewProjUC.projInfo.Hide();
            ViewProjUC.viewtasks.Hide();
            ViewProjUC.tasksPanel.Hide();
            ViewEmpUC.editData.Hide();
            splitContainer2.Panel2.Controls.Clear();
            OnHome.Visible = false;
            OnAddMng.Visible = false;
            OnAddProj.Visible = true;
            OnViewEmp.Visible = false;
            OnViewProj.Visible = false;

            AssignTaskUC assTask = new AssignTaskUC();
            assTask.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(assTask);
        }

        private void ViewEmpBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ViewProjUC.editProj.Hide();
            ViewProjUC.projInfo.Hide();
            ViewProjUC.viewtasks.Hide();
            ViewProjUC.tasksPanel.Hide();
            ViewEmpUC.editData.Hide();
            splitContainer2.Panel2.Controls.Clear();
            OnHome.Visible = false;
            OnAddMng.Visible = false;
            OnAddProj.Visible = false;
            OnViewEmp.Visible = true;
            OnViewProj.Visible = false;

            SplitContainer empViewCont = new SplitContainer();
            empViewCont.Dock = DockStyle.Fill;
            empViewCont.Orientation = Orientation.Horizontal;
            empViewCont.SplitterDistance = 50;
            empViewCont.BorderStyle = BorderStyle.FixedSingle;
            empViewCont.FixedPanel = FixedPanel.Panel1;
            splitContainer2.Panel2.Controls.Add(empViewCont);

            TextBox search = new TextBox();
            search.Size = new Size(300, 25);
            search.Text = "Search";
            search.Location = new Point(450, 13);
            empViewCont.Panel1.Controls.Add(search);

            flowPanel.Controls.Clear();
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.AutoScroll = true;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            empViewCont.Panel2.Controls.Add(flowPanel);

            ViewEmpUC viewEmp = new ViewEmpUC();
            viewEmp.closeBtn.Visible = false;
            flowPanel.Controls.Add(viewEmp);
        }

        private void ViewProjBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ViewProjUC.editProj.Hide();
            ViewProjUC.projInfo.Hide();
            ViewProjUC.viewtasks.Hide();
            ViewProjUC.tasksPanel.Hide();
            ViewEmpUC.editData.Hide();
            splitContainer2.Panel2.Controls.Clear();
            OnHome.Visible = false;
            OnAddMng.Visible = false;
            OnAddProj.Visible = false;
            OnViewEmp.Visible = false;
            OnViewProj.Visible = true;

            flowPanel.Controls.Clear();
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.AutoScroll = true;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            splitContainer2.Panel2.BackColor = Color.White;
            splitContainer2.Panel2.Controls.Add(flowPanel);

            ViewProjUC viewTasks = new ViewProjUC();
            flowPanel.Controls.Add(viewTasks);
        }

        private void LogoutBtn_MouseClick(object sender, MouseEventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Close();
            log.Show();
        }
    }
}
