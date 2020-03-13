using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class ViewEmpUC : UserControl
    {
        public static AddEmpUC editData = new AddEmpUC();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public ViewEmpUC()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void EditEmpLabelBtn_MouseClick(object sender, MouseEventArgs e)
        {
            editData.Show();
            editData.closeBtn.Visible = true;
            editData.Location = new Point(250, 200);
            ParentForm.Controls.Add(editData);
            editData.BringToFront();
        }



        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }
    }
}
