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
    public partial class CommentOrAssignUC : UserControl
    {
        public CommentOrAssignUC()
        {
            InitializeComponent();
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            commentTextBox.Clear();
            this.Hide();
        }
    }
}
