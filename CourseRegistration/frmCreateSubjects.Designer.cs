﻿namespace CourseRegistration
{
    partial class frmCreateSubjects
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
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.txtSubjectsLimit = new System.Windows.Forms.TextBox();
            this.btnCreateSubjects = new System.Windows.Forms.Button();
            this.txtSubjectsName = new System.Windows.Forms.TextBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubjectsCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMajorsCode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupCheckEnable = new System.Windows.Forms.GroupBox();
            this.rdClose = new System.Windows.Forms.RadioButton();
            this.rdOpen = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.groupCheckEnable.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(351, 199);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(37, 23);
            this.btnDown.TabIndex = 21;
            this.btnDown.Text = "▼ ";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(308, 200);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(37, 22);
            this.btnUp.TabIndex = 20;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // txtSubjectsLimit
            // 
            this.txtSubjectsLimit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectsLimit.Location = new System.Drawing.Point(246, 200);
            this.txtSubjectsLimit.Name = "txtSubjectsLimit";
            this.txtSubjectsLimit.Size = new System.Drawing.Size(56, 23);
            this.txtSubjectsLimit.TabIndex = 19;
            // 
            // btnCreateSubjects
            // 
            this.btnCreateSubjects.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSubjects.Location = new System.Drawing.Point(308, 286);
            this.btnCreateSubjects.Name = "btnCreateSubjects";
            this.btnCreateSubjects.Size = new System.Drawing.Size(118, 31);
            this.btnCreateSubjects.TabIndex = 18;
            this.btnCreateSubjects.Text = "Tạo mới";
            this.btnCreateSubjects.UseVisualStyleBackColor = true;
            // 
            // txtSubjectsName
            // 
            this.txtSubjectsName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectsName.Location = new System.Drawing.Point(562, 64);
            this.txtSubjectsName.Name = "txtSubjectsName";
            this.txtSubjectsName.Size = new System.Drawing.Size(216, 23);
            this.txtSubjectsName.TabIndex = 17;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(80, 245);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 16);
            this.lbMessage.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Giới hạn số lượng sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nhập tên môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tạo mới môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập mã môn học";
            // 
            // txtSubjectsCode
            // 
            this.txtSubjectsCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectsCode.Location = new System.Drawing.Point(174, 64);
            this.txtSubjectsCode.Name = "txtSubjectsCode";
            this.txtSubjectsCode.Size = new System.Drawing.Size(211, 23);
            this.txtSubjectsCode.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Chọn ngành";
            // 
            // cbMajorsCode
            // 
            this.cbMajorsCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMajorsCode.FormattingEnabled = true;
            this.cbMajorsCode.Location = new System.Drawing.Point(172, 106);
            this.cbMajorsCode.Name = "cbMajorsCode";
            this.cbMajorsCode.Size = new System.Drawing.Size(213, 24);
            this.cbMajorsCode.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tình trạng";
            // 
            // groupCheckEnable
            // 
            this.groupCheckEnable.Controls.Add(this.rdClose);
            this.groupCheckEnable.Controls.Add(this.rdOpen);
            this.groupCheckEnable.Location = new System.Drawing.Point(562, 103);
            this.groupCheckEnable.Name = "groupCheckEnable";
            this.groupCheckEnable.Size = new System.Drawing.Size(171, 34);
            this.groupCheckEnable.TabIndex = 25;
            this.groupCheckEnable.TabStop = false;
            // 
            // rdClose
            // 
            this.rdClose.AutoSize = true;
            this.rdClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdClose.Location = new System.Drawing.Point(111, 10);
            this.rdClose.Name = "rdClose";
            this.rdClose.Size = new System.Drawing.Size(60, 20);
            this.rdClose.TabIndex = 1;
            this.rdClose.Text = "Đóng";
            this.rdClose.UseVisualStyleBackColor = true;
            // 
            // rdOpen
            // 
            this.rdOpen.AutoSize = true;
            this.rdOpen.Checked = true;
            this.rdOpen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOpen.Location = new System.Drawing.Point(0, 10);
            this.rdOpen.Name = "rdOpen";
            this.rdOpen.Size = new System.Drawing.Size(45, 20);
            this.rdOpen.TabIndex = 0;
            this.rdOpen.TabStop = true;
            this.rdOpen.Text = "Mở";
            this.rdOpen.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Ngày bắt đầu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(415, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Ngày kết thúc";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(172, 153);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(216, 23);
            this.dtpStartDate.TabIndex = 28;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(562, 153);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(216, 23);
            this.dtpEndDate.TabIndex = 29;
            // 
            // frmCreateSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 420);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupCheckEnable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMajorsCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtSubjectsLimit);
            this.Controls.Add(this.btnCreateSubjects);
            this.Controls.Add(this.txtSubjectsName);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubjectsCode);
            this.Name = "frmCreateSubjects";
            this.Text = "Tạo mới môn học";
            this.groupCheckEnable.ResumeLayout(false);
            this.groupCheckEnable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TextBox txtSubjectsLimit;
        private System.Windows.Forms.Button btnCreateSubjects;
        private System.Windows.Forms.TextBox txtSubjectsName;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubjectsCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMajorsCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupCheckEnable;
        private System.Windows.Forms.RadioButton rdClose;
        private System.Windows.Forms.RadioButton rdOpen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}