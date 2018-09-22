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
    public partial class frmCreateThematic : DevExpress.XtraEditors.XtraForm
    {
        String con = @"Data Source=DESKTOP-OR1OHFA\SQLEXPRESS;Initial Catalog=CourseRegistration;Integrated Security=True";
        public frmCreateThematic()
        {
            InitializeComponent();
        }

        private void btnCreateThematic_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void frmCreateThematic_Load(object sender, EventArgs e)
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
                SqlCommand command = new SqlCommand("CreateThematic", cnn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@ThematicCode", SqlDbType.VarChar, 20).Value = txtThematicCode.Text;
                command.Parameters.Add("@ThematicName", SqlDbType.VarChar, 20).Value = txtThematicName.Text;
                command.Parameters.Add("@MajorsCode", SqlDbType.VarChar, 20).Value = cbMajorsCode.Text;
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
                command.Parameters.Add("@ThematicLimit", SqlDbType.Int).Value = txtThematicLimit.Text;
                command.Parameters.Add("@RuleDate", SqlDbType.DateTime).Value = dtpRuleDate.Text;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if ((reader["Message"].ToString()) == "1")
                    {
                        MessageBox.Show("Tạo chuyên đề thành công");
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