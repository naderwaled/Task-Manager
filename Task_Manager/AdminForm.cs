using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Manager;


namespace Task_Manager
{
    public partial class AdminForm : Form
    {

        public FlowLayoutPanel empViewPanel = new FlowLayoutPanel();
        public FlowLayoutPanel projViewPanel = new FlowLayoutPanel();
        public FlowLayoutPanel projectsView = new FlowLayoutPanel();

        public AdminForm()
        {
            InitializeComponent();

            splitContainer2.Panel2.Controls.Clear();
            projectsView.Controls.Clear();
            OnHome.Visible = true;
            OnAddMng.Visible = false;
            OnAddProj.Visible = false;
            OnViewEmp.Visible = false;
            OnViewProj.Visible = false;


            projectsView.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(projectsView);
            AdminClass projectlist = new AdminClass();
            List<ProjectClass> list = new List<ProjectClass>(); projectlist.projectview(ref list);
            for (int i = 0; i < list.Count; i++)
            {
                ViewProjUC view = new ViewProjUC();
                view.ProjectName.Text = list[i].name;
                view.TaskEmpLabel.Text = list[i].manger_name;
                view.startDuration.Text = "strat on " + list[i].start_time.ToString();
                view.endDuration.Text = "end on " + list[i].end_time.ToString();
                projectsView.Controls.Add(view);

            }
        }

        private void CloseBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        public void HomeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            projectsView.Controls.Clear();
            OnHome.Visible = true;
            OnAddMng.Visible = false;
            OnAddProj.Visible = false;
            OnViewEmp.Visible = false;
            OnViewProj.Visible = false;


            projectsView.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(projectsView);
            AdminClass projectlist = new AdminClass();
            List<ProjectClass> list = new List<ProjectClass>(); projectlist.projectview(ref list);
            for (int i = 0; i < list.Count; i++)
            {
                ViewProjUC view = new ViewProjUC();
                view.ProjectName.Text = list[i].name;
                view.TaskEmpLabel.Text = list[i].manger_name;
                view.startDuration.Text = "strat on " + list[i].start_time.ToString();
                view.endDuration.Text = "end on " + list[i].end_time.ToString();
                projectsView.Controls.Add(view);

            }

        }

        private void AddManagerBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ViewProjUC.projInfo.Hide();
            ViewProjUC.editProj.Hide();
            ViewEmpUC.editData.Hide();
            splitContainer2.Panel2.Controls.Clear();
            
            OnHome.Visible = false;
            OnAddMng.Visible = true;
            OnAddProj.Visible = false;
            OnViewEmp.Visible = false;
            OnViewProj.Visible = false;

            AddEmpUC addEmp = new AddEmpUC();
            addEmp.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(addEmp);
        }

        private void AddProjectBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ViewProjUC.projInfo.Hide();
            ViewProjUC.editProj.Hide();
            ViewEmpUC.editData.Hide();
            splitContainer2.Panel2.Controls.Clear();
            OnHome.Visible = false;
            OnAddMng.Visible = false;
            OnAddProj.Visible = true;
            OnViewEmp.Visible = false;
            OnViewProj.Visible = false;

            AddProjUC addProj = new AddProjUC();
            addProj.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(addProj);
        }

        private void ViewMngBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ViewProjUC.projInfo.Hide();
            ViewProjUC.editProj.Hide();
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

            empViewPanel.Controls.Clear();
            empViewPanel.Dock = DockStyle.Fill;
            empViewPanel.AutoScroll = true;
            empViewPanel.FlowDirection = FlowDirection.LeftToRight;
            empViewCont.Panel2.Controls.Add(empViewPanel);

            // ViewEmpUC viewEmp = new ViewEmpUC();
            //empViewPanel.Controls.Add(viewEmp);
            AdminClass adm = new AdminClass();
            List<EmployeeClass> emplist = adm.viewmanager();
            for(int i = 0; i < emplist.Count; i++)
            {
                ViewEmpUC viewEmp = new ViewEmpUC();
                string fname ="", lname="";
                int j;
                for( j = 0; j < emplist[i].name.Length; j++)
                {
                    if (emplist[i].name[j] == ' ')
                        break;
                    fname += emplist[i].name[j];
                }
                for (; j < emplist[i].name.Length; j++)
                {
                    lname+= emplist[i].name[j]; 
                }
                viewEmp.ViewFName.Text = "First name : "+fname;
                viewEmp.ViewLName.Text = "Last name : " + lname;
                viewEmp.ViewGender.Text = "Gender : " + emplist[i].gender;
                viewEmp.ViewHours.Text = "Hours : " + emplist[i].hours;
                viewEmp.ViewJoinDate.Text = "Join Date : " + emplist[i].join_date.ToString();
                viewEmp.ViewSalary.Text = "Salary : " + (emplist[i].hours * emplist[i].salary).ToString();
                viewEmp.viewRank.Text = "Rank : " + emplist[i].rank;
                viewEmp.ViewPhoneNum.Text = "Phone : " + emplist[i].phone;
                viewEmp.ViewEmail.Text = "Email : " + emplist[i].mail;
                viewEmp.ViewAddress.Text = "Address : " + emplist[i].address;
                empViewPanel.Controls.Add(viewEmp);



            }
        }

        private void ViewProjBtn_MouseClick(object sender, MouseEventArgs e)
        {
            
            ViewProjUC.projInfo.Hide();
            ViewProjUC.editProj.Hide();
            ViewEmpUC.editData.Hide();
            splitContainer2.Panel2.Controls.Clear();
            OnHome.Visible = false;
            OnAddMng.Visible = false;
            OnAddProj.Visible = false;
            OnViewEmp.Visible = false;
            OnViewProj.Visible = true;

            projViewPanel.Controls.Clear();
            projViewPanel.Dock = DockStyle.Fill;
            projViewPanel.AutoScroll = true;
            projViewPanel.FlowDirection = FlowDirection.TopDown;
            splitContainer2.Panel2.Controls.Add(projViewPanel);

            ViewProjUC viewTasks = new ViewProjUC();
            viewTasks.EditLabelBtn.Visible = false;
            projViewPanel.Controls.Add(viewTasks);
        }

        private void LogoutBtn_MouseClick(object sender, MouseEventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Close();
            log.Show();
        }

        
    }
}

