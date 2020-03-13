namespace Task_Manager
{
    partial class ManagerForm
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
            this.OnViewProj = new System.Windows.Forms.Panel();
            this.OnViewEmp = new System.Windows.Forms.Panel();
            this.OnAddProj = new System.Windows.Forms.Panel();
            this.OnAddMng = new System.Windows.Forms.Panel();
            this.OnHome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.ViewProjBtn = new System.Windows.Forms.Button();
            this.ViewEmpBtn = new System.Windows.Forms.Button();
            this.AssignTasksBtn = new System.Windows.Forms.Button();
            this.AddEmployeeBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OnViewProj
            // 
            this.OnViewProj.BackColor = System.Drawing.Color.Red;
            this.OnViewProj.Location = new System.Drawing.Point(0, 373);
            this.OnViewProj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OnViewProj.Name = "OnViewProj";
            this.OnViewProj.Size = new System.Drawing.Size(13, 86);
            this.OnViewProj.TabIndex = 6;
            this.OnViewProj.Visible = false;
            // 
            // OnViewEmp
            // 
            this.OnViewEmp.BackColor = System.Drawing.Color.Red;
            this.OnViewEmp.Location = new System.Drawing.Point(0, 287);
            this.OnViewEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OnViewEmp.Name = "OnViewEmp";
            this.OnViewEmp.Size = new System.Drawing.Size(13, 86);
            this.OnViewEmp.TabIndex = 5;
            this.OnViewEmp.Visible = false;
            // 
            // OnAddProj
            // 
            this.OnAddProj.BackColor = System.Drawing.Color.Red;
            this.OnAddProj.Location = new System.Drawing.Point(0, 201);
            this.OnAddProj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OnAddProj.Name = "OnAddProj";
            this.OnAddProj.Size = new System.Drawing.Size(13, 86);
            this.OnAddProj.TabIndex = 3;
            this.OnAddProj.Visible = false;
            // 
            // OnAddMng
            // 
            this.OnAddMng.BackColor = System.Drawing.Color.Red;
            this.OnAddMng.Location = new System.Drawing.Point(0, 114);
            this.OnAddMng.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OnAddMng.Name = "OnAddMng";
            this.OnAddMng.Size = new System.Drawing.Size(13, 86);
            this.OnAddMng.TabIndex = 3;
            this.OnAddMng.Visible = false;
            // 
            // OnHome
            // 
            this.OnHome.BackColor = System.Drawing.Color.Red;
            this.OnHome.Location = new System.Drawing.Point(0, 28);
            this.OnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OnHome.Name = "OnHome";
            this.OnHome.Size = new System.Drawing.Size(13, 86);
            this.OnHome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(63, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Manager";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.splitContainer1.Size = new System.Drawing.Size(1045, 506);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = global::Task_Manager.Properties.Resources.Close_128;
            this.CloseBtn.Location = new System.Drawing.Point(276, 4);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(47, 43);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseBtn_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Task_Manager.Properties.Resources.Task_03_128;
            this.pictureBox1.Location = new System.Drawing.Point(7, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer2.Panel1.Controls.Add(this.OnViewProj);
            this.splitContainer2.Panel1.Controls.Add(this.OnViewEmp);
            this.splitContainer2.Panel1.Controls.Add(this.OnAddProj);
            this.splitContainer2.Panel1.Controls.Add(this.OnAddMng);
            this.splitContainer2.Panel1.Controls.Add(this.OnHome);
            this.splitContainer2.Panel1.Controls.Add(this.LogoutBtn);
            this.splitContainer2.Panel1.Controls.Add(this.ViewProjBtn);
            this.splitContainer2.Panel1.Controls.Add(this.ViewEmpBtn);
            this.splitContainer2.Panel1.Controls.Add(this.AssignTasksBtn);
            this.splitContainer2.Panel1.Controls.Add(this.AddEmployeeBtn);
            this.splitContainer2.Panel1.Controls.Add(this.HomeBtn);
            this.splitContainer2.Panel1.Controls.Add(this.WelcomeLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(1045, 461);
            this.splitContainer2.SplitterDistance = 200;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
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
            this.LogoutBtn.Location = new System.Drawing.Point(0, 459);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(177, 86);
            this.LogoutBtn.TabIndex = 6;
            this.LogoutBtn.Text = "Log Out";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogoutBtn_MouseClick);
            // 
            // ViewProjBtn
            // 
            this.ViewProjBtn.BackColor = System.Drawing.Color.Transparent;
            this.ViewProjBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewProjBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewProjBtn.FlatAppearance.BorderSize = 0;
            this.ViewProjBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ViewProjBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ViewProjBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewProjBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.ViewProjBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ViewProjBtn.Location = new System.Drawing.Point(0, 372);
            this.ViewProjBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewProjBtn.Name = "ViewProjBtn";
            this.ViewProjBtn.Size = new System.Drawing.Size(177, 86);
            this.ViewProjBtn.TabIndex = 5;
            this.ViewProjBtn.Text = "View Projects Info";
            this.ViewProjBtn.UseVisualStyleBackColor = false;
            this.ViewProjBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewProjBtn_MouseClick);
            // 
            // ViewEmpBtn
            // 
            this.ViewEmpBtn.BackColor = System.Drawing.Color.Transparent;
            this.ViewEmpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewEmpBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewEmpBtn.FlatAppearance.BorderSize = 0;
            this.ViewEmpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ViewEmpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ViewEmpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewEmpBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.ViewEmpBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ViewEmpBtn.Location = new System.Drawing.Point(0, 286);
            this.ViewEmpBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewEmpBtn.Name = "ViewEmpBtn";
            this.ViewEmpBtn.Size = new System.Drawing.Size(177, 86);
            this.ViewEmpBtn.TabIndex = 8;
            this.ViewEmpBtn.Text = "View Employees Info";
            this.ViewEmpBtn.UseVisualStyleBackColor = false;
            this.ViewEmpBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewEmpBtn_MouseClick);
            // 
            // AssignTasksBtn
            // 
            this.AssignTasksBtn.BackColor = System.Drawing.Color.Transparent;
            this.AssignTasksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AssignTasksBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AssignTasksBtn.FlatAppearance.BorderSize = 0;
            this.AssignTasksBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AssignTasksBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AssignTasksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignTasksBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.AssignTasksBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.AssignTasksBtn.Location = new System.Drawing.Point(0, 200);
            this.AssignTasksBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AssignTasksBtn.Name = "AssignTasksBtn";
            this.AssignTasksBtn.Size = new System.Drawing.Size(177, 86);
            this.AssignTasksBtn.TabIndex = 10;
            this.AssignTasksBtn.Text = "Assign Tasks";
            this.AssignTasksBtn.UseVisualStyleBackColor = false;
            this.AssignTasksBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AssignTasksBtn_MouseClick);
            // 
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployeeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddEmployeeBtn.FlatAppearance.BorderSize = 0;
            this.AddEmployeeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddEmployeeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AddEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.AddEmployeeBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.AddEmployeeBtn.Location = new System.Drawing.Point(0, 114);
            this.AddEmployeeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(177, 86);
            this.AddEmployeeBtn.TabIndex = 2;
            this.AddEmployeeBtn.Text = "Add Employee";
            this.AddEmployeeBtn.UseVisualStyleBackColor = false;
            this.AddEmployeeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddEmployeeBtn_MouseClick);
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
            this.HomeBtn.Location = new System.Drawing.Point(0, 28);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(177, 86);
            this.HomeBtn.TabIndex = 9;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HomeBtn_MouseClick);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WelcomeLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(0, 0);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(177, 28);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome, Ahmed";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(838, 459);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1045, 506);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel OnViewProj;
        private System.Windows.Forms.Panel OnViewEmp;
        private System.Windows.Forms.Panel OnAddProj;
        private System.Windows.Forms.Panel OnAddMng;
        private System.Windows.Forms.Panel OnHome;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ViewProjBtn;
        private System.Windows.Forms.Button ViewEmpBtn;
        private System.Windows.Forms.Button AssignTasksBtn;
        private System.Windows.Forms.Button AddEmployeeBtn;
        private System.Windows.Forms.Button HomeBtn;
        public System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}