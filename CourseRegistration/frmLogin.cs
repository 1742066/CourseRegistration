using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CourseRegistration
{
    public partial class v : Form
    {
       
        public v()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            String con = @"Data Source=DESKTOP-OR1OHFA\SQLEXPRESS;Initial Catalog=CourseRegistration;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(con);

            frmIndex index = new frmIndex();
            try
            {
                cnn.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand("GetAccountLogin", cnn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@AccountCode", SqlDbType.VarChar, 20).Value = txtAccountCode.Text;
                command.Parameters.Add("@PassWord", SqlDbType.VarChar, 20).Value = txtPassWord.Text;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if ((reader["Message"].ToString()) == "1")
                    {
                        index.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(reader["Message"].ToString());

                    }
                }
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        index.AccountCode = reader["AccountCode"].ToString();
                        index.AccountType = reader["Type"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message);
            }
        }

        private void v_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
