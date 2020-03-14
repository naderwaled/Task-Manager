namespace Task_Manager
{
    partial class CommentOrAssignUC
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
            this.commentTextBox = new System.Windows.Forms.RichTextBox();
            this.AddConfirmBtn = new System.Windows.Forms.Button();
            this.chooseEmp = new System.Windows.Forms.ComboBox();
            this.empName = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.Send_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commentTextBox
            // 
            this.commentTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.commentTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentTextBox.Location = new System.Drawing.Point(0, 0);
            this.commentTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(618, 232);
            this.commentTextBox.TabIndex = 0;
            this.commentTextBox.Text = "";
            // 
            // AddConfirmBtn
            // 
            this.AddConfirmBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddConfirmBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddConfirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddConfirmBtn.FlatAppearance.BorderSize = 0;
            this.AddConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddConfirmBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddConfirmBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddConfirmBtn.Location = new System.Drawing.Point(381, 240);
            this.AddConfirmBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddConfirmBtn.Name = "AddConfirmBtn";
            this.AddConfirmBtn.Size = new System.Drawing.Size(232, 58);
            this.AddConfirmBtn.TabIndex = 28;
            this.AddConfirmBtn.Text = "Add";
            this.AddConfirmBtn.UseVisualStyleBackColor = false;
            this.AddConfirmBtn.Visible = false;
            this.AddConfirmBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddConfirmBtn_MouseClick);
            // 
            // chooseEmp
            // 
            this.chooseEmp.FormattingEnabled = true;
            this.chooseEmp.Location = new System.Drawing.Point(314, 74);
            this.chooseEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chooseEmp.Name = "chooseEmp";
            this.chooseEmp.Size = new System.Drawing.Size(223, 28);
            this.chooseEmp.TabIndex = 29;
            this.chooseEmp.Visible = false;
            // 
            // empName
            // 
            this.empName.AutoSize = true;
            this.empName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName.ForeColor = System.Drawing.Color.Black;
            this.empName.Location = new System.Drawing.Point(72, 72);
            this.empName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(205, 32);
            this.empName.TabIndex = 30;
            this.empName.Text = "Employee Name :";
            this.empName.Visible = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeBtn.Location = new System.Drawing.Point(4, 240);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(232, 58);
            this.closeBtn.TabIndex = 31;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeBtn_MouseClick);
            // 
            // Send_btn
            // 
            this.Send_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Send_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Send_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Send_btn.FlatAppearance.BorderSize = 0;
            this.Send_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send_btn.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Send_btn.Location = new System.Drawing.Point(381, 240);
            this.Send_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Send_btn.Name = "Send_btn";
            this.Send_btn.Size = new System.Drawing.Size(232, 58);
            this.Send_btn.TabIndex = 28;
            this.Send_btn.Text = "Send";
            this.Send_btn.UseVisualStyleBackColor = false;
            this.Send_btn.Visible = false;
            this.Send_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Send_btn_MouseClick);
            // 
            // CommentOrAssignUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.chooseEmp);
            this.Controls.Add(this.Send_btn);
            this.Controls.Add(this.AddConfirmBtn);
            this.Controls.Add(this.commentTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CommentOrAssignUC";
            this.Size = new System.Drawing.Size(618, 303);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label empName;
        public System.Windows.Forms.ComboBox chooseEmp;
        public System.Windows.Forms.RichTextBox commentTextBox;
        public System.Windows.Forms.Button AddConfirmBtn;
        public System.Windows.Forms.Button closeBtn;
        public System.Windows.Forms.Button Send_btn;
    }
}
