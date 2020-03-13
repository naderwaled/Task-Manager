namespace Task_Manager
{
    partial class ViewTaskOfSpecificProject
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
            this.viewTasksFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.close = new System.Windows.Forms.PictureBox();
            this.viewTasksFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // viewTasksFlowLayoutPanel
            // 
            this.viewTasksFlowLayoutPanel.AutoScroll = true;
            this.viewTasksFlowLayoutPanel.Controls.Add(this.close);
            this.viewTasksFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewTasksFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.viewTasksFlowLayoutPanel.Name = "viewTasksFlowLayoutPanel";
            this.viewTasksFlowLayoutPanel.Size = new System.Drawing.Size(1069, 473);
            this.viewTasksFlowLayoutPanel.TabIndex = 0;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.White;
            this.close.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.close.Location = new System.Drawing.Point(3, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            // 
            // ViewTaskOfSpecificProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.viewTasksFlowLayoutPanel);
            this.Name = "ViewTaskOfSpecificProject";
            this.Size = new System.Drawing.Size(1069, 473);
            this.Load += new System.EventHandler(this.ViewTaskOfSpecificProject_Load);
            this.viewTasksFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel viewTasksFlowLayoutPanel;
        private System.Windows.Forms.PictureBox close;
    }
}
