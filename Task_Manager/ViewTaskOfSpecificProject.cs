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
    public partial class ViewTaskOfSpecificProject : UserControl
    {
        public ViewTaskOfSpecificProject()
        {
            InitializeComponent();
        }

        private void ViewTaskOfSpecificProject_Load(object sender, EventArgs e)
        {
            ViewProjUC viewtasks = new ViewProjUC();
            viewTasksFlowLayoutPanel.Controls.Add(viewtasks);
            viewtasks.MoreLabelBtn.Visible = false;
        }
    }
}
