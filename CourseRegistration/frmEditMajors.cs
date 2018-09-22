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
    public partial class frmEditMajors : DevExpress.XtraEditors.XtraForm
    {
        String con = @"Data Source=DESKTOP-OR1OHFA\SQLEXPRESS;Initial Catalog=CourseRegistration;Integrated Security=True";
        public frmEditMajors()
        {
            InitializeComponent();
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

        public void EditMajorsCode()
        {
            SqlConnection cnn = new SqlConnection(con);

            frmIndex index = new frmIndex();
            try
            {
                cnn.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand("UpdateMajors", cnn);
                command.Parameters.Add("@MajorsCode", SqlDbType.NVarChar, 20).Value = cbMajorsCode.Text;
                command.Parameters.Add("@MajorsName", SqlDbType.NVarChar, 20).Value = txtMajorsName.Text;
                command.Parameters.Add("@SuccessMaticNumber", SqlDbType.Int).Value = txtSuccessMaticNumber.Text;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if ((reader["Message"].ToString()) == "1")
                    {
                        MessageBox.Show("Chỉnh sửa ngành thành công");
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

        public void SelectMajorsCode(String code)
        {
            SqlConnection cnn = new SqlConnection(con);

            frmIndex index = new frmIndex();
            try
            {
                cnn.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand("GetMajorsCode", cnn);
                command.Parameters.Add("@MajorsCode", SqlDbType.VarChar, 20).Value = code;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtMajorsName.Text = reader["MajorsName"].ToString();
                    txtSuccessMaticNumber.Text = reader["SuccessMaticNumber"].ToString();
                }


                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message);
            }
        }

        private void frmEditMajors_Load(object sender, EventArgs e)
        {
            LoadCbMajorsCode();
        }

        private void btnCreateMajors_Click(object sender, EventArgs e)
        {
            EditMajorsCode();
        }

        private void cbMajorsCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectMajorsCode(cbMajorsCode.Text);
        }
    }
}