namespace Coja_Adrian
{
    partial class frmAddEditStudent
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
            btnOK = new Button();
            label1 = new Label();
            txtStudentID = new TextBox();
            label2 = new Label();
            txtFullName = new TextBox();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(320, 62);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 0;
            btnOK.Text = "&OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Student  ID:";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(86, 4);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(141, 23);
            txtStudentID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 3;
            label2.Text = "Full name:";
            label2.Click += label2_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(80, 33);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(315, 23);
            txtFullName.TabIndex = 4;
            // 
            // frmAddEditStudent
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 105);
            Controls.Add(txtFullName);
            Controls.Add(label2);
            Controls.Add(txtStudentID);
            Controls.Add(label1);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddEditStudent";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add/Edit";
            Load += frmAddEditStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Label label1;
        private TextBox txtStudentID;
        private Label label2;
        private TextBox txtFullName;
    }
}