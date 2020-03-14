namespace Task_Manager
{
    partial class ViewProjUC
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
            this.startDuration = new System.Windows.Forms.Label();
            this.TaskEmpLabel = new System.Windows.Forms.Label();
            this.MoreLabelBtn = new System.Windows.Forms.Label();
            this.LightTask = new System.Windows.Forms.Panel();
            this.ProjectName = new System.Windows.Forms.Label();
            this.endDuration = new System.Windows.Forms.Label();
            this.InfoLabelBtn = new System.Windows.Forms.Label();
            this.EditLabelBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startDuration
            // 
            this.startDuration.AutoSize = true;
            this.startDuration.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDuration.ForeColor = System.Drawing.Color.White;
            this.startDuration.Location = new System.Drawing.Point(11, 40);
            this.startDuration.Name = "startDuration";
            this.startDuration.Size = new System.Drawing.Size(144, 20);
            this.startDuration.TabIndex = 5;
            this.startDuration.Text = "Started On 1/1/2018";
            // 
            // TaskEmpLabel
            // 
            this.TaskEmpLabel.AutoSize = true;
            this.TaskEmpLabel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskEmpLabel.ForeColor = System.Drawing.Color.White;
            this.TaskEmpLabel.Location = new System.Drawing.Point(11, 20);
            this.TaskEmpLabel.Name = "TaskEmpLabel";
            this.TaskEmpLabel.Size = new System.Drawing.Size(81, 20);
            this.TaskEmpLabel.TabIndex = 8;
            this.TaskEmpLabel.Text = "Karim Atef";
            // 
            // MoreLabelBtn
            // 
            this.MoreLabelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MoreLabelBtn.AutoSize = true;
            this.MoreLabelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoreLabelBtn.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoreLabelBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.MoreLabelBtn.Location = new System.Drawing.Point(281, 61);
            this.MoreLabelBtn.Name = "MoreLabelBtn";
            this.MoreLabelBtn.Size = new System.Drawing.Size(50, 19);
            this.MoreLabelBtn.TabIndex = 13;
            this.MoreLabelBtn.Text = "More";
            this.MoreLabelBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MoreLabelBtn_MouseClick);
            // 
            // LightTask
            // 
            this.LightTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LightTask.Dock = System.Windows.Forms.DockStyle.Left;
            this.LightTask.Location = new System.Drawing.Point(0, 0);
            this.LightTask.Name = "LightTask";
            this.LightTask.Size = new System.Drawing.Size(10, 87);
            this.LightTask.TabIndex = 3;
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSize = true;
            this.ProjectName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectName.ForeColor = System.Drawing.Color.White;
            this.ProjectName.Location = new System.Drawing.Point(11, 0);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(110, 22);
            this.ProjectName.TabIndex = 14;
            this.ProjectName.Text = "Project Name";
            // 
            // endDuration
            // 
            this.endDuration.AutoSize = true;
            this.endDuration.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDuration.ForeColor = System.Drawing.Color.White;
            this.endDuration.Location = new System.Drawing.Point(11, 60);
            this.endDuration.Name = "endDuration";
            this.endDuration.Size = new System.Drawing.Size(160, 20);
            this.endDuration.TabIndex = 15;
            this.endDuration.Text = "Finished On 30/1/2018";
            // 
            // InfoLabelBtn
            // 
            this.InfoLabelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InfoLabelBtn.AutoSize = true;
            this.InfoLabelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoLabelBtn.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabelBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.InfoLabelBtn.Location = new System.Drawing.Point(281, 7);
            this.InfoLabelBtn.Name = "InfoLabelBtn";
            this.InfoLabelBtn.Size = new System.Drawing.Size(42, 19);
            this.InfoLabelBtn.TabIndex = 16;
            this.InfoLabelBtn.Text = "Info";
            this.InfoLabelBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InfoLabelBtn_MouseClick);
            // 
            // EditLabelBtn
            // 
            this.EditLabelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditLabelBtn.AutoSize = true;
            this.EditLabelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditLabelBtn.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditLabelBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.EditLabelBtn.Location = new System.Drawing.Point(281, 34);
            this.EditLabelBtn.Name = "EditLabelBtn";
            this.EditLabelBtn.Size = new System.Drawing.Size(41, 19);
            this.EditLabelBtn.TabIndex = 17;
            this.EditLabelBtn.Text = "Edit";
            this.EditLabelBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditLabelBtn_MouseClick);
            // 
            // ViewProjUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.EditLabelBtn);
            this.Controls.Add(this.InfoLabelBtn);
            this.Controls.Add(this.endDuration);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.MoreLabelBtn);
            this.Controls.Add(this.TaskEmpLabel);
            this.Controls.Add(this.startDuration);
            this.Controls.Add(this.LightTask);
            this.Name = "ViewProjUC";
            this.Size = new System.Drawing.Size(332, 87);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel LightTask;
        public System.Windows.Forms.Label startDuration;
        public System.Windows.Forms.Label TaskEmpLabel;
        public System.Windows.Forms.Label ProjectName;
        public System.Windows.Forms.Label endDuration;
        public System.Windows.Forms.Label MoreLabelBtn;
        public System.Windows.Forms.Label InfoLabelBtn;
        public System.Windows.Forms.Label EditLabelBtn;
    }
}
