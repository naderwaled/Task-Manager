namespace Task_Manager
{
    partial class AcceptRejectAssignedTask
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
            this.TaskName = new System.Windows.Forms.Label();
            this.endDuration = new System.Windows.Forms.Label();
            this.ProjectName = new System.Windows.Forms.Label();
            this.startDuration = new System.Windows.Forms.Label();
            this.LightTask = new System.Windows.Forms.Panel();
            this.assignedDetails = new System.Windows.Forms.Label();
            this.rejectBtn = new System.Windows.Forms.Button();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.descriptionTask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskName
            // 
            this.TaskName.AutoSize = true;
            this.TaskName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskName.ForeColor = System.Drawing.Color.White;
            this.TaskName.Location = new System.Drawing.Point(22, 38);
            this.TaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(138, 32);
            this.TaskName.TabIndex = 31;
            this.TaskName.Text = "Task Name";
            // 
            // endDuration
            // 
            this.endDuration.AutoSize = true;
            this.endDuration.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDuration.ForeColor = System.Drawing.Color.White;
            this.endDuration.Location = new System.Drawing.Point(22, 115);
            this.endDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDuration.Name = "endDuration";
            this.endDuration.Size = new System.Drawing.Size(244, 31);
            this.endDuration.TabIndex = 30;
            this.endDuration.Text = "Finished On 30/1/2018";
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSize = true;
            this.ProjectName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectName.ForeColor = System.Drawing.Color.White;
            this.ProjectName.Location = new System.Drawing.Point(22, 0);
            this.ProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(161, 32);
            this.ProjectName.TabIndex = 29;
            this.ProjectName.Text = "Project Name";
            // 
            // startDuration
            // 
            this.startDuration.AutoSize = true;
            this.startDuration.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDuration.ForeColor = System.Drawing.Color.White;
            this.startDuration.Location = new System.Drawing.Point(22, 77);
            this.startDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDuration.Name = "startDuration";
            this.startDuration.Size = new System.Drawing.Size(219, 31);
            this.startDuration.TabIndex = 27;
            this.startDuration.Text = "Started On 1/1/2018";
            // 
            // LightTask
            // 
            this.LightTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LightTask.Dock = System.Windows.Forms.DockStyle.Left;
            this.LightTask.Location = new System.Drawing.Point(0, 0);
            this.LightTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LightTask.Name = "LightTask";
            this.LightTask.Size = new System.Drawing.Size(15, 289);
            this.LightTask.TabIndex = 26;
            // 
            // assignedDetails
            // 
            this.assignedDetails.AutoSize = true;
            this.assignedDetails.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedDetails.ForeColor = System.Drawing.Color.White;
            this.assignedDetails.Location = new System.Drawing.Point(130, 169);
            this.assignedDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.assignedDetails.Name = "assignedDetails";
            this.assignedDetails.Size = new System.Drawing.Size(501, 31);
            this.assignedDetails.TabIndex = 32;
            this.assignedDetails.Text = "This Task Is Assgined To You By Nader Waled";
            // 
            // rejectBtn
            // 
            this.rejectBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rejectBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.rejectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rejectBtn.FlatAppearance.BorderSize = 0;
            this.rejectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rejectBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rejectBtn.Location = new System.Drawing.Point(162, 223);
            this.rejectBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rejectBtn.Name = "rejectBtn";
            this.rejectBtn.Size = new System.Drawing.Size(165, 62);
            this.rejectBtn.TabIndex = 34;
            this.rejectBtn.Text = "Reject";
            this.rejectBtn.UseVisualStyleBackColor = false;
            this.rejectBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rejectBtn_MouseClick);
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AcceptBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AcceptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptBtn.FlatAppearance.BorderSize = 0;
            this.AcceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AcceptBtn.Location = new System.Drawing.Point(432, 223);
            this.AcceptBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(165, 62);
            this.AcceptBtn.TabIndex = 33;
            this.AcceptBtn.Text = "Accept";
            this.AcceptBtn.UseVisualStyleBackColor = false;
            this.AcceptBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AcceptBtn_MouseClick);
            // 
            // descriptionTask
            // 
            this.descriptionTask.AutoSize = true;
            this.descriptionTask.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTask.ForeColor = System.Drawing.Color.White;
            this.descriptionTask.Location = new System.Drawing.Point(338, 0);
            this.descriptionTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionTask.Name = "descriptionTask";
            this.descriptionTask.Size = new System.Drawing.Size(134, 31);
            this.descriptionTask.TabIndex = 35;
            this.descriptionTask.Text = "Description";
            // 
            // AcceptRejectAssignedTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.descriptionTask);
            this.Controls.Add(this.rejectBtn);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.assignedDetails);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.endDuration);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.startDuration);
            this.Controls.Add(this.LightTask);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AcceptRejectAssignedTask";
            this.Size = new System.Drawing.Size(748, 289);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label TaskName;
        public System.Windows.Forms.Label endDuration;
        public System.Windows.Forms.Label ProjectName;
        public System.Windows.Forms.Label startDuration;
        private System.Windows.Forms.Panel LightTask;
        public System.Windows.Forms.Label assignedDetails;
        public System.Windows.Forms.Button rejectBtn;
        public System.Windows.Forms.Button AcceptBtn;
        public System.Windows.Forms.Label descriptionTask;
    }
}
