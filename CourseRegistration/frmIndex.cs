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

        private void btnEditMajoirs_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmEditMajors frm = new frmEditMajors();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCreateSubjects_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCreateSubjects frm = new frmCreateSubjects();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnEditSubjects_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmEditSubjects frm = new frmEditSubjects();
            frm.MdiParent = this;
            frm.Show();
        }

        private void CreateThematic_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCreateThematic frm = new frmCreateThematic();
            frm.MdiParent = this;
            frm.Show();
        }

        private void EditThematic_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmEditThematic frm = new frmEditThematic();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnOpenThematic_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmOpenThematic frm = new frmOpenThematic();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnEditOpenThematic_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmEditOpenThematic frm = new frmEditOpenThematic();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}