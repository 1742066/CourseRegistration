namespace CourseRegistration
{
    partial class frmPC
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
            this.cbThematicCode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTeacherCode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbThematicCode
            // 
            this.cbThematicCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThematicCode.FormattingEnabled = true;
            this.cbThematicCode.Location = new System.Drawing.Point(165, 71);
            this.cbThematicCode.Name = "cbThematicCode";
            this.cbThematicCode.Size = new System.Drawing.Size(216, 24);
            this.cbThematicCode.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 23);
            this.label2.TabIndex = 80;
            this.label2.Text = "Phân công chuyên đề";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 79;
            this.label1.Text = "Chọn mã chuyên đề";
            // 
            // cbTeacherCode
            // 
            this.cbTeacherCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTeacherCode.FormattingEnabled = true;
            this.cbTeacherCode.Location = new System.Drawing.Point(165, 118);
            this.cbTeacherCode.Name = "cbTeacherCode";
            this.cbTeacherCode.Size = new System.Drawing.Size(216, 24);
            this.cbTeacherCode.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 84;
            this.label3.Text = "Chọn mã giáo viên";
            // 
            // btnXN
            // 
            this.btnXN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXN.Location = new System.Drawing.Point(102, 174);
            this.btnXN.Name = "btnXN";
            this.btnXN.Size = new System.Drawing.Size(158, 31);
            this.btnXN.TabIndex = 86;
            this.btnXN.Text = "Xác nhận";
            this.btnXN.UseVisualStyleBackColor = true;
            this.btnXN.Click += new System.EventHandler(this.btnXN_Click);
            // 
            // frmPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 280);
            this.Controls.Add(this.btnXN);
            this.Controls.Add(this.cbTeacherCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbThematicCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPC";
            this.Text = "Phân công";
            this.Load += new System.EventHandler(this.frmPC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbThematicCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTeacherCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXN;
    }
}