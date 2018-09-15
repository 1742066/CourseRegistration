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

namespace CourseRegistration
{
    public partial class frmCreateMajors : DevExpress.XtraEditors.XtraForm
    {
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
    }
}