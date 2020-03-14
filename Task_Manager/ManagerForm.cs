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
        public EmployeeClass empnow = new EmployeeClass();

        public ManagerForm(int id)
        {
            InitializeComponent();

            //ProjectClass pro = new ProjectClass();
            flowLayoutPanel1.Controls.Clear();
            OnHome.Visible = true;
            OnAddProj.Visible = false;
            OnViewEmp.Visible = false;
            OnViewProj.Visible = false;

            EmployeeClass projectlist = new EmployeeClass();
            List<ProjectClass> list = new List<ProjectClass>();
            projectlist.displayprojects(ref list,id);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].status != "Finish")
                {
                    ViewProjUC view = new ViewProjUC(list[i]);
                    view.ProjectName.Text = list[i].name;
                    view.TaskEmpLabel.Text = list[i].manger_name;
                    view.startDuration.Text = "start on " + list[i].start_time.ToString();
                    view.endDuration.Text = "end on " + list[i].end_time.ToString();
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
            ViewProjUC.editProj.Hide();
            ViewProjUC.projInfo.Hide();
            ViewProjUC.tasksPanel.Hide();
            ViewEmpUC.editData.Hide();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.BringToFront();
            OnHome.Visible = true;
            OnAddProj.Visible = false;
            OnViewEmp.Visible = false;
            OnViewProj.Visible = false;

            //ProjectClass pro = new ProjectClass();
            //ViewProjUC view = new ViewProjUC(pro);
            // flowLayoutPanel1.Controls.Add(view);

            EmployeeClass projectlist = new EmployeeClass();
            List<ProjectClass> list = new List<ProjectClass>();
            projectlist.displayprojects(ref list,empnow.id);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].status != "Finish")
                {
                    ViewProjUC view = new ViewProjUC(list[i]);
                    view.ProjectName.Text = list[i].name;
                    view.TaskEmpLabel.Text = list[i].manger_name;
                    view.startDuration.Text = "start on " + list[i].start_time.ToString();
                    view.endDuration.Text = "end on " + list[i].end_time.ToString();
                    flowLayoutPanel1.Controls.Add(view);
                }
            }


        }

        private void AssignTasksBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ViewProjUC.editProj.Hide();
            ViewProjUC.projInfo.Hide();
            //ViewProjUC.viewtasks.Hide();
            ViewProjUC.tasksPanel.Hide();
            ViewEmpUC.editData.Hide();
            flowLayoutPanel1.Controls.Clear();
            OnHome.Visible = false;
            OnAddProj.Visible = true;
            OnViewEmp.Visible = false;
            OnViewProj.Visible = false;

            AssignTaskUC assTask = new AssignTaskUC(empnow.id);
            assTask.empnow = empnow;
            assTask.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(assTask);
            assTask.BringToFront();
        }

        private void ViewEmpBtn_MouseClick(object sender, MouseEventArgs e)
        {
            List<EmployeeClass> emplist = empnow.viewemployee(empnow.id);
            ViewProjUC.editProj.Hide();
            ViewProjUC.projInfo.Hide();
            //ViewProjUC.viewtasks.Hide();
            ViewProjUC.tasksPanel.Hide();
            ViewEmpUC.editData.Hide();
            flowLayoutPanel1.Controls.Clear();
            OnHome.Visible = false;
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
            empViewCont.BringToFront();

            TextBox search = new TextBox();
            search.Size = new Size(300, 25);
            search.Text = "Search";
            search.Location = new Point(450, 13);
            empViewCont.Panel1.Controls.Add(search);
            
            FlowLayoutPanel flowPanel = new FlowLayoutPanel();
            flowPanel.Controls.Clear();
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.AutoScroll = true;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            empViewCont.Panel2.Controls.Add(flowPanel);
            //search.TextChanged += new EventHandler(text_filter_change);
            //void text_filter_change(object textsender, EventArgs texte)
            //{
            //    flowPanel.Controls.Clear();   
            //    for (int i = 0; i < emplist.Count; i++)
            //    {
            //        if (emplist[i].name.Contains(search.Text))
            //        {
            //            ViewEmpUC viewEmp = new ViewEmpUC();
            //            string fname = "", lname = "";
            //            int j;
            //            for (j = 0; j < emplist[i].name.Length; j++)
            //            {
            //                if (emplist[i].name[j] == ' ')
            //                    break;
            //                fname += emplist[i].name[j];
            //            }
            //            for (; j < emplist[i].name.Length; j++)
            //            {
            //                lname += emplist[i].name[j];
            //            }
            //            viewEmp.ViewFName.Text = "First name : " + fname;
            //            viewEmp.ViewLName.Text = "Last name : " + lname;
            //            viewEmp.ViewGender.Text = "Gender : " + emplist[i].gender;
            //            viewEmp.ViewHours.Text = "Hours : " + emplist[i].hours;
            //            viewEmp.ViewJoinDate.Text = "Join Date : " + emplist[i].join_date.ToString();
            //            viewEmp.ViewSalary.Text = "Salary : " + (emplist[i].hours * emplist[i].salary).ToString();
            //            viewEmp.viewRank.Text = "Rank : " + emplist[i].rank;
            //            viewEmp.ViewPhoneNum.Text = "Phone : " + emplist[i].phone;
            //            viewEmp.ViewEmail.Text = "Email : " + emplist[i].mail;
            //            viewEmp.ViewAddress.Text = "Address : " + emplist[i].address;
            //            viewEmp.closeBtn.Visible = false;

            //            viewEmp._id = emplist[i].id;
            //            viewEmp.emp = emplist[i];
            //            flowPanel.Controls.Add(viewEmp);
            //        }
            //    }
            //}


           
            for (int i = 0; i < emplist.Count; i++)
            {
                ViewEmpUC viewEmp = new ViewEmpUC();
                string fname = "", lname = "";
                int j;
                for (j = 0; j < emplist[i].name.Length; j++)
                {
                    if (emplist[i].name[j] == ' ')
                        break;
                    fname += emplist[i].name[j];
                }
                for (; j < emplist[i].name.Length; j++)
                {
                    lname += emplist[i].name[j];
                }
                viewEmp.ViewFName.Text = "First name : " + fname;
                viewEmp.ViewLName.Text = "Last name : " + lname;
                viewEmp.ViewGender.Text = "Gender : " + emplist[i].gender;
                viewEmp.ViewHours.Text = "Hours : " + emplist[i].hours;
                viewEmp.ViewJoinDate.Text = "Join Date : " + emplist[i].join_date.ToString();
                viewEmp.ViewSalary.Text = "Salary : " + (emplist[i].hours * emplist[i].salary).ToString();
                viewEmp.viewRank.Text = "Rank : " + emplist[i].rank;
                viewEmp.ViewPhoneNum.Text = "Phone : " + emplist[i].phone;
                viewEmp.ViewEmail.Text = "Email : " + emplist[i].mail;
                viewEmp.ViewAddress.Text = "Address : " + emplist[i].address;
                viewEmp.closeBtn.Visible = false;

                viewEmp._id = emplist[i].id;
                viewEmp.emp = emplist[i];
                flowPanel.Controls.Add(viewEmp);
            }
        }

        private void ViewProjBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ViewProjUC.editProj.Hide();
            ViewProjUC.projInfo.Hide();
            ViewProjUC.tasksPanel.Hide();
            ViewEmpUC.editData.Hide();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.BringToFront();
            OnHome.Visible = false;
            OnAddProj.Visible = false;
            OnViewEmp.Visible = false;
            OnViewProj.Visible = true;
            EmployeeClass projectlist = new EmployeeClass();
            List<ProjectClass> list = new List<ProjectClass>();
            projectlist.displayprojects(ref list, empnow.id);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].status == "Finish")
                {
                    ViewProjUC view = new ViewProjUC(list[i]);
                    view.EditLabelBtn.Visible = false;
                    view.ProjectName.Text = list[i].name;
                    view.TaskEmpLabel.Text = list[i].manger_name;
                    view.startDuration.Text = "start on " + list[i].start_time.ToString();
                    view.endDuration.Text = "end on " + list[i].end_time.ToString();
                    flowLayoutPanel1.Controls.Add(view);
                }
            }
            //ProjectClass pro = new ProjectClass();
            //ViewProjUC viewTasks = new ViewProjUC(pro);
            //flowLayoutPanel1.Controls.Add(viewTasks);
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

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            ViewProjUC.editProj.Hide();
            ViewProjUC.projInfo.Hide();
            //ViewProjUC.viewtasks.Hide();
            ViewProjUC.tasksPanel.Hide();
            ViewEmpUC.editData.Hide();
        }

        private void splitContainer2_Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            ViewProjUC.editProj.Hide();
            ViewProjUC.projInfo.Hide();
            //ViewProjUC.viewtasks.Hide();
            ViewProjUC.tasksPanel.Hide();
            ViewEmpUC.editData.Hide();
        }
    }
}
