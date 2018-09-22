namespace CourseRegistration
{
    partial class frmEditMajors
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
            this.txtSuccessMaticNumber = new System.Windows.Forms.TextBox();
            this.btnCreateMajors = new System.Windows.Forms.Button();
            this.txtMajorsName = new System.Windows.Forms.TextBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMajorsCode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(427, 154);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(37, 23);
            this.btnDown.TabIndex = 21;
            this.btnDown.Text = "▼ ";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(384, 155);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(37, 22);
            this.btnUp.TabIndex = 20;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // txtSuccessMaticNumber
            // 
            this.txtSuccessMaticNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuccessMaticNumber.Location = new System.Drawing.Point(322, 157);
            this.txtSuccessMaticNumber.Name = "txtSuccessMaticNumber";
            this.txtSuccessMaticNumber.Size = new System.Drawing.Size(56, 23);
            this.txtSuccessMaticNumber.TabIndex = 19;
            // 
            // btnCreateMajors
            // 
            this.btnCreateMajors.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMajors.Location = new System.Drawing.Point(198, 240);
            this.btnCreateMajors.Name = "btnCreateMajors";
            this.btnCreateMajors.Size = new System.Drawing.Size(118, 31);
            this.btnCreateMajors.TabIndex = 18;
            this.btnCreateMajors.Text = "Chỉnh sửa";
            this.btnCreateMajors.UseVisualStyleBackColor = true;
            this.btnCreateMajors.Click += new System.EventHandler(this.btnCreateMajors_Click);
            // 
            // txtMajorsName
            // 
            this.txtMajorsName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMajorsName.Location = new System.Drawing.Point(250, 118);
            this.txtMajorsName.Name = "txtMajorsName";
            this.txtMajorsName.Size = new System.Drawing.Size(171, 23);
            this.txtMajorsName.TabIndex = 17;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(103, 205);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 16);
            this.lbMessage.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Số lượng chuyên đề hoàn thành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên ngành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Điều chỉnh ngành";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chọn mã ngành";
            // 
            // cbMajorsCode
            // 
            this.cbMajorsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMajorsCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMajorsCode.FormattingEnabled = true;
            this.cbMajorsCode.Location = new System.Drawing.Point(250, 78);
            this.cbMajorsCode.Name = "cbMajorsCode";
            this.cbMajorsCode.Size = new System.Drawing.Size(171, 24);
            this.cbMajorsCode.TabIndex = 22;
            this.cbMajorsCode.SelectedIndexChanged += new System.EventHandler(this.cbMajorsCode_SelectedIndexChanged);
            // 
            // frmEditMajors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 363);
            this.Controls.Add(this.cbMajorsCode);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtSuccessMaticNumber);
            this.Controls.Add(this.btnCreateMajors);
            this.Controls.Add(this.txtMajorsName);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEditMajors";
            this.Text = "Chỉnh sửa Ngành";
            this.Load += new System.EventHandler(this.frmEditMajors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TextBox txtSuccessMaticNumber;
        private System.Windows.Forms.Button btnCreateMajors;
        private System.Windows.Forms.TextBox txtMajorsName;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMajorsCode;
    }
}