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
    public partial class Frm_Borrowers : Form ,IBorrowers
    {
        BorrowersPersenter borrowersPresenter;

        public int ID { get => Convert.ToInt32(txtID.Text); set => txtID.Text = value.ToString(); }
        public string Phone { get => txtPhone.Text; set => txtPhone.Text = value; }
        public string Address { get => txtAddress.Text; set => txtAddress.Text = value; }
        public string Notes { get => txtNotes.Text; set => txtNotes.Text = value; }
        public string Name { get => txtName.Text; set => txtName.Text = value; }
        object IBorrowers.btnAdd { get => btnAdd.Enabled; set => btnAdd.Enabled = Convert.ToBoolean(value); }
        object IBorrowers.btnNew { get => btnNew.Enabled; set => btnNew.Enabled = Convert.ToBoolean(value); }
        object IBorrowers.btnSave { get => btnSave.Enabled; set => btnSave.Enabled = Convert.ToBoolean(value); }
        object IBorrowers.btnDelete { get => btnDelete.Enabled; set => btnDelete.Enabled = Convert.ToBoolean(value); }
        object IBorrowers.btnDeleteAll { get => btnDeleteAll.Enabled; set => btnDeleteAll.Enabled = Convert.ToBoolean(value); }


        int IBorrowers.row { get => row; set => row = value; }

        public int row = 0;
        public Frm_Borrowers()
        {
            InitializeComponent();
            borrowersPresenter = new BorrowersPersenter(this);

        }
        
        private void Frm_Borrowers_Load(object sender, EventArgs e)
        {
            borrowersPresenter.AutoNumber();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            borrowersPresenter.AutoNumber();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المستعير", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool check = borrowersPresenter.BorrowerInsert();
            if (check)
            {
                borrowersPresenter.AutoNumber();
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
                MessageBox.Show("من فضلك ادخل اسم المستعير", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool check = borrowersPresenter.BorrowerUpdate();
            if (check)
            {
                borrowersPresenter.AutoNumber();
                MessageBox.Show("تم التعديل");
            }
            else
            {
                MessageBox.Show("لم يتم");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            bool check = borrowersPresenter.BorrowerDelete();
            if (check)
            {
                borrowersPresenter.AutoNumber();
                MessageBox.Show("تم المسح");
            }
            else
            {
                MessageBox.Show("لم يتم");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            bool check = borrowersPresenter.BorrowerDeleteAll();
            if (check)
            {
                borrowersPresenter.AutoNumber();
                MessageBox.Show("تم مسح الكل");
            }
            else
            {
                MessageBox.Show("لم يتم");
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            row = 0;
            borrowersPresenter.getRow(row);
        }

        private void btnPervios_Click(object sender, EventArgs e)
        {
            int countRow = Convert.ToInt32(borrowersPresenter.getLastRow().Rows[0][0]) - 1;
            if (row == 0)
            {
                row = countRow;
            }
            else
            {
                row = row - 1;
            }
            borrowersPresenter.getRow(row);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                int countRow = Convert.ToInt32(borrowersPresenter.getLastRow().Rows[0][0]);

                if (countRow == row)
                {
                    row = 0;
                }
                else
                {
                    row = row + 1;
                }
                borrowersPresenter.getRow(row);
            }
            catch (Exception) { }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                int countLastrow = Convert.ToInt32(borrowersPresenter.getLastRow().Rows[0][0]) - 1;

                row = countLastrow;
                borrowersPresenter.getRow(row);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
