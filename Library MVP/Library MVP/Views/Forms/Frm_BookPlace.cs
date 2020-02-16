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
    public partial class Frm_BookPlace : Form ,IBookPlace
    {
        BookPlacePresenter bookPlacePresenter;
        public Frm_BookPlace()
        {
            InitializeComponent();
            bookPlacePresenter = new BookPlacePresenter(this);
        }

        public int ID { get => Convert.ToInt32(txtID.Text); set => txtID.Text = value.ToString(); }
        int IBookPlace.row { get => row; set => row = value; }
        public string CatName { get => Convert.ToString(txtName.Text); set => txtName.Text = value.ToString(); }
        public object dGVPlace { get => Dgv.DataSource; set => Dgv.DataSource = value; }
        object IBookPlace.btnAdd { get => btnAdd.Enabled; set => btnAdd.Enabled = Convert.ToBoolean(value); }
        object IBookPlace.btnNew { get => btnNew.Enabled; set => btnNew.Enabled = Convert.ToBoolean(value); }
        object IBookPlace.btnSave { get => btnSave.Enabled; set => btnSave.Enabled = Convert.ToBoolean(value); }
        object IBookPlace.btnDelete { get => btnDelete.Enabled; set => btnDelete.Enabled = Convert.ToBoolean(value); }
        object IBookPlace.btnDeleteAll { get => btnDeleteAll.Enabled; set => btnDeleteAll.Enabled = Convert.ToBoolean(value); }
        public int row;
        private void Frm_BookPlace_Load(object sender, EventArgs e)
        {
            bookPlacePresenter.AutoNumber();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المكان", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool check = bookPlacePresenter.BookPlaceInsert();
            if (check)
            {
                bookPlacePresenter.AutoNumber();
                MessageBox.Show("تم الاضافة");
            }
            else
            {
                MessageBox.Show("لم يتم");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bookPlacePresenter.AutoNumber();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المكان", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool check = bookPlacePresenter.BookPlaceUpdate();
            if (check)
            {
                bookPlacePresenter.AutoNumber();
                MessageBox.Show("تم التعديل");
            }
            else
            {
                MessageBox.Show("لم يتم");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {

            bool check = bookPlacePresenter.BookPlaceDeleteAll();
            if (check)
            {
                bookPlacePresenter.AutoNumber();
                MessageBox.Show("تم مسح كل البيانات");
            }
            else
            {
                MessageBox.Show("لم يتم المسح");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool check = bookPlacePresenter.BookPlaceDelete();
            if (check)
            {
                bookPlacePresenter.AutoNumber();
                MessageBox.Show("تم مسح كل البيانات");
            }
            else
            {
                MessageBox.Show("لم يتم المسح");
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            row = 0;
            bookPlacePresenter.getRow(row);
        }

        private void btnPervios_Click(object sender, EventArgs e)
        {

            int countRow = Convert.ToInt32(bookPlacePresenter.getLastRow().Rows[0][0]) - 1;
            if (row == 0)
            {
                row = countRow;
            }
            else
            {
                row = row - 1;
            }
            bookPlacePresenter.getRow(row);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                int countRow = Convert.ToInt32(bookPlacePresenter.getLastRow().Rows[0][0]);

                if (countRow == row)
                {
                    row = 0;
                }
                else
                {
                    row = row + 1;
                }
                bookPlacePresenter.getRow(row);
            }
            catch (Exception) { }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                int countLastrow = Convert.ToInt32(bookPlacePresenter.getLastRow().Rows[0][0]) - 1;

                row = countLastrow;
                bookPlacePresenter.getRow(row);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
