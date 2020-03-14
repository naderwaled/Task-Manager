namespace Task_Manager
{
    partial class LoginForm
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.TaskManagerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.AsAdmin = new System.Windows.Forms.Button();
            this.AsManager = new System.Windows.Forms.Button();
            this.AsEmp = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.TaskManagerLogo = new System.Windows.Forms.PictureBox();
            this.passwordPic = new System.Windows.Forms.PictureBox();
            this.usernamePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskManagerLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePic)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginBtn.Location = new System.Drawing.Point(188, 475);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(375, 77);
            this.loginBtn.TabIndex = 22;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Visible = false;
            this.loginBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loginBtn_MouseClick);
            // 
            // TaskManagerLabel
            // 
            this.TaskManagerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TaskManagerLabel.AutoSize = true;
            this.TaskManagerLabel.Font = new System.Drawing.Font("Felix Titling", 14F, System.Drawing.FontStyle.Bold);
            this.TaskManagerLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.TaskManagerLabel.Location = new System.Drawing.Point(236, 205);
            this.TaskManagerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskManagerLabel.Name = "TaskManagerLabel";
            this.TaskManagerLabel.Size = new System.Drawing.Size(250, 33);
            this.TaskManagerLabel.TabIndex = 19;
            this.TaskManagerLabel.Text = "Task Manager";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(188, 355);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 2);
            this.panel1.TabIndex = 17;
            this.panel1.Visible = false;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.passwordTextbox.ForeColor = System.Drawing.Color.White;
            this.passwordTextbox.HideSelection = false;
            this.passwordTextbox.Location = new System.Drawing.Point(242, 385);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(320, 27);
            this.passwordTextbox.TabIndex = 14;
            this.passwordTextbox.TabStop = false;
            this.passwordTextbox.Text = "Password";
            this.passwordTextbox.Visible = false;
            this.passwordTextbox.Click += new System.EventHandler(this.passwordTextbox_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.usernameTextbox.ForeColor = System.Drawing.Color.White;
            this.usernameTextbox.HideSelection = false;
            this.usernameTextbox.Location = new System.Drawing.Point(242, 318);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(320, 27);
            this.usernameTextbox.TabIndex = 13;
            this.usernameTextbox.TabStop = false;
            this.usernameTextbox.Text = "Username";
            this.usernameTextbox.Visible = false;
            this.usernameTextbox.Click += new System.EventHandler(this.usernameTextbox_Click);
            // 
            // AsAdmin
            // 
            this.AsAdmin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AsAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AsAdmin.FlatAppearance.BorderSize = 0;
            this.AsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AsAdmin.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AsAdmin.Location = new System.Drawing.Point(188, 285);
            this.AsAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AsAdmin.Name = "AsAdmin";
            this.AsAdmin.Size = new System.Drawing.Size(375, 77);
            this.AsAdmin.TabIndex = 24;
            this.AsAdmin.Text = "Admin";
            this.AsAdmin.UseVisualStyleBackColor = false;
            this.AsAdmin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AsAdmin_MouseClick);
            // 
            // AsManager
            // 
            this.AsManager.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AsManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AsManager.FlatAppearance.BorderSize = 0;
            this.AsManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AsManager.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AsManager.Location = new System.Drawing.Point(188, 385);
            this.AsManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AsManager.Name = "AsManager";
            this.AsManager.Size = new System.Drawing.Size(375, 77);
            this.AsManager.TabIndex = 25;
            this.AsManager.Text = "Manager";
            this.AsManager.UseVisualStyleBackColor = false;
            this.AsManager.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AsManager_MouseClick);
            // 
            // AsEmp
            // 
            this.AsEmp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AsEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AsEmp.FlatAppearance.BorderSize = 0;
            this.AsEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AsEmp.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AsEmp.Location = new System.Drawing.Point(188, 485);
            this.AsEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AsEmp.Name = "AsEmp";
            this.AsEmp.Size = new System.Drawing.Size(375, 77);
            this.AsEmp.TabIndex = 26;
            this.AsEmp.Text = "Employee";
            this.AsEmp.UseVisualStyleBackColor = false;
            this.AsEmp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AsEmp_MouseClick);
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Image = global::Task_Manager.Properties.Resources.Previous_24__2_;
            this.BackBtn.Location = new System.Drawing.Point(24, 29);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(24, 24);
            this.BackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BackBtn.TabIndex = 27;
            this.BackBtn.TabStop = false;
            this.BackBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BackBtn_MouseClick);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = global::Task_Manager.Properties.Resources.Cancel_128;
            this.CloseBtn.Location = new System.Drawing.Point(669, 18);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(60, 62);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBtn.TabIndex = 23;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseBtn_MouseClick);
            // 
            // TaskManagerLogo
            // 
            this.TaskManagerLogo.Image = global::Task_Manager.Properties.Resources.taskSky;
            this.TaskManagerLogo.Location = new System.Drawing.Point(296, 65);
            this.TaskManagerLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TaskManagerLogo.Name = "TaskManagerLogo";
            this.TaskManagerLogo.Size = new System.Drawing.Size(128, 138);
            this.TaskManagerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TaskManagerLogo.TabIndex = 18;
            this.TaskManagerLogo.TabStop = false;
            // 
            // passwordPic
            // 
            this.passwordPic.Image = global::Task_Manager.Properties.Resources.passWhite;
            this.passwordPic.Location = new System.Drawing.Point(188, 366);
            this.passwordPic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordPic.Name = "passwordPic";
            this.passwordPic.Size = new System.Drawing.Size(45, 46);
            this.passwordPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordPic.TabIndex = 16;
            this.passwordPic.TabStop = false;
            this.passwordPic.Visible = false;
            // 
            // usernamePic
            // 
            this.usernamePic.Image = global::Task_Manager.Properties.Resources.userWhite;
            this.usernamePic.Location = new System.Drawing.Point(188, 300);
            this.usernamePic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernamePic.Name = "usernamePic";
            this.usernamePic.Size = new System.Drawing.Size(45, 46);
            this.usernamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usernamePic.TabIndex = 15;
            this.usernamePic.TabStop = false;
            this.usernamePic.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(750, 615);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AsEmp);
            this.Controls.Add(this.AsManager);
            this.Controls.Add(this.AsAdmin);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.TaskManagerLabel);
            this.Controls.Add(this.TaskManagerLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passwordPic);
            this.Controls.Add(this.usernamePic);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskManagerLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label TaskManagerLabel;
        private System.Windows.Forms.PictureBox TaskManagerLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox passwordPic;
        private System.Windows.Forms.PictureBox usernamePic;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.Button AsAdmin;
        private System.Windows.Forms.Button AsManager;
        private System.Windows.Forms.Button AsEmp;
        private System.Windows.Forms.PictureBox BackBtn;
    }
}

