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

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_DarNashr frm = new Frm_DarNashr();
            frm.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Country frm = new Frm_Country();
            frm.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Authors frm = new Frm_Authors();
            frm.ShowDialog();
        }
    }
}