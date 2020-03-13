namespace Task_Manager
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.ViewTasksBtn = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.OnViewProj = new System.Windows.Forms.Panel();
            this.OnHome = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LogoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.LogoutBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LogoutBtn.Location = new System.Drawing.Point(0, 476);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(198, 108);
            this.LogoutBtn.TabIndex = 6;
            this.LogoutBtn.Text = "Log Out";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogoutBtn_MouseClick);
            // 
            // ViewTasksBtn
            // 
            this.ViewTasksBtn.BackColor = System.Drawing.Color.Transparent;
            this.ViewTasksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewTasksBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewTasksBtn.FlatAppearance.BorderSize = 0;
            this.ViewTasksBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ViewTasksBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ViewTasksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewTasksBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.ViewTasksBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ViewTasksBtn.Location = new System.Drawing.Point(0, 143);
            this.ViewTasksBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewTasksBtn.Name = "ViewTasksBtn";
            this.ViewTasksBtn.Size = new System.Drawing.Size(198, 108);
            this.ViewTasksBtn.TabIndex = 5;
            this.ViewTasksBtn.Text = "View All Tasks";
            this.ViewTasksBtn.UseVisualStyleBackColor = false;
            this.ViewTasksBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewTasksBtn_MouseClick);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WelcomeLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(0, 0);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(198, 35);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome, Ahmed";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer2.Panel1.Controls.Add(this.OnViewProj);
            this.splitContainer2.Panel1.Controls.Add(this.OnHome);
            this.splitContainer2.Panel1.Controls.Add(this.LogoutBtn);
            this.splitContainer2.Panel1.Controls.Add(this.ViewTasksBtn);
            this.splitContainer2.Panel1.Controls.Add(this.HomeBtn);
            this.splitContainer2.Panel1.Controls.Add(this.WelcomeLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(1176, 586);
            this.splitContainer2.SplitterDistance = 200;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 0;
            // 
            // OnViewProj
            // 
            this.OnViewProj.BackColor = System.Drawing.Color.Red;
            this.OnViewProj.Location = new System.Drawing.Point(0, 142);
            this.OnViewProj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OnViewProj.Name = "OnViewProj";
            this.OnViewProj.Size = new System.Drawing.Size(15, 108);
            this.OnViewProj.TabIndex = 6;
            this.OnViewProj.Visible = false;
            // 
            // OnHome
            // 
            this.OnHome.BackColor = System.Drawing.Color.Red;
            this.OnHome.Location = new System.Drawing.Point(0, 35);
            this.OnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OnHome.Name = "OnHome";
            this.OnHome.Size = new System.Drawing.Size(15, 108);
            this.OnHome.TabIndex = 2;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.HomeBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.HomeBtn.Location = new System.Drawing.Point(0, 35);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(198, 108);
            this.HomeBtn.TabIndex = 9;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HomeBtn_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(71, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Manager";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel1.Controls.Add(this.CloseBtn);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1176, 632);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 4;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = global::Task_Manager.Properties.Resources.Close_128;
            this.CloseBtn.Location = new System.Drawing.Point(302, 0);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(53, 54);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseBtn_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Task_Manager.Properties.Resources.Task_03_128;
            this.pictureBox1.Location = new System.Drawing.Point(8, -8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(968, 584);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1176, 632);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ViewTasksBtn;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel OnViewProj;
        private System.Windows.Forms.Panel OnHome;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}