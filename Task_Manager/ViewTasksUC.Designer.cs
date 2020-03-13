namespace Task_Manager
{
    partial class ViewTasksUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LightTask = new System.Windows.Forms.Panel();
            this.endDuration = new System.Windows.Forms.Label();
            this.ProjectName = new System.Windows.Forms.Label();
            this.TaskEmpLabel = new System.Windows.Forms.Label();
            this.startDuration = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.Label();
            this.InfoLabelBtn = new System.Windows.Forms.Label();
            this.AssignLabelBtn = new System.Windows.Forms.Label();
            this.CommentLabelBtn = new System.Windows.Forms.Label();
            this.TaskFinishedBtn = new System.Windows.Forms.Label();
            this.taskStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LightTask
            // 
            this.LightTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LightTask.Dock = System.Windows.Forms.DockStyle.Left;
            this.LightTask.Location = new System.Drawing.Point(0, 0);
            this.LightTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LightTask.Name = "LightTask";
            this.LightTask.Size = new System.Drawing.Size(15, 183);
            this.LightTask.TabIndex = 4;
            // 
            // endDuration
            // 
            this.endDuration.AutoSize = true;
            this.endDuration.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDuration.ForeColor = System.Drawing.Color.White;
            this.endDuration.Location = new System.Drawing.Point(21, 145);
            this.endDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDuration.Name = "endDuration";
            this.endDuration.Size = new System.Drawing.Size(244, 31);
            this.endDuration.TabIndex = 22;
            this.endDuration.Text = "Finished On 30/1/2018";
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSize = true;
            this.ProjectName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectName.ForeColor = System.Drawing.Color.White;
            this.ProjectName.Location = new System.Drawing.Point(21, 5);
            this.ProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(161, 32);
            this.ProjectName.TabIndex = 21;
            this.ProjectName.Text = "Project Name";
            // 
            // TaskEmpLabel
            // 
            this.TaskEmpLabel.AutoSize = true;
            this.TaskEmpLabel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskEmpLabel.ForeColor = System.Drawing.Color.White;
            this.TaskEmpLabel.Location = new System.Drawing.Point(21, 75);
            this.TaskEmpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskEmpLabel.Name = "TaskEmpLabel";
            this.TaskEmpLabel.Size = new System.Drawing.Size(125, 31);
            this.TaskEmpLabel.TabIndex = 19;
            this.TaskEmpLabel.Text = "Karim Atef";
            // 
            // startDuration
            // 
            this.startDuration.AutoSize = true;
            this.startDuration.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDuration.ForeColor = System.Drawing.Color.White;
            this.startDuration.Location = new System.Drawing.Point(21, 110);
            this.startDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDuration.Name = "startDuration";
            this.startDuration.Size = new System.Drawing.Size(219, 31);
            this.startDuration.TabIndex = 18;
            this.startDuration.Text = "Started On 1/1/2018";
            // 
            // TaskName
            // 
            this.TaskName.AutoSize = true;
            this.TaskName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskName.ForeColor = System.Drawing.Color.White;
            this.TaskName.Location = new System.Drawing.Point(23, 40);
            this.TaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(138, 32);
            this.TaskName.TabIndex = 25;
            this.TaskName.Text = "Task Name";
            // 
            // InfoLabelBtn
            // 
            this.InfoLabelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InfoLabelBtn.AutoSize = true;
            this.InfoLabelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoLabelBtn.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabelBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.InfoLabelBtn.Location = new System.Drawing.Point(480, 5);
            this.InfoLabelBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoLabelBtn.Name = "InfoLabelBtn";
            this.InfoLabelBtn.Size = new System.Drawing.Size(64, 29);
            this.InfoLabelBtn.TabIndex = 23;
            this.InfoLabelBtn.Text = "Info";
            this.InfoLabelBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InfoLabelBtn_MouseClick);
            // 
            // AssignLabelBtn
            // 
            this.AssignLabelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AssignLabelBtn.AutoSize = true;
            this.AssignLabelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AssignLabelBtn.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignLabelBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.AssignLabelBtn.Location = new System.Drawing.Point(480, 40);
            this.AssignLabelBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AssignLabelBtn.Name = "AssignLabelBtn";
            this.AssignLabelBtn.Size = new System.Drawing.Size(90, 29);
            this.AssignLabelBtn.TabIndex = 24;
            this.AssignLabelBtn.Text = "Assign";
            // 
            // CommentLabelBtn
            // 
            this.CommentLabelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CommentLabelBtn.AutoSize = true;
            this.CommentLabelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CommentLabelBtn.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentLabelBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CommentLabelBtn.Location = new System.Drawing.Point(480, 75);
            this.CommentLabelBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CommentLabelBtn.Name = "CommentLabelBtn";
            this.CommentLabelBtn.Size = new System.Drawing.Size(129, 29);
            this.CommentLabelBtn.TabIndex = 20;
            this.CommentLabelBtn.Text = "Comment";
            // 
            // TaskFinishedBtn
            // 
            this.TaskFinishedBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TaskFinishedBtn.AutoSize = true;
            this.TaskFinishedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaskFinishedBtn.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskFinishedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TaskFinishedBtn.Location = new System.Drawing.Point(435, 145);
            this.TaskFinishedBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskFinishedBtn.Name = "TaskFinishedBtn";
            this.TaskFinishedBtn.Size = new System.Drawing.Size(174, 29);
            this.TaskFinishedBtn.TabIndex = 26;
            this.TaskFinishedBtn.Text = "Task Finished";
            // 
            // taskStatus
            // 
            this.taskStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.taskStatus.AutoSize = true;
            this.taskStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.taskStatus.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.taskStatus.Location = new System.Drawing.Point(435, 112);
            this.taskStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taskStatus.Name = "taskStatus";
            this.taskStatus.Size = new System.Drawing.Size(89, 29);
            this.taskStatus.TabIndex = 27;
            this.taskStatus.Text = "Status";
            this.taskStatus.Visible = false;
            // 
            // ViewTasksUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.taskStatus);
            this.Controls.Add(this.TaskFinishedBtn);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.AssignLabelBtn);
            this.Controls.Add(this.InfoLabelBtn);
            this.Controls.Add(this.endDuration);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.CommentLabelBtn);
            this.Controls.Add(this.TaskEmpLabel);
            this.Controls.Add(this.startDuration);
            this.Controls.Add(this.LightTask);
            this.Name = "ViewTasksUC";
            this.Size = new System.Drawing.Size(617, 183);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LightTask;
        public System.Windows.Forms.Label endDuration;
        public System.Windows.Forms.Label ProjectName;
        public System.Windows.Forms.Label TaskEmpLabel;
        public System.Windows.Forms.Label startDuration;
        public System.Windows.Forms.Label TaskName;
        public System.Windows.Forms.Label InfoLabelBtn;
        public System.Windows.Forms.Label AssignLabelBtn;
        public System.Windows.Forms.Label CommentLabelBtn;
        public System.Windows.Forms.Label TaskFinishedBtn;
        public System.Windows.Forms.Label taskStatus;
    }
}
