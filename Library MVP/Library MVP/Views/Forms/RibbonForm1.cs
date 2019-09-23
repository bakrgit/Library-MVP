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

namespace Library_MVP.Views.Forms
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Category frm = new Frm_Category();
            frm.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_BookPlace frm = new Frm_BookPlace();
            frm.ShowDialog();
        }
    }
}