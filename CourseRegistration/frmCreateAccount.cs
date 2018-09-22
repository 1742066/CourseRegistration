using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace CourseRegistration
{
    public partial class frmCreateAccount : DevExpress.XtraEditors.XtraForm
    {
        String con = @"Data Source=DESKTOP-OR1OHFA\SQLEXPRESS;Initial Catalog=CourseRegistration;Integrated Security=True";
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(con);

            frmIndex index = new frmIndex();
            try
            {
                cnn.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand("GetListMajors", cnn);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("MajorsCode", typeof(string));
                dt.Load(reader);
                cbMajorsCode.ValueMember = "MajorsCode";
                cbMajorsCode.DisplayMember = "MajorsCode";
                cbMajorsCode.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message);
            }
        }

        private void Create()
        {
            
            SqlConnection cnn = new SqlConnection(con);

            frmIndex index = new frmIndex();
            try
            {
                cnn.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand("CreateAccount", cnn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@AccountCode", SqlDbType.VarChar, 20).Value = txtAccountCodeNew.Text;
                command.Parameters.Add("@PassWord", SqlDbType.VarChar, 20).Value = txtPW.Text;
                command.Parameters.Add("@PWConfirm", SqlDbType.VarChar, 20).Value = txtPWCF.Text;
                command.Parameters.Add("@FullName", SqlDbType.VarChar, 100).Value = txtAccountName.Text;
                if(rdOpen.Checked)
                {
                    command.Parameters.Add("@Enable", SqlDbType.Int).Value = 1;
                }
                else
                {
                    command.Parameters.Add("@Enable", SqlDbType.Int).Value = 0;
                }
                if (rbNam.Checked)
                {
                    command.Parameters.Add("@Sex", SqlDbType.Int).Value = 1;
                }
                else
                {
                    command.Parameters.Add("@Sex", SqlDbType.Int).Value = 0;
                }
                if (rbGV.Checked)
                {
                    command.Parameters.Add("@Type", SqlDbType.Int).Value = 1;
                }
                else
                {
                    command.Parameters.Add("@Type", SqlDbType.Int).Value = 2;
                }
                command.Parameters.Add("@BirthDay", SqlDbType.DateTime).Value = dtpBirthDate.Text;
                command.Parameters.Add("@Address", SqlDbType.VarChar, 300).Value = txtAddr.Text;
                command.Parameters.Add("@MajorsCode", SqlDbType.VarChar, 20).Value = cbMajorsCode.SelectedValue.ToString();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if ((reader["Message"].ToString()) == "1")
                    {
                        MessageBox.Show("Tạo tài khoản thành công");
                    }
                    else
                    {
                        MessageBox.Show(reader["Message"].ToString());

                    }
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Create();
        }
    }
}