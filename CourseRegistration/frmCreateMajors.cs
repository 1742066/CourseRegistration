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
    public partial class frmCreateMajors : DevExpress.XtraEditors.XtraForm
    {
        String con = @"Data Source=DESKTOP-OR1OHFA\SQLEXPRESS;Initial Catalog=CourseRegistration;Integrated Security=True";
        public frmCreateMajors()
        {
            InitializeComponent();
        }

        private void txtSuccessMaticNumber_KeyDown(object sender, KeyEventArgs e)
        {
            //int number = 0;
            //if (!int.TryParse(txtSuccessMaticNumber.Text.Trim(), out number))
            //{
            //    MessageBox.Show("Chỉ được nhập số");
            //    return;
            //}
        }

        private void btnCreateMajors_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void Create()
        {

            SqlConnection cnn = new SqlConnection(con);

            frmIndex index = new frmIndex();
            try
            {
                cnn.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand("CreateMajors", cnn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MajorsCode", SqlDbType.VarChar, 20).Value = txtMajorsCode.Text;
                command.Parameters.Add("@MajorsName", SqlDbType.VarChar, 200).Value = txtMajorsName.Text;
                command.Parameters.Add("@SuccessMaticNumber", SqlDbType.Int).Value = txtSuccessMaticNumber.Text;
                
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if ((reader["Message"].ToString()) == "1")
                    {
                        MessageBox.Show("Tạo ngành thành công");
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