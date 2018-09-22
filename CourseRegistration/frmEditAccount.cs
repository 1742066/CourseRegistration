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
    public partial class frmEditAccount : DevExpress.XtraEditors.XtraForm
    {
        String con = @"Data Source=DESKTOP-OR1OHFA\SQLEXPRESS;Initial Catalog=CourseRegistration;Integrated Security=True";
        public frmEditAccount()
        {
            InitializeComponent();
        }

        private void frmEditAccount_Load(object sender, EventArgs e)
        {
            LoadCbAccountCode();
            LoadMajorsCode();
        }

        public void LoadCbAccountCode()
        {
            SqlConnection cnn = new SqlConnection(con);

            frmIndex index = new frmIndex();
            try
            {
                cnn.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand("GetListAcct", cnn);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("AccountCode", typeof(string));
                dt.Load(reader);
                cbAccountCode.ValueMember = "AccountCode";
                cbAccountCode.DisplayMember = "AccountCode";
                cbAccountCode.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message);
            }
        }

        public void LoadMajorsCode()
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

        private void cbAccountCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectAcctCode(cbAccountCode.SelectedValue.ToString());
        }

        public void SelectAcctCode(String code)
        {
            SqlConnection cnn = new SqlConnection(con);

            frmIndex index = new frmIndex();
            try
            {
                cnn.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand("GetAccountCode", cnn);
                command.Parameters.Add("@AccountCode", SqlDbType.VarChar, 20).Value = code;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtAccountName.Text = reader["FullName"].ToString();
                    txtPW.Text = reader["PassWord"].ToString();
                    txtPWCF.Text = reader["PassWord"].ToString();
                    if((reader["Enable"].ToString()) == "1")
                    {
                        rdOpen.Checked = true;
                    }
                    else
                    {
                        rdClose.Checked = true;
                    }
                    if ((reader["Type"].ToString()) == "1")
                    {
                        rbGV.Checked = true;
                    }
                    else if((reader["Type"].ToString()) == "2")
                    {
                        rbSV.Checked = true;
                    }
                    if ((reader["Sex"].ToString()) == "1")
                    {
                        rbNam.Checked = true;
                    }
                    else
                    {
                        rbNu.Checked = true;
                    }
                    dtpBirthDate.Text = Convert.ToDateTime(reader["Birthday"]).ToString();
                    txtAddr.Text = reader["Address"].ToString();
                    cbMajorsCode.Text = reader["MajorsCode"].ToString();
                }


                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(con);

            frmIndex index = new frmIndex();
            try
            {
                cnn.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand("DeleteAccount", cnn);
                command.Parameters.Add("@AccountCode", SqlDbType.VarChar, 20).Value = cbAccountCode.Text;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if ((reader["Message"].ToString()) == "1")
                    {
                        MessageBox.Show("Xóa tài khoản thành công");
                        LoadCbAccountCode();
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

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            EditAccountCode();
        }

        public void EditAccountCode()
        {
            SqlConnection cnn = new SqlConnection(con);

            frmIndex index = new frmIndex();
            try
            {
                cnn.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand("UpdateAccount", cnn);
                command.Parameters.Add("@AccountCode", SqlDbType.NVarChar, 20).Value = cbAccountCode.Text;
                command.Parameters.Add("@PassWord", SqlDbType.NVarChar, 20).Value = txtPW.Text;
                command.Parameters.Add("@PWConfirm", SqlDbType.NVarChar, 20).Value = txtPWCF.Text;
                command.Parameters.Add("@FullName", SqlDbType.NVarChar, 20).Value = txtAccountName.Text;
                if (rdOpen.Checked)
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
                    command.Parameters.Add("@Sex", SqlDbType.Int).Value = 1;
                }
                if (rbGV.Checked)
                {
                    command.Parameters.Add("@Type", SqlDbType.Int).Value = 1;
                }
                else if (rbSV.Checked)
                {
                    command.Parameters.Add("@Type", SqlDbType.Int).Value = 2;
                }
                command.Parameters.Add("@BirthDay", SqlDbType.Date).Value = dtpBirthDate.Text;
                command.Parameters.Add("@Address", SqlDbType.NVarChar, 300).Value = txtAddr.Text;
                command.Parameters.Add("@MajorsCode", SqlDbType.NVarChar, 20).Value = cbMajorsCode.Text;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if ((reader["Message"].ToString()) == "1")
                    {
                        MessageBox.Show("Chỉnh sửa tài khoản thành công");
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
    }
}