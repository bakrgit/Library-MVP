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
    public partial class Frm_Authors : Form,IAuthors
    {
        AuthoresPresenter authorsPresenter;
        public int ID { get =>Convert.ToInt32( txtID.Text ); set =>  txtID.Text =value.ToString(); }
        public string AuthorName { get => txtName.Text; set =>txtName.Text =value; }
        public string AuthorDate { get => DtpDate.Text; set => DtpDate.Text =value; }
        public int CountryID { get => Convert.ToInt32(cbxCountry.SelectedValue); set => cbxCountry.SelectedValue = value; }
        object IAuthors.Dgv { get => Dgv.DataSource; set => Dgv.DataSource =value; }
        object IAuthors.cbxCountry { get => cbxCountry.DataSource; set => cbxCountry.DataSource=value; }
        object IAuthors.btnAdd { get => btnAdd.Enabled; set => btnAdd.Enabled = Convert.ToBoolean(value); }
        object IAuthors.btnNew { get => btnNew.Enabled; set => btnNew.Enabled = Convert.ToBoolean(value); }
        object IAuthors.btnSave { get => btnSave.Enabled; set => btnSave.Enabled = Convert.ToBoolean(value); }
        object IAuthors.btnDelete { get => btnDelete.Enabled; set => btnDelete.Enabled = Convert.ToBoolean(value); }
        object IAuthors.btnDeleteAll { get => btnDeleteAll.Enabled; set => btnDeleteAll.Enabled = Convert.ToBoolean(value); }
        public string AuthorDisplayMember { get => cbxCountry.DisplayMember; set => cbxCountry.DisplayMember =value; }
        public string AuthorValueMember { get => cbxCountry.ValueMember; set => cbxCountry.ValueMember=value; }
        public int selectdIndex { get =>  cbxCountry.SelectedIndex; set => cbxCountry.SelectedIndex = value; }
        public int selectdValue { get =>Convert.ToInt32( cbxCountry.SelectedValue); set => cbxCountry.SelectedValue =value; }
        public int ROW { get => row; set => row=value; }

        public int row;
        public Frm_Authors()
        {
            InitializeComponent();
            authorsPresenter = new AuthoresPresenter(this);
        }

        private void Frm_Authors_Load(object sender, EventArgs e)
        {
            authorsPresenter.FillCbx();
            authorsPresenter.AutoNumber();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المؤلف", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool check = authorsPresenter.AuthorsInsert();
            if (check)
            {
                MessageBox.Show("تم الاضافة");
                authorsPresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("لم يتم");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            row = 0;
            authorsPresenter.getRow(row);
        }

        private void btnPervios_Click(object sender, EventArgs e)
        {
            int countRow = Convert.ToInt32(authorsPresenter.getLastRow().Rows[0][0]) - 1;
            if (row == 0)
            {
                row = countRow;
            }
            else
            {
                row = row - 1;
            }
            authorsPresenter.getRow(row);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                int countRow = Convert.ToInt32(authorsPresenter.getLastRow().Rows[0][0]);

                if (countRow == row)
                {
                    row = 0;
                }
                else
                {
                    row = row + 1;
                }
                authorsPresenter.getRow(row);
            }
            catch (Exception) { }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                int countLastrow = Convert.ToInt32(authorsPresenter.getLastRow().Rows[0][0]) - 1;

                row = countLastrow;
                authorsPresenter.getRow(row);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Frm_Authors_Load(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المؤلف", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool check = authorsPresenter.AuthorsUpdate();
            if (check)
            {
                MessageBox.Show("تم التعديل");
                authorsPresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("لم يتم");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool check = authorsPresenter.DeleteAuthor();
            if (check)
            {
                MessageBox.Show("تم المسح");
            }
            else
            {
                MessageBox.Show("لم يتم");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            bool check = authorsPresenter.DeleteAuthorAll();
            if (check)
            {
                MessageBox.Show("تم المسح");
            }
            else
            {
                MessageBox.Show("لم يتم");
            }
        }
    }
}
