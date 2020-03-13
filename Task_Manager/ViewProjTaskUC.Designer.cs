namespace Task_Manager
{
    partial class ViewProjTaskUC
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
            this.SuspendLayout();
            // 
            // startDuration
            // 
            this.startDuration.AutoSize = true;
            this.startDuration.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDuration.ForeColor = System.Drawing.Color.White;
            this.startDuration.Location = new System.Drawing.Point(16, 62);
            this.startDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDuration.Name = "startDuration";
            this.startDuration.Size = new System.Drawing.Size(219, 31);
            this.startDuration.TabIndex = 5;
            this.startDuration.Text = "Started On 1/1/2018";
            // 
            // TaskEmpLabel
            // 
            this.TaskEmpLabel.AutoSize = true;
            this.TaskEmpLabel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskEmpLabel.ForeColor = System.Drawing.Color.White;
            this.TaskEmpLabel.Location = new System.Drawing.Point(16, 31);
            this.TaskEmpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskEmpLabel.Name = "TaskEmpLabel";
            this.TaskEmpLabel.Size = new System.Drawing.Size(125, 31);
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
            this.MoreLabelBtn.Location = new System.Drawing.Point(422, 94);
            this.MoreLabelBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MoreLabelBtn.Name = "MoreLabelBtn";
            this.MoreLabelBtn.Size = new System.Drawing.Size(73, 29);
            this.MoreLabelBtn.TabIndex = 13;
            this.MoreLabelBtn.Text = "More";
            // 
            // LightTask
            // 
            this.LightTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LightTask.Dock = System.Windows.Forms.DockStyle.Left;
            this.LightTask.Location = new System.Drawing.Point(0, 0);
            this.LightTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LightTask.Name = "LightTask";
            this.LightTask.Size = new System.Drawing.Size(15, 134);
            this.LightTask.TabIndex = 3;
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSize = true;
            this.ProjectName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectName.ForeColor = System.Drawing.Color.White;
            this.ProjectName.Location = new System.Drawing.Point(16, 0);
            this.ProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(161, 32);
            this.ProjectName.TabIndex = 14;
            this.ProjectName.Text = "Project Name";
            // 
            // endDuration
            // 
            this.endDuration.AutoSize = true;
            this.endDuration.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDuration.ForeColor = System.Drawing.Color.White;
            this.endDuration.Location = new System.Drawing.Point(16, 92);
            this.endDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDuration.Name = "endDuration";
            this.endDuration.Size = new System.Drawing.Size(244, 31);
            this.endDuration.TabIndex = 15;
            this.endDuration.Text = "Finished On 30/1/2018";
            // 
            // ViewProjTaskUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.endDuration);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.MoreLabelBtn);
            this.Controls.Add(this.TaskEmpLabel);
            this.Controls.Add(this.startDuration);
            this.Controls.Add(this.LightTask);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewProjTaskUC";
            this.Size = new System.Drawing.Size(501, 134);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MoreLabelBtn;
        private System.Windows.Forms.Panel LightTask;
        public System.Windows.Forms.Label startDuration;
        public System.Windows.Forms.Label TaskEmpLabel;
        public System.Windows.Forms.Label ProjectName;
        public System.Windows.Forms.Label endDuration;
    }
}
