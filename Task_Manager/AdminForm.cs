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


        public AdminForm()
        {
            InitializeComponent();

            flowLayoutPanel1.Controls.Clear();
            OnHome.Visible = true;
            OnAddMng.Visible = false;
            OnAddProj.Visible = false;
            OnViewEmp.Visible = false;
            OnViewProj.Visible = false;


            AdminClass projectlist = new AdminClass();
            List<ProjectClass> list = new List<ProjectClass>();
            projectlist.projectview(ref list);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].status != "Finish")
                {
                    ViewProjUC view = new ViewProjUC(list[i]);
                    view.ProjectName.Text = list[i].name;
                    view.TaskEmpLabel.Text = list[i].manger_name;
                    view.startDuration.Text = "Start on " + list[i].start_time.Day + " / " + list[i].start_time.Month + " / " + list[i].start_time.Year;
                    view.endDuration.Text = "End on " + list[i].end_time.Day + " / " + list[i].end_time.Month + " / " + list[i].end_time.Year;
                    flowLayoutPanel1.Controls.Add(view);
                }
            }
        }

        private void CloseBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        public void HomeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.BringToFront();
            OnHome.Visible = true;
            OnAddMng.Visible = false;
            OnAddProj.Visible = false;
            OnViewEmp.Visible = false;
            OnViewProj.Visible = false;

            AdminClass projectlist = new AdminClass();
            List<ProjectClass> list = new List<ProjectClass>();
            projectlist.projectview(ref list);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].status != "Finish")
                {
                    ViewProjUC view = new ViewProjUC(list[i]);
                    view.ProjectName.Text = list[i].name;
                    view.TaskEmpLabel.Text = list[i].manger_name;
                    view.startDuration.Text = "Start on " + list[i].start_time.Day + " / " + list[i].start_time.Month + " / " + list[i].start_time.Year;
                    view.endDuration.Text = "End on " + list[i].end_time.Day + " / " + list[i].end_time.Month + " / " + list[i].end_time.Year;
                    flowLayoutPanel1.Controls.Add(view);
                }
            }

        }

        private void AddManagerBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ViewProjUC.projInfo.Hide();
            ViewProjUC.editProj.Hide();
            ViewProjUC.tasksPanel.Hide();
            ViewEmpUC.editData.Hide();
            flowLayoutPanel1.Controls.Clear();
            
            OnHome.Visible = false;
            OnAddMng.Visible = true;
            OnAddProj.Visible = false;
            OnViewEmp.Visible = false;
            OnViewProj.Visible = false;

            AddEmpUC addEmp = new AddEmpUC();
            addEmp.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(addEmp);
            addEmp.BringToFront();
        }

        private void AddProjectBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ViewProjUC.projInfo.Hide();
            ViewProjUC.editProj.Hide();
            ViewEmpUC.editData.Hide();
            ViewProjUC.tasksPanel.Hide();
            flowLayoutPanel1.Controls.Clear();
            OnHome.Visible = false;
            OnAddMng.Visible = false;
            OnAddProj.Visible = true;
            OnViewEmp.Visible = false;
            OnViewProj.Visible = false;

            AddProjUC addProj = new AddProjUC("Add");
            addProj.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(addProj);
            addProj.BringToFront();
        }

        private void ViewMngBtn_MouseClick(object sender, MouseEventArgs e)
        {
            FlowLayoutPanel empViewPanel = new FlowLayoutPanel();

            AdminClass adm = new AdminClass();
            List<EmployeeClass> emplist = adm.viewmanager();
            ViewProjUC.projInfo.Hide();
            ViewProjUC.editProj.Hide();
            ViewEmpUC.editData.Hide();
            ViewProjUC.tasksPanel.Hide();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.BringToFront();
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
            empViewCont.BringToFront();

            TextBox search = new TextBox();
            search.Size = new Size(300, 25);
            search.Text = "Search";
            search.Location = new Point(450, 13);
            empViewCont.Panel1.Controls.Add(search);
            //search.TextChanged += new EventHandler(txtFilter_TextChanged);

            ////search 
            //void txtFilter_TextChanged(object textsender, EventArgs texte)
            //{
            //    empViewPanel.Controls.Clear();
            //    // Never get here
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
            //            if (emplist[i].rank == "Manager")
            //                viewEmp.deleteEmpLabelBtn.Visible = false;
            //            viewEmp._id = emplist[i].id;
            //            viewEmp.emp = emplist[i];
            //            empViewPanel.Controls.Add(viewEmp);

            //        }

            //    }

            //}

            
            empViewPanel.Controls.Clear();
            empViewPanel.Dock = DockStyle.Fill;
            empViewPanel.AutoScroll = true;
            empViewPanel.FlowDirection = FlowDirection.LeftToRight;
            empViewCont.Panel2.Controls.Add(empViewPanel);

            // ViewEmpUC viewEmp = new ViewEmpUC();
            //empViewPanel.Controls.Add(viewEmp);
           
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
                viewEmp.ViewJoinDate.Text = "Join Date : " + emplist[i].join_date.Day + " / " + emplist[i].join_date.Month + " / " + emplist[i].join_date.Year;
                viewEmp.ViewSalary.Text = "Salary : " + (emplist[i].hours * emplist[i].salary).ToString();
                viewEmp.viewRank.Text = "Rank : " + emplist[i].rank;
                viewEmp.ViewPhoneNum.Text = "Phone : " + emplist[i].phone;
                viewEmp.ViewEmail.Text = "Email : " + emplist[i].mail;
                viewEmp.ViewAddress.Text = "Address : " + emplist[i].address;
                viewEmp.closeBtn.Visible = false;
                if (emplist[i].rank == "Manager")
                    viewEmp.deleteEmpLabelBtn.Visible = false;
                viewEmp._id = emplist[i].id;
                viewEmp.emp = emplist[i];
                empViewPanel.Controls.Add(viewEmp);



            }
        }

        private void ViewProjBtn_MouseClick(object sender, MouseEventArgs e)
        {
            
            ViewProjUC.projInfo.Hide();
            ViewProjUC.editProj.Hide();
            ViewEmpUC.editData.Hide();
            ViewProjUC.tasksPanel.Hide();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.BringToFront();
            OnHome.Visible = false;
            OnAddMng.Visible = false;
            OnAddProj.Visible = false;
            OnViewEmp.Visible = false;
            OnViewProj.Visible = true;
            AdminClass projectlist = new AdminClass();
            List<ProjectClass> list = new List<ProjectClass>(); projectlist.projectview(ref list);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].status == "Finish")
                {
                    ViewProjUC view = new ViewProjUC(list[i]);
                    view.EditLabelBtn.Visible = false;
                    view.ProjectName.Text = list[i].name;
                    view.TaskEmpLabel.Text = list[i].manger_name;
                    view.startDuration.Text = "Start on " + list[i].start_time.Day + " / " + list[i].start_time.Month + " / " + list[i].start_time.Year;
                    view.endDuration.Text = "End on " + list[i].end_time.Day + " / " + list[i].end_time.Month + " / " + list[i].end_time.Year;
                    flowLayoutPanel1.Controls.Add(view);
                }
            }
            //ProjectClass pro = new ProjectClass();
            //ViewProjUC viewTasks = new ViewProjUC(pro);
            //viewTasks.EditLabelBtn.Visible = false;
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
            ViewProjUC.projInfo.Hide();
            ViewProjUC.editProj.Hide();
            ViewEmpUC.editData.Hide();
            ViewProjUC.tasksPanel.Hide();
        }

        private void splitContainer2_Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            ViewProjUC.projInfo.Hide();
            ViewProjUC.editProj.Hide();
            ViewEmpUC.editData.Hide();
            ViewProjUC.tasksPanel.Hide();
        }
    }
}

