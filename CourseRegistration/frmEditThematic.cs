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
    public partial class frmEditThematic : DevExpress.XtraEditors.XtraForm
    {
        String con = @"Data Source=DESKTOP-OR1OHFA\SQLEXPRESS;Initial Catalog=CourseRegistration;Integrated Security=True";
        public frmEditThematic()
        {
            InitializeComponent();
        }

        private void btnCreateThematic_Click(object sender, EventArgs e)
        {
            EditThemacticCode();
        }

        public void EditThemacticCode()
        {
            SqlConnection cnn = new SqlConnection(con);

            frmIndex index = new frmIndex();
            try
            {
                cnn.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand("UpdateThematic", cnn);
                command.Parameters.Add("@ThematicCode", SqlDbType.NVarChar, 20).Value = cbThematicCode.Text;
                command.Parameters.Add("@ThematicName", SqlDbType.NVarChar, 20).Value = txtThematicName.Text;
                command.Parameters.Add("@MajorsCode", SqlDbType.NVarChar, 20).Value = cbMajorsCode.Text;
                command.Parameters.Add("@ThematicLimit", SqlDbType.Int).Value = txtThematicLimit.Text;
                command.Parameters.Add("@RuleDate", SqlDbType.Date).Value = dtpRuleDate.Text;
                if (rdOpen.Checked)
                {
                    command.Parameters.Add("@Enable", SqlDbType.Int).Value = 1;
                }
                else
                {
                    command.Parameters.Add("@Enable", SqlDbType.Int).Value = 0;
                }
                if (rdYes.Checked)
                {
                    command.Parameters.Add("@IsCompel", SqlDbType.Int).Value = 1;
                }
                else
                {
                    command.Parameters.Add("@IsCompel", SqlDbType.Int).Value = 0;
                }
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if ((reader["Message"].ToString()) == "1")
                    {
                        MessageBox.Show("Chỉnh sửa chuyên đề thành công");
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

        public void LoadCbThematicCode(String code)
        {
            SqlConnection cnn = new SqlConnection(con);

            frmIndex index = new frmIndex();
            try
            {
                cnn.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand("GetListTheMaticFix", cnn);
                command.Parameters.Add("@MajorsCode", SqlDbType.VarChar, 20).Value = code;
                command.Parameters.Add("@Enable", SqlDbType.Int).Value = 1;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("ThematicCode", typeof(string));
                dt.Load(reader);
                cbThematicCode.ValueMember = "ThematicCode";
                cbThematicCode.DisplayMember = "ThematicCode";
                cbThematicCode.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message);
            }
        }

        public void LoadCbMajorsCode()
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

        private void frmEditThematic_Load(object sender, EventArgs e)
        {
            LoadCbMajorsCode();
        }

        private void cbMajorsCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCbThematicCode(cbMajorsCode.Text);
        }

        private void cbThematicCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectThematicCode(cbThematicCode.Text);
        }

        public void SelectThematicCode(String code)
        {
            SqlConnection cnn = new SqlConnection(con);

            frmIndex index = new frmIndex();
            try
            {
                cnn.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand("GetThematicCode", cnn);
                command.Parameters.Add("@ThematicCode", SqlDbType.VarChar, 20).Value = code;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtThematicName.Text = reader["ThematicName"].ToString();
                    txtThematicLimit.Text = reader["ThematicLimit"].ToString();
                    if ((reader["Enable"].ToString()) == "1")
                    {
                        rdOpen.Checked = true;
                    }
                    else
                    {
                        rdClose.Checked = true;
                    }
                    if ((reader["IsCompel"].ToString()) == "1")
                    {
                        rdYes.Checked = true;
                    }
                    else
                    {
                        rdNo.Checked = true;
                   }
                    dtpRuleDate.Text = Convert.ToDateTime(reader["RuleDate"]).ToString();
                }


                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnDeleteThematic_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(con);

            frmIndex index = new frmIndex();
            try
            {
                cnn.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand("DeleteThematic", cnn);
                command.Parameters.Add("@ThematicCode", SqlDbType.VarChar, 20).Value = cbThematicCode.Text;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if ((reader["Message"].ToString()) == "1")
                    {
                        MessageBox.Show("Xóa chuyên đề thành công");
                        LoadCbMajorsCode();
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