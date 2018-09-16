namespace CourseRegistration
{
    partial class frmJoinGroup
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
            this.cbGroupCode = new System.Windows.Forms.ComboBox();
            this.btnJoinGroup = new System.Windows.Forms.Button();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMajorsCode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbGroupCode
            // 
            this.cbGroupCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGroupCode.FormattingEnabled = true;
            this.cbGroupCode.Location = new System.Drawing.Point(176, 63);
            this.cbGroupCode.Name = "cbGroupCode";
            this.cbGroupCode.Size = new System.Drawing.Size(218, 24);
            this.cbGroupCode.TabIndex = 60;
            // 
            // btnJoinGroup
            // 
            this.btnJoinGroup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinGroup.Location = new System.Drawing.Point(145, 205);
            this.btnJoinGroup.Name = "btnJoinGroup";
            this.btnJoinGroup.Size = new System.Drawing.Size(118, 31);
            this.btnJoinGroup.TabIndex = 57;
            this.btnJoinGroup.Text = "Gia nhập";
            this.btnJoinGroup.UseVisualStyleBackColor = true;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.Location = new System.Drawing.Point(176, 108);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(216, 23);
            this.txtGroupName.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Nhập tên nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 54;
            this.label2.Text = "Gia nhập nhóm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Chọn mã nhóm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "Chọn ngành";
            // 
            // cbMajorsCode
            // 
            this.cbMajorsCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMajorsCode.FormattingEnabled = true;
            this.cbMajorsCode.Location = new System.Drawing.Point(174, 151);
            this.cbMajorsCode.Name = "cbMajorsCode";
            this.cbMajorsCode.Size = new System.Drawing.Size(218, 24);
            this.cbMajorsCode.TabIndex = 59;
            // 
            // frmJoinGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 261);
            this.Controls.Add(this.cbGroupCode);
            this.Controls.Add(this.cbMajorsCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnJoinGroup);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmJoinGroup";
            this.Text = "Gia nhập nhóm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGroupCode;
        private System.Windows.Forms.Button btnJoinGroup;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMajorsCode;
    }
}