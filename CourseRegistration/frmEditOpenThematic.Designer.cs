namespace CourseRegistration
{
    partial class frmEditOpenThematic
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
            this.label10 = new System.Windows.Forms.Label();
            this.dpTimeGroup = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdHK2 = new System.Windows.Forms.RadioButton();
            this.rdHK1 = new System.Windows.Forms.RadioButton();
            this.dpTimeRes = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTeacherCode = new System.Windows.Forms.ComboBox();
            this.cbThematicCode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.txtGroupLimit = new System.Windows.Forms.TextBox();
            this.btnEditOpenThematic = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.rdClose = new System.Windows.Forms.RadioButton();
            this.rdOpen = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupCheckEnable = new System.Windows.Forms.GroupBox();
            this.btnDeleteOpenThematic = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupCheckEnable.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 16);
            this.label10.TabIndex = 98;
            this.label10.Text = "Hạn đăng ký chuyên đề";
            // 
            // dpTimeGroup
            // 
            this.dpTimeGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpTimeGroup.Location = new System.Drawing.Point(193, 243);
            this.dpTimeGroup.Name = "dpTimeGroup";
            this.dpTimeGroup.Size = new System.Drawing.Size(216, 23);
            this.dpTimeGroup.TabIndex = 97;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 16);
            this.label9.TabIndex = 96;
            this.label9.Text = "Hạn đăng ký nhóm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 94;
            this.label5.Text = "Học kỳ";
            // 
            // rdHK2
            // 
            this.rdHK2.AutoSize = true;
            this.rdHK2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHK2.Location = new System.Drawing.Point(61, 10);
            this.rdHK2.Name = "rdHK2";
            this.rdHK2.Size = new System.Drawing.Size(34, 20);
            this.rdHK2.TabIndex = 1;
            this.rdHK2.Text = "2";
            this.rdHK2.UseVisualStyleBackColor = true;
            // 
            // rdHK1
            // 
            this.rdHK1.AutoSize = true;
            this.rdHK1.Checked = true;
            this.rdHK1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHK1.Location = new System.Drawing.Point(0, 10);
            this.rdHK1.Name = "rdHK1";
            this.rdHK1.Size = new System.Drawing.Size(34, 20);
            this.rdHK1.TabIndex = 0;
            this.rdHK1.TabStop = true;
            this.rdHK1.Text = "1";
            this.rdHK1.UseVisualStyleBackColor = true;
            // 
            // dpTimeRes
            // 
            this.dpTimeRes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpTimeRes.Location = new System.Drawing.Point(193, 286);
            this.dpTimeRes.Name = "dpTimeRes";
            this.dpTimeRes.Size = new System.Drawing.Size(216, 23);
            this.dpTimeRes.TabIndex = 99;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdHK2);
            this.groupBox1.Controls.Add(this.rdHK1);
            this.groupBox1.Location = new System.Drawing.Point(189, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 34);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(557, 151);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(216, 23);
            this.dtpEndDate.TabIndex = 93;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(167, 151);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(216, 23);
            this.dtpStartDate.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(410, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 91;
            this.label8.Text = "Ngày kết thúc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 90;
            this.label7.Text = "Ngày bắt đầu";
            // 
            // cbTeacherCode
            // 
            this.cbTeacherCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTeacherCode.FormattingEnabled = true;
            this.cbTeacherCode.Location = new System.Drawing.Point(557, 63);
            this.cbTeacherCode.Name = "cbTeacherCode";
            this.cbTeacherCode.Size = new System.Drawing.Size(216, 24);
            this.cbTeacherCode.TabIndex = 89;
            // 
            // cbThematicCode
            // 
            this.cbThematicCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThematicCode.FormattingEnabled = true;
            this.cbThematicCode.Location = new System.Drawing.Point(167, 60);
            this.cbThematicCode.Name = "cbThematicCode";
            this.cbThematicCode.Size = new System.Drawing.Size(216, 24);
            this.cbThematicCode.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 85;
            this.label6.Text = "Tình trạng";
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(346, 200);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(37, 23);
            this.btnDown.TabIndex = 84;
            this.btnDown.Text = "▼ ";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(303, 201);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(37, 22);
            this.btnUp.TabIndex = 83;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // txtGroupLimit
            // 
            this.txtGroupLimit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupLimit.Location = new System.Drawing.Point(241, 201);
            this.txtGroupLimit.Name = "txtGroupLimit";
            this.txtGroupLimit.Size = new System.Drawing.Size(56, 23);
            this.txtGroupLimit.TabIndex = 82;
            // 
            // btnEditOpenThematic
            // 
            this.btnEditOpenThematic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOpenThematic.Location = new System.Drawing.Point(250, 378);
            this.btnEditOpenThematic.Name = "btnEditOpenThematic";
            this.btnEditOpenThematic.Size = new System.Drawing.Size(158, 31);
            this.btnEditOpenThematic.TabIndex = 81;
            this.btnEditOpenThematic.Text = "Chỉnh sửa";
            this.btnEditOpenThematic.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 79;
            this.label4.Text = "Giới hạn số lượng nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 23);
            this.label2.TabIndex = 78;
            this.label2.Text = "Điều chỉnh chuyên đề";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "Chọn mã chuyên đề";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(84, 337);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 16);
            this.lbMessage.TabIndex = 80;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "Chọn mã giáo viên";
            // 
            // groupCheckEnable
            // 
            this.groupCheckEnable.Controls.Add(this.rdClose);
            this.groupCheckEnable.Controls.Add(this.rdOpen);
            this.groupCheckEnable.Location = new System.Drawing.Point(577, 102);
            this.groupCheckEnable.Name = "groupCheckEnable";
            this.groupCheckEnable.Size = new System.Drawing.Size(171, 34);
            this.groupCheckEnable.TabIndex = 86;
            this.groupCheckEnable.TabStop = false;
            // 
            // btnDeleteOpenThematic
            // 
            this.btnDeleteOpenThematic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOpenThematic.Location = new System.Drawing.Point(449, 378);
            this.btnDeleteOpenThematic.Name = "btnDeleteOpenThematic";
            this.btnDeleteOpenThematic.Size = new System.Drawing.Size(158, 31);
            this.btnDeleteOpenThematic.TabIndex = 100;
            this.btnDeleteOpenThematic.Text = "Xóa";
            this.btnDeleteOpenThematic.UseVisualStyleBackColor = true;
            // 
            // frmEditOpenThematic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 430);
            this.Controls.Add(this.btnDeleteOpenThematic);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dpTimeGroup);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dpTimeRes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTeacherCode);
            this.Controls.Add(this.cbThematicCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtGroupLimit);
            this.Controls.Add(this.btnEditOpenThematic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupCheckEnable);
            this.Name = "frmEditOpenThematic";
            this.Text = "Chỉnh sửa chuyên đề mở";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupCheckEnable.ResumeLayout(false);
            this.groupCheckEnable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dpTimeGroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdHK2;
        private System.Windows.Forms.RadioButton rdHK1;
        private System.Windows.Forms.DateTimePicker dpTimeRes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTeacherCode;
        private System.Windows.Forms.ComboBox cbThematicCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TextBox txtGroupLimit;
        private System.Windows.Forms.Button btnEditOpenThematic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.RadioButton rdClose;
        private System.Windows.Forms.RadioButton rdOpen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupCheckEnable;
        private System.Windows.Forms.Button btnDeleteOpenThematic;
    }
}