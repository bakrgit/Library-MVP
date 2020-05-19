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
    public partial class Frm_BooksSearch : Form ,IBooksSearch
    {
        BooksSearchPersenter booksPersenter;
        public Frm_BooksSearch()
        {
            InitializeComponent();
            booksPersenter = new BooksSearchPersenter(this);
        }
        
        public object dGVSearch { get => DGVSEARCH.DataSource; set => DGVSEARCH.DataSource = value; }
        public int bookID { get => Convert.ToInt32(cbxBooks.SelectedValue); set => cbxBooks.SelectedValue =Convert.ToInt32(value); }
        object IBooksSearch.cbxBooks { get => cbxBooks.DataSource; set => cbxBooks.DataSource =value; }
        public string cbxBooksDisplayMember { get => cbxBooks.DisplayMember; set => cbxBooks.DisplayMember =value; }
        public string cbxBooksValueMember { get => cbxBooks.ValueMember; set => cbxBooks.ValueMember=value; }
        object IBooksSearch.cbxCat { get => cbxCat.DataSource; set => cbxCat.DataSource =value; }
        public string cbxCatDisplayMember { get => cbxCat.DisplayMember; set => cbxCat.DisplayMember=value; }
        public string cbxCatValueMember { get => cbxCat.ValueMember; set => cbxCat.ValueMember =value; }
        public int catID { get => Convert.ToInt32(cbxCat.SelectedValue); set => cbxCat.SelectedValue=value; }

        private void Frm_BooksSearch_Load(object sender, EventArgs e)
        {
            booksPersenter.FillCbxBooks();
            booksPersenter.FillCbxCategory();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbtnAll.Checked == true)
            {
                booksPersenter.FillDGV();
            }else if (rbtnOneBook.Checked == true)
            {
                booksPersenter.FillDGVByID();
            }else if (rbtnCat.Checked == true)
            {
                booksPersenter.FillDGVByICat();
            }
        }
    }
}
