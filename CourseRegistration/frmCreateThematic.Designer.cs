namespace CourseRegistration
{
    partial class frmCreateThematic
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
            this.rdClose = new System.Windows.Forms.RadioButton();
            this.rdOpen = new System.Windows.Forms.RadioButton();
            this.groupCheckEnable = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSubjectsCode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.txtThematicLimit = new System.Windows.Forms.TextBox();
            this.btnCreateThematic = new System.Windows.Forms.Button();
            this.txtThematicName = new System.Windows.Forms.TextBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThematicCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNo = new System.Windows.Forms.RadioButton();
            this.rdYes = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.groupCheckEnable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // groupCheckEnable
            // 
            this.groupCheckEnable.Controls.Add(this.rdClose);
            this.groupCheckEnable.Controls.Add(this.rdOpen);
            this.groupCheckEnable.Location = new System.Drawing.Point(549, 103);
            this.groupCheckEnable.Name = "groupCheckEnable";
            this.groupCheckEnable.Size = new System.Drawing.Size(171, 34);
            this.groupCheckEnable.TabIndex = 44;
            this.groupCheckEnable.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Tình trạng";
            // 
            // cbSubjectsCode
            // 
            this.cbSubjectsCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubjectsCode.FormattingEnabled = true;
            this.cbSubjectsCode.Location = new System.Drawing.Point(180, 105);
            this.cbSubjectsCode.Name = "cbSubjectsCode";
            this.cbSubjectsCode.Size = new System.Drawing.Size(185, 24);
            this.cbSubjectsCode.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Chọn bộ môn";
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(342, 199);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(37, 23);
            this.btnDown.TabIndex = 40;
            this.btnDown.Text = "▼ ";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(299, 200);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(37, 22);
            this.btnUp.TabIndex = 39;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // txtThematicLimit
            // 
            this.txtThematicLimit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThematicLimit.Location = new System.Drawing.Point(237, 200);
            this.txtThematicLimit.Name = "txtThematicLimit";
            this.txtThematicLimit.Size = new System.Drawing.Size(56, 23);
            this.txtThematicLimit.TabIndex = 38;
            // 
            // btnCreateThematic
            // 
            this.btnCreateThematic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateThematic.Location = new System.Drawing.Point(299, 286);
            this.btnCreateThematic.Name = "btnCreateThematic";
            this.btnCreateThematic.Size = new System.Drawing.Size(118, 31);
            this.btnCreateThematic.TabIndex = 37;
            this.btnCreateThematic.Text = "Tạo mới";
            this.btnCreateThematic.UseVisualStyleBackColor = true;
            // 
            // txtThematicName
            // 
            this.txtThematicName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThematicName.Location = new System.Drawing.Point(549, 64);
            this.txtThematicName.Name = "txtThematicName";
            this.txtThematicName.Size = new System.Drawing.Size(185, 23);
            this.txtThematicName.TabIndex = 36;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(71, 245);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 16);
            this.lbMessage.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Giới hạn số lượng sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nhập tên chuyên đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tạo mới chuyên đề";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nhập mã chuyên đề";
            // 
            // txtThematicCode
            // 
            this.txtThematicCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThematicCode.Location = new System.Drawing.Point(182, 63);
            this.txtThematicCode.Name = "txtThematicCode";
            this.txtThematicCode.Size = new System.Drawing.Size(183, 23);
            this.txtThematicCode.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNo);
            this.groupBox1.Controls.Add(this.rdYes);
            this.groupBox1.Location = new System.Drawing.Point(549, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 34);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // rdNo
            // 
            this.rdNo.AutoSize = true;
            this.rdNo.Checked = true;
            this.rdNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNo.Location = new System.Drawing.Point(111, 10);
            this.rdNo.Name = "rdNo";
            this.rdNo.Size = new System.Drawing.Size(66, 20);
            this.rdNo.TabIndex = 1;
            this.rdNo.TabStop = true;
            this.rdNo.Text = "Không";
            this.rdNo.UseVisualStyleBackColor = true;
            // 
            // rdYes
            // 
            this.rdYes.AutoSize = true;
            this.rdYes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdYes.Location = new System.Drawing.Point(0, 10);
            this.rdYes.Name = "rdYes";
            this.rdYes.Size = new System.Drawing.Size(42, 20);
            this.rdYes.TabIndex = 0;
            this.rdYes.Text = "Có";
            this.rdYes.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Bắt buộc";
            // 
            // frmCreateThematic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupCheckEnable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSubjectsCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtThematicLimit);
            this.Controls.Add(this.btnCreateThematic);
            this.Controls.Add(this.txtThematicName);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThematicCode);
            this.Name = "frmCreateThematic";
            this.Text = "Tạo chuyên ngành";
            this.groupCheckEnable.ResumeLayout(false);
            this.groupCheckEnable.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdClose;
        private System.Windows.Forms.RadioButton rdOpen;
        private System.Windows.Forms.GroupBox groupCheckEnable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSubjectsCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TextBox txtThematicLimit;
        private System.Windows.Forms.Button btnCreateThematic;
        private System.Windows.Forms.TextBox txtThematicName;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThematicCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNo;
        private System.Windows.Forms.RadioButton rdYes;
        private System.Windows.Forms.Label label7;
    }
}