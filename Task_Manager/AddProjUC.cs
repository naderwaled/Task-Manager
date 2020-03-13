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

        public AddProjUC()
        {
            InitializeComponent();
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
            MessageBox.Show(comboBox1.Text);
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
                    MessageBox.Show(pro.id_manger.ToString());
                    break;
                }
            }
            pro.description = ProjDescription.Text;
            AdminClass adm = new AdminClass();
            adm.addproject(pro);
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
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
