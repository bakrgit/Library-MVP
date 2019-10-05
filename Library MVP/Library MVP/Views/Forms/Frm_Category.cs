using Library_MVP.Logic.Presenter;
using Library_MVP.Views.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_MVP.Views.Forms
{
    public partial class Frm_Category : Form ,ICategory
    {
        CategoryPresenter catPresenter;

        public int ID { get =>Convert.ToInt32( txtID.Text ); set => txtID.Text = value.ToString() ; }
        public string CatName { get => Convert.ToString(txtName.Text); set => txtName.Text = value.ToString(); }

        public Frm_Category()
        {
            InitializeComponent();
            catPresenter = new CategoryPresenter(this);
        }

        private void Frm_Category_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           bool check = catPresenter.CatInsert();
            if (check)
            {
                MessageBox.Show("تم الاضافة");
            }
            else
            {
                MessageBox.Show("لم يتم");
            }
        }
    }
}
