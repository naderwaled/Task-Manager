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
    public partial class AssignTaskUC : UserControl
    {
        public EmployeeClass empnow = new EmployeeClass();
        List<EmployeeClass> emplist = new List<EmployeeClass>();
        List<ProjectClass> prolist = new List<ProjectClass>();
        public AssignTaskUC(int id)
        {
            InitializeComponent();
            emplist = empnow.viewemployee(id);
            for(int i = 0; i < emplist.Count; i++)
            {
                empNameBox.Items.Add(emplist[i].name);
            }
            prolist = new List<ProjectClass>();
            empnow.displayprojects(ref prolist,id);
            for(int i = 0; i < prolist.Count; i++)
            {
                projectnamecompo.Items.Add(prolist[i].name);
            }

        }

        private void FinishTaskBtn_MouseClick(object sender, MouseEventArgs e)
        {
            TaskClass task = new TaskClass();
            task.name = TaskNameTextbox.Text;
            task.start_time =Convert.ToDateTime(startTime.Text);
            task.end_time = Convert.ToDateTime(EndTime.Text);
            task.description=ProjDescription.Text;
            for(int i = 0; i < prolist.Count; i++)
            {
                if (prolist[i].name == projectnamecompo.Text)
                {
                    task.id_project = prolist[i].id;
                    break;
                }
            }
            for (int i = 0; i < emplist.Count; i++)
            {
                if (emplist[i].name == empNameBox.Text)
                {
                    task.id_employee = emplist[i].id;
                    break;
                }
            }

            empnow.AssignTask(task);

            empNameBox.Text = "";
            ProjDescription.Clear();
            MessageBox.Show("Task Assigned Successfully");


        }
    }
}
