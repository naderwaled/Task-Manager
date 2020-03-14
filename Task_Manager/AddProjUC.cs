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
    public partial class AddProjUC : UserControl
    {
        // int addprojtask = 0;
        List<EmployeeClass> managername = new List<EmployeeClass>();
        public int project_id= new int();

        public AddProjUC(string edit)
        {
            InitializeComponent();
            if (edit == "Add")
            {
                FinishAddProjBtn.Visible = true;
                Finisheditbtn.Visible = false;
            }
           
           else  {
                cNameBox.Visible = false;
                cNameLabel.Visible = false;
                cPhoneBox.Visible = false;
                cPhoneLabel.Visible = false;
                cMailBox.Visible = false;
                cMailLabel.Visible = false;
                comboBox1.Visible = false;
                label1.Visible = false;
                FinishAddProjBtn.Visible = false;
                Finisheditbtn.Visible = true;
            }
        }

        private void AddProjUC_Load(object sender, EventArgs e)
        {
            AdminClass adm = new AdminClass();
            managername = adm.viewmanager();
            for(int i = 0; i < managername.Count; i++)
            {
                if (managername[i].rank == "Manager")
                    comboBox1.Items.Add(managername[i].name);
            }
        }

        private void FinishProjBtn_Click(object sender, EventArgs e)
        {
          
            ProjectClass pro = new ProjectClass();
            pro.name = ProjNameTextbox.Text;
            pro.start_time = Convert.ToDateTime(startTime.Text);
            pro.end_time = Convert.ToDateTime(EndTime.Text);
            pro.clinet_name = cNameBox.Text;
            pro.client_mail = cMailBox.Text;
            pro.status="running";
            pro.client_phone = cPhoneBox.Text;
            for (int i = 0; i < managername.Count; i++)
            {
                if (managername[i].name == comboBox1.Text)
                {
                    pro.id_manger = managername[i].id;
                    break;
                }
            }
            pro.description = ProjDescription.Text;
            AdminClass adm = new AdminClass();
            adm.addproject(pro);

            ProjNameTextbox.Clear();
            cNameBox.Clear();
            cMailBox.Clear();
            cPhoneBox.Clear();
            ProjDescription.Clear();
            comboBox1.Text = "";
            MessageBox.Show("Project Added Successfully");
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void Finisheditbtn_MouseClick(object sender, MouseEventArgs e)
        {
            ProjectClass pro = new ProjectClass();
            pro.id = project_id;
            pro.name = ProjNameTextbox.Text;
            pro.start_time = Convert.ToDateTime(startTime.Text);
            pro.end_time = Convert.ToDateTime(EndTime.Text);
            pro.description = ProjDescription.Text;
            AdminClass adm = new AdminClass();
            adm.editproject(pro);
            MessageBox.Show("Edited Successfully");
            this.Hide();
            

          


        }



        /* private void AddProjTaskBtn_MouseClick(object sender, MouseEventArgs e)
         {
             addprojtask++;

             Label tasknum = new Label();
             tasknum.Text = "Task " + addprojtask.ToString();
             tasknum.Font = new Font("OCR A", 12, FontStyle.Bold);
             tasknum.AutoSize = true;
             tasknum.BackColor = Color.Transparent;
             tasknum.ForeColor = Color.White;
             tasknum.Location = new Point(600, 55*addprojtask);
             this.Controls.Add(tasknum);

             TextBox 
         }*/

    }
}
