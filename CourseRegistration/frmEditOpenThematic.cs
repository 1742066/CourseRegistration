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
    public partial class frmEditOpenThematic : DevExpress.XtraEditors.XtraForm
    {
        String con = @"Data Source=DESKTOP-OR1OHFA\SQLEXPRESS;Initial Catalog=CourseRegistration;Integrated Security=True";
        public frmEditOpenThematic()
        {
            InitializeComponent();
        }

        private void frmEditOpenThematic_Load(object sender, EventArgs e)
        {
            LoadCbTeacherCode();
            LoadCbThematicCode();
        }

        private void btnEditOpenThematic_Click(object sender, EventArgs e)
        {
            EditOpenThemacticCode();
        }

        private void btnDeleteOpenThematic_Click(object sender, EventArgs e)
        {

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

        public void LoadCbThematicCode(String code)
        {
            SqlConnection cnn = new SqlConnection(con);

            frmIndex index = new frmIndex();
            try
            {
                cnn.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand("GetClassThematicCodeFix", cnn);
                command.Parameters.Add("@ThematicCode", SqlDbType.VarChar, 20).Value = code;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cbTeacherCode.Text = reader["TeacherCode"].ToString();
                    txtGroupLimit.Text = reader["MaxGroup"].ToString();
                    if ((reader["Enable"].ToString()) == "1")
                    {
                        rdOpen.Checked = true;
                    }
                    else
                    {
                        rdClose.Checked = true;
                    }
                    if ((reader["HK"].ToString()) == "1")
                    {
                        rdHK1.Checked = true;
                    }
                    else
                    {
                        rdHK2.Checked = true;
                    }
                    dtpStartDate.Text = Convert.ToDateTime(reader["StartDate"]).ToString();
                    dtpEndDate.Text = Convert.ToDateTime(reader["EndDate"]).ToString();
                    dpTimeRes.Text = Convert.ToDateTime(reader["TimeRes"]).ToString();
                    dpTimeGroup.Text = Convert.ToDateTime(reader["TimeGroup"]).ToString();
                }


                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message);
            }
        }

        public void EditOpenThemacticCode()
        {
            SqlConnection cnn = new SqlConnection(con);

            frmIndex index = new frmIndex();
            try
            {
                cnn.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand("UpdateClass", cnn);
                command.Parameters.Add("@TeacherCode", SqlDbType.NVarChar, 20).Value = cbTeacherCode.Text;
                command.Parameters.Add("@ThematicCode", SqlDbType.NVarChar, 20).Value = cbThematicCode.Text;
                command.Parameters.Add("@StartDate", SqlDbType.Date).Value = dtpStartDate.Text;
                command.Parameters.Add("@EndDate", SqlDbType.Date).Value = dtpEndDate.Text;
                command.Parameters.Add("@TimeRes", SqlDbType.Date).Value = dpTimeRes.Text;
                command.Parameters.Add("@TimeGroup", SqlDbType.Date).Value = dpTimeGroup.Text;
                command.Parameters.Add("@MaxGroup", SqlDbType.Int).Value = txtGroupLimit.Text;
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
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if ((reader["Message"].ToString()) == "1")
                    {
                        MessageBox.Show("Chỉnh sửa mở lớp thành công");
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

        private void cbThematicCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCbThematicCode(cbThematicCode.Text);
        }
    }
}