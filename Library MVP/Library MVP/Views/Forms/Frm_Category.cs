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
        public object dGVCat { get => Dgv.DataSource; set => Dgv.DataSource = value; }
        object ICategory.btnAdd { get => btnAdd.Enabled; set => btnAdd.Enabled = Convert.ToBoolean(value); }
        object ICategory.btnNew { get => btnNew.Enabled; set => btnNew.Enabled = Convert.ToBoolean(value); }
        object ICategory.btnSave { get => btnSave.Enabled; set => btnSave.Enabled = Convert.ToBoolean(value); }
        object ICategory.btnDelete { get => btnDelete.Enabled; set => btnDelete.Enabled = Convert.ToBoolean(value); }
        object ICategory.btnDeleteAll { get => btnDeleteAll.Enabled; set => btnDeleteAll.Enabled = Convert.ToBoolean(value); }
        int ICategory.row { get => row; set => row =value; }

        public int row = 0;
        public Frm_Category()
        {
            InitializeComponent();
            catPresenter = new CategoryPresenter(this);
        }

        private void Frm_Category_Load(object sender, EventArgs e)
        {
            
            catPresenter.AutoNumber();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم التصنيف", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool check = catPresenter.CatInsert();
            if (check)
            {
                catPresenter.AutoNumber();
                MessageBox.Show("تم الاضافة");
            }
            else
            {
                MessageBox.Show("لم يتم");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم التصنيف", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool check = catPresenter.CatUpdate();
            if (check)
            {
                catPresenter.AutoNumber();
                MessageBox.Show("تم التعديل");
            }
            else
            {
                MessageBox.Show("لم يتم التعديل");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool check = catPresenter.CatDelete();
            if (check)
            {
                catPresenter.AutoNumber();
                MessageBox.Show("تم المسح");
            }
            else
            {
                MessageBox.Show("لم يتم المسح");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            bool check = catPresenter.CatDeleteAll();
            if (check)
            {
                catPresenter.AutoNumber();
                MessageBox.Show("تم مسح كل البيانات");
            }
            else
            {
                MessageBox.Show("لم يتم المسح");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            catPresenter.clearFileds();
            catPresenter.AutoNumber();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            row = 0;
            catPresenter.getRow(row);
        }

        private void btnPervios_Click(object sender, EventArgs e)
        {
            int countRow = Convert.ToInt32(catPresenter.getLastRow().Rows[0][0]) - 1;
            if (row == 0)
            {
                row = countRow;
            }
            else
            {
                row = row - 1;
            }
            catPresenter.getRow(row);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                int countRow = Convert.ToInt32(catPresenter.getLastRow().Rows[0][0]);

                if (countRow == row)
                {
                    row = 0;
                }
                else
                {
                    row = row + 1;
                }
                catPresenter.getRow(row);
            }
            catch (Exception) { }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                int countLastrow = Convert.ToInt32(catPresenter.getLastRow().Rows[0][0]) - 1;

                row = countLastrow;
                catPresenter.getRow(row);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
