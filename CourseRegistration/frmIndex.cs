using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace CourseRegistration
{
    public partial class frmIndex : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        private void btnCreateMajors_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCreateMajors frm = new frmCreateMajors();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}