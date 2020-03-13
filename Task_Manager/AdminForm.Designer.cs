namespace Task_Manager
{
    partial class AdminForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.OnAddMng = new System.Windows.Forms.Panel();
            this.OnViewProj = new System.Windows.Forms.Panel();
            this.OnViewEmp = new System.Windows.Forms.Panel();
            this.OnAddProj = new System.Windows.Forms.Panel();
            this.OnHome = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.ViewProjBtn = new System.Windows.Forms.Button();
            this.ViewMngBtn = new System.Windows.Forms.Button();
            this.AddProjectBtn = new System.Windows.Forms.Button();
            this.AddManagerBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(70, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Manager";
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
            this.splitContainer2.Panel1.Controls.Add(this.OnAddMng);
            this.splitContainer2.Panel1.Controls.Add(this.OnViewProj);
            this.splitContainer2.Panel1.Controls.Add(this.OnViewEmp);
            this.splitContainer2.Panel1.Controls.Add(this.OnAddProj);
            this.splitContainer2.Panel1.Controls.Add(this.OnHome);
            this.splitContainer2.Panel1.Controls.Add(this.LogoutBtn);
            this.splitContainer2.Panel1.Controls.Add(this.ViewProjBtn);
            this.splitContainer2.Panel1.Controls.Add(this.ViewMngBtn);
            this.splitContainer2.Panel1.Controls.Add(this.AddProjectBtn);
            this.splitContainer2.Panel1.Controls.Add(this.AddManagerBtn);
            this.splitContainer2.Panel1.Controls.Add(this.HomeBtn);
            this.splitContainer2.Panel1.Controls.Add(this.WelcomeLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Size = new System.Drawing.Size(1176, 586);
            this.splitContainer2.SplitterDistance = 200;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 0;
            // 
            // OnAddMng
            // 
            this.OnAddMng.BackColor = System.Drawing.Color.Red;
            this.OnAddMng.Location = new System.Drawing.Point(0, 143);
            this.OnAddMng.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OnAddMng.Name = "OnAddMng";
            this.OnAddMng.Size = new System.Drawing.Size(15, 108);
            this.OnAddMng.TabIndex = 3;
            this.OnAddMng.Visible = false;
            // 
            // OnViewProj
            // 
            this.OnViewProj.BackColor = System.Drawing.Color.Red;
            this.OnViewProj.Location = new System.Drawing.Point(0, 467);
            this.OnViewProj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OnViewProj.Name = "OnViewProj";
            this.OnViewProj.Size = new System.Drawing.Size(15, 108);
            this.OnViewProj.TabIndex = 6;
            this.OnViewProj.Visible = false;
            // 
            // OnViewEmp
            // 
            this.OnViewEmp.BackColor = System.Drawing.Color.Red;
            this.OnViewEmp.Location = new System.Drawing.Point(0, 359);
            this.OnViewEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OnViewEmp.Name = "OnViewEmp";
            this.OnViewEmp.Size = new System.Drawing.Size(15, 108);
            this.OnViewEmp.TabIndex = 5;
            this.OnViewEmp.Visible = false;
            // 
            // OnAddProj
            // 
            this.OnAddProj.BackColor = System.Drawing.Color.Red;
            this.OnAddProj.Location = new System.Drawing.Point(0, 251);
            this.OnAddProj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OnAddProj.Name = "OnAddProj";
            this.OnAddProj.Size = new System.Drawing.Size(15, 108);
            this.OnAddProj.TabIndex = 3;
            this.OnAddProj.Visible = false;
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
            this.LogoutBtn.Location = new System.Drawing.Point(0, 575);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(172, 108);
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
            this.ViewProjBtn.Location = new System.Drawing.Point(0, 467);
            this.ViewProjBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewProjBtn.Name = "ViewProjBtn";
            this.ViewProjBtn.Size = new System.Drawing.Size(172, 108);
            this.ViewProjBtn.TabIndex = 5;
            this.ViewProjBtn.Text = "View Projects History";
            this.ViewProjBtn.UseVisualStyleBackColor = false;
            this.ViewProjBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewProjBtn_MouseClick);
            // 
            // ViewMngBtn
            // 
            this.ViewMngBtn.BackColor = System.Drawing.Color.Transparent;
            this.ViewMngBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewMngBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewMngBtn.FlatAppearance.BorderSize = 0;
            this.ViewMngBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ViewMngBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ViewMngBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewMngBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.ViewMngBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ViewMngBtn.Location = new System.Drawing.Point(0, 359);
            this.ViewMngBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewMngBtn.Name = "ViewMngBtn";
            this.ViewMngBtn.Size = new System.Drawing.Size(172, 108);
            this.ViewMngBtn.TabIndex = 8;
            this.ViewMngBtn.Text = "View Managers Info";
            this.ViewMngBtn.UseVisualStyleBackColor = false;
            this.ViewMngBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewMngBtn_MouseClick);
            // 
            // AddProjectBtn
            // 
            this.AddProjectBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddProjectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProjectBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddProjectBtn.FlatAppearance.BorderSize = 0;
            this.AddProjectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddProjectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AddProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProjectBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.AddProjectBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.AddProjectBtn.Location = new System.Drawing.Point(0, 251);
            this.AddProjectBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddProjectBtn.Name = "AddProjectBtn";
            this.AddProjectBtn.Size = new System.Drawing.Size(172, 108);
            this.AddProjectBtn.TabIndex = 10;
            this.AddProjectBtn.Text = "Add Project";
            this.AddProjectBtn.UseVisualStyleBackColor = false;
            this.AddProjectBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddProjectBtn_MouseClick);
            // 
            // AddManagerBtn
            // 
            this.AddManagerBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddManagerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddManagerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddManagerBtn.FlatAppearance.BorderSize = 0;
            this.AddManagerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddManagerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AddManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddManagerBtn.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.AddManagerBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.AddManagerBtn.Location = new System.Drawing.Point(0, 143);
            this.AddManagerBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddManagerBtn.Name = "AddManagerBtn";
            this.AddManagerBtn.Size = new System.Drawing.Size(172, 108);
            this.AddManagerBtn.TabIndex = 2;
            this.AddManagerBtn.Text = "Add Manager/Employee";
            this.AddManagerBtn.UseVisualStyleBackColor = false;
            this.AddManagerBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddManagerBtn_MouseClick);
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
            this.HomeBtn.Size = new System.Drawing.Size(172, 108);
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
            this.WelcomeLabel.Size = new System.Drawing.Size(172, 35);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome, Ahmed";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = global::Task_Manager.Properties.Resources.Close_128;
            this.CloseBtn.Location = new System.Drawing.Point(314, 5);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(35, 35);
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1176, 632);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminForm";
            this.Text = "ManagerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button ViewMngBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ViewProjBtn;
        private System.Windows.Forms.Button AddManagerBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button AddProjectBtn;
        private System.Windows.Forms.Panel OnHome;
        private System.Windows.Forms.Panel OnViewProj;
        private System.Windows.Forms.Panel OnViewEmp;
        private System.Windows.Forms.Panel OnAddProj;
        private System.Windows.Forms.Panel OnAddMng;
        public System.Windows.Forms.Label WelcomeLabel;
    }
}