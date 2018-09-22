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
    public partial class frmOpenThematic : DevExpress.XtraEditors.XtraForm
    {
        String con = @"Data Source=DESKTOP-OR1OHFA\SQLEXPRESS;Initial Catalog=CourseRegistration;Integrated Security=True";
        public frmOpenThematic()
        {
            InitializeComponent();
        }

        private void frmOpenThematic_Load(object sender, EventArgs e)
        {
            LoadCbThematicCode();
            LoadCbTeacherCode();
        }

        private void btnOpenThematic_Click(object sender, EventArgs e)
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
                SqlCommand command = new SqlCommand("CreateClass", cnn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@TeacherCode", SqlDbType.VarChar, 20).Value = cbTeacherCode.Text;
                command.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = dtpStartDate.Text;
                command.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = dtpStartDate.Text;
                command.Parameters.Add("@MaxGroup", SqlDbType.Int).Value = txtGroupLimit.Text;
                command.Parameters.Add("@ThematicCode", SqlDbType.VarChar, 20).Value = cbThematicCode.Text;
                command.Parameters.Add("@TimeRes", SqlDbType.DateTime).Value = dpTimeRes.Text;
                command.Parameters.Add("@TimeGroup", SqlDbType.DateTime).Value = dpTimeGroup.Text;
                if (rdOpen.Checked)
                {
                    command.Parameters.Add("@Enable", SqlDbType.Int).Value = 1;
                }
                else
                {
                    command.Parameters.Add("@Enable", SqlDbType.Int).Value = 0;
                }
                if (rdHK1.Checked)
                {
                    command.Parameters.Add("@HK", SqlDbType.Int).Value = 1;
                }
                else
                {
                    command.Parameters.Add("@HK", SqlDbType.Int).Value = 2;
                }
                command.Parameters.Add("@NameClass", SqlDbType.VarChar, 100).Value = txtClassName.Text;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if ((reader["Message"].ToString()) == "1")
                    {
                        MessageBox.Show("Mở lớp thành công");
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

        public void LoadCbThematicCode()
        {
            SqlConnection cnn = new SqlConnection(con);

            frmIndex index = new frmIndex();
            try
            {
                cnn.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand("GetCodeThematic", cnn);
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

        public void LoadCbTeacherCode()
        {
            SqlConnection cnn = new SqlConnection(con);

            frmIndex index = new frmIndex();
            try
            {
                cnn.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand("GetTeacherCode", cnn);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("AccountCode", typeof(string));
                dt.Load(reader);
                cbTeacherCode.ValueMember = "AccountCode";
                cbTeacherCode.DisplayMember = "AccountCode";
                cbTeacherCode.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message);
            }
        }
    }
}