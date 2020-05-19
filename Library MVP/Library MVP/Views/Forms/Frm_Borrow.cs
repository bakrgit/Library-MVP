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
    public partial class Frm_Borrow : Form ,IBorrow
    {
        public int ID { get => Convert.ToInt32(txtID.Text); set => txtID.Text = value.ToString(); }
        public int BookID { get => Convert.ToInt32(cbxbooks.SelectedValue); set => cbxbooks.SelectedValue = value; }
        public int BorrowerID { get => Convert.ToInt32(cbxBorrower.SelectedValue); set => cbxBorrower.SelectedValue = value; }
        public string StartDate { get => DtpStart.Text; set => DtpStart.Text = value; }
        public string EndDate { get => DtpEnd.Text; set => DtpEnd.Text = value; }
        public string Notes { get => txtNotes.Text; set => txtNotes.Text = value; }
        public object cbxBorrowDatasource { get => cbxBorrower.DataSource; set => cbxBorrower.DataSource = value; }
        public string BorrowDisplayMember { get => cbxBorrower.DisplayMember; set => cbxBorrower.DisplayMember = value; }
        public string BorrowValueMember { get => cbxBorrower.ValueMember; set => cbxBorrower.ValueMember = value; }
        public int selectdIndexBorrow { get => cbxBorrower.SelectedIndex; set => cbxBorrower.SelectedIndex = value; }
        public object cbxBooksDatasource { get => cbxbooks.DataSource; set => cbxbooks.DataSource = value; }
        public string BookDisplayMember { get => cbxbooks.DisplayMember; set => cbxbooks.DisplayMember = value; }
        public string BookValueMember { get => cbxbooks.ValueMember; set => cbxbooks.ValueMember = value; }
        public int selectdIndexBook { get => cbxbooks.SelectedIndex; set => cbxbooks.SelectedIndex = value; }
        object IBorrow.btnAdd { get => btnAdd.Enabled; set => btnAdd.Enabled = Convert.ToBoolean(value); }
        object IBorrow.btnNew { get => btnNew.Enabled; set => btnNew.Enabled = Convert.ToBoolean(value); }
        object IBorrow.btnSave { get => btnSave.Enabled; set => btnSave.Enabled = Convert.ToBoolean(value); }
        object IBorrow.btnDelete { get => btnDelete.Enabled; set => btnDelete.Enabled = Convert.ToBoolean(value); }
        object IBorrow.btnDeleteAll { get => btnDeleteAll.Enabled; set => btnDeleteAll.Enabled = Convert.ToBoolean(value); }
        int IBorrow.ROW { get => row; set => row = value; }
        int row = 0;

        BorrowPersenter borrowPersenter;
        public Frm_Borrow()
        {
            InitializeComponent();
            borrowPersenter = new BorrowPersenter(this);
        }


       
        private void Frm_Borrow_Load(object sender, EventArgs e)
        {
            borrowPersenter.fillBooksCbx();
            borrowPersenter.fillBorrowerCbx();

            borrowPersenter.AutoNumber();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            borrowPersenter.AutoNumber();
        }
    }
}
