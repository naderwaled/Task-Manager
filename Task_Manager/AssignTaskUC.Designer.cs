namespace Task_Manager
{
    partial class AssignTaskUC
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
            this.TaskNameTextbox = new System.Windows.Forms.TextBox();
            this.empName = new System.Windows.Forms.Label();
            this.empNameBox = new System.Windows.Forms.ComboBox();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.eLabel = new System.Windows.Forms.Label();
            this.sLabel = new System.Windows.Forms.Label();
            this.ProjDescription = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.FinishTaskBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskName
            // 
            this.TaskName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TaskName.AutoSize = true;
            this.TaskName.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskName.ForeColor = System.Drawing.Color.White;
            this.TaskName.Location = new System.Drawing.Point(5, 33);
            this.TaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(186, 35);
            this.TaskName.TabIndex = 12;
            this.TaskName.Text = "Task Name";
            // 
            // TaskNameTextbox
            // 
            this.TaskNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TaskNameTextbox.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameTextbox.Location = new System.Drawing.Point(318, 38);
            this.TaskNameTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TaskNameTextbox.Name = "TaskNameTextbox";
            this.TaskNameTextbox.Size = new System.Drawing.Size(270, 30);
            this.TaskNameTextbox.TabIndex = 13;
            // 
            // empName
            // 
            this.empName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.empName.AutoSize = true;
            this.empName.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName.ForeColor = System.Drawing.Color.White;
            this.empName.Location = new System.Drawing.Point(5, 113);
            this.empName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(262, 35);
            this.empName.TabIndex = 14;
            this.empName.Text = "Employee Name";
            // 
            // empNameBox
            // 
            this.empNameBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.empNameBox.FormattingEnabled = true;
            this.empNameBox.Location = new System.Drawing.Point(318, 118);
            this.empNameBox.Name = "empNameBox";
            this.empNameBox.Size = new System.Drawing.Size(270, 28);
            this.empNameBox.TabIndex = 15;
            // 
            // EndTime
            // 
            this.EndTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EndTime.Location = new System.Drawing.Point(318, 278);
            this.EndTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(270, 26);
            this.EndTime.TabIndex = 24;
            // 
            // startTime
            // 
            this.startTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startTime.Location = new System.Drawing.Point(318, 198);
            this.startTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(270, 26);
            this.startTime.TabIndex = 23;
            // 
            // eLabel
            // 
            this.eLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.eLabel.AutoSize = true;
            this.eLabel.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eLabel.ForeColor = System.Drawing.Color.White;
            this.eLabel.Location = new System.Drawing.Point(5, 273);
            this.eLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(167, 35);
            this.eLabel.TabIndex = 22;
            this.eLabel.Text = "End Date";
            // 
            // sLabel
            // 
            this.sLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sLabel.AutoSize = true;
            this.sLabel.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLabel.ForeColor = System.Drawing.Color.White;
            this.sLabel.Location = new System.Drawing.Point(5, 193);
            this.sLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(205, 35);
            this.sLabel.TabIndex = 21;
            this.sLabel.Text = "Start Date";
            // 
            // ProjDescription
            // 
            this.ProjDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProjDescription.Location = new System.Drawing.Point(318, 358);
            this.ProjDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjDescription.Name = "ProjDescription";
            this.ProjDescription.Size = new System.Drawing.Size(270, 170);
            this.ProjDescription.TabIndex = 26;
            this.ProjDescription.Text = "";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(5, 353);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(224, 35);
            this.descriptionLabel.TabIndex = 25;
            this.descriptionLabel.Text = "Description";
            // 
            // FinishTaskBtn
            // 
            this.FinishTaskBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FinishTaskBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.FinishTaskBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FinishTaskBtn.FlatAppearance.BorderSize = 0;
            this.FinishTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishTaskBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishTaskBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FinishTaskBtn.Location = new System.Drawing.Point(145, 611);
            this.FinishTaskBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FinishTaskBtn.Name = "FinishTaskBtn";
            this.FinishTaskBtn.Size = new System.Drawing.Size(375, 77);
            this.FinishTaskBtn.TabIndex = 27;
            this.FinishTaskBtn.Text = "Finish";
            this.FinishTaskBtn.UseVisualStyleBackColor = false;
            // 
            // AssignTaskUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.FinishTaskBtn);
            this.Controls.Add(this.ProjDescription);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.sLabel);
            this.Controls.Add(this.empNameBox);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.TaskNameTextbox);
            this.Controls.Add(this.TaskName);
            this.Name = "AssignTaskUC";
            this.Size = new System.Drawing.Size(679, 707);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskName;
        private System.Windows.Forms.TextBox TaskNameTextbox;
        private System.Windows.Forms.Label empName;
        private System.Windows.Forms.ComboBox empNameBox;
        private System.Windows.Forms.DateTimePicker EndTime;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.Label eLabel;
        private System.Windows.Forms.Label sLabel;
        private System.Windows.Forms.RichTextBox ProjDescription;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button FinishTaskBtn;
    }
}
