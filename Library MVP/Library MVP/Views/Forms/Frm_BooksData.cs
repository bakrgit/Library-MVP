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
    public partial class Frm_BooksData : Form  , IBooksData
    {
        public int ROW { get => row; set => row=value; }
        public int ID { get => Convert.ToInt32(txtID.Text); set => txtID.Text = value.ToString(); }
        public string BookName { get => txtName.Text; set => txtName.Text =value; }
        public int CatID { get => Convert.ToInt32( cbxCat.SelectedValue); set => cbxCat.SelectedValue= value; }
        public int AuthorID { get => Convert.ToInt32(cbxAuthors.SelectedValue); set => cbxAuthors.SelectedValue =value; }
        public int CountryID { get => Convert.ToInt32(cbxCountry.SelectedValue); set => cbxCountry.SelectedValue = value; }
        public int DarID { get => Convert.ToInt32(cbxDarNashr.SelectedValue); set => cbxDarNashr.SelectedValue = value; }
        public string SubCat { get => txtSubCat.Text; set => txtSubCat.Text=value; }
        public string Date { get => DtpDate.Text; set => DtpDate.Text=value; }
        public int PageNumbers { get =>Convert.ToInt32( NudPagesNumber.Value); set => NudPagesNumber.Value =value; }
        public int PlcaeID { get => Convert.ToInt32(cbxPlaces.SelectedValue); set => cbxPlaces.SelectedValue=value; }
        public string BookStatu { get => txtBookStatu.Text; set => txtBookStatu.Text=value; }
        public decimal BookPrice { get => Convert.ToInt32(NudBookPrice.Value); set => NudBookPrice.Value = value; }
        public string Notes { get => txtNotes.Text; set => txtNotes.Text=value; }


        object IBooksData.cbxCountry { get => cbxCountry.DataSource; set => cbxCountry.DataSource=value; }
        object IBooksData.cbxCat { get => cbxCat.DataSource; set => cbxCat.DataSource =value; }
        public object cbxPlace { get => cbxPlaces.DataSource; set => cbxPlaces.DataSource=value; }
        object IBooksData.cbxDarNashr { get => cbxDarNashr.DataSource; set => cbxDarNashr.DataSource=value; }
        object IBooksData.cbxBooks { get => cbxBooks.DataSource; set => cbxBooks.DataSource=value; }
        public string cbxCountryDisplayMember { get => cbxCountry.DisplayMember; set => cbxCountry.DisplayMember =value; }
        public string cbxCountryValueMember { get => cbxCountry.ValueMember; set => cbxCountry.ValueMember=value; }
        public string cbxCatDisplayMember { get => cbxCat.DisplayMember; set => cbxCat.DisplayMember=value; }
        public string cbxCatValueMember { get => cbxCat.ValueMember; set => cbxCat.ValueMember=value; }
        public string cbxPlaceDisplayMember { get => cbxPlaces.DisplayMember; set => cbxPlaces.DisplayMember=value; }
        public string cbxPlaceValueMember { get => cbxPlaces.ValueMember; set => cbxPlaces.ValueMember = value; }
        public string cbxDarNashrDisplayMember { get => cbxDarNashr.DisplayMember; set => cbxDarNashr.DisplayMember=value; }
        public string cbxDarNashrValueMember { get => cbxDarNashr.ValueMember; set => cbxDarNashr.ValueMember=value; }
        public string cbxBooksDisplayMember { get => cbxBooks.DisplayMember; set => cbxBooks.DisplayMember=value; }
        public string cbxBooksValueMember { get => cbxBooks.ValueMember; set => cbxBooks.ValueMember=value; }
        public int cbxCountryselectdIndex { get => cbxCountry.SelectedIndex; set => cbxCountry.SelectedIndex=value; }
        public int cbxCountryselectdValue { get =>Convert.ToInt32( cbxCountry.SelectedValue); set => cbxCountry.SelectedValue = value; }
        public int cbxCatselectdIndex { get => cbxCat.SelectedIndex; set => cbxCat.SelectedIndex=value; }
        public int cbxCatselectdValue { get => Convert.ToInt32(cbxCat.SelectedValue); set => cbxCat.SelectedValue=value; }
        public int cbxPlaceselectdIndex { get => cbxPlaces.SelectedIndex; set => cbxPlaces.SelectedIndex =value; }
        public int cbxPlaceselectdValue { get => Convert.ToInt32(cbxPlaces.SelectedValue); set => cbxPlaces.SelectedValue = value; }
        public int cbxDarNashrselectdIndex { get => cbxDarNashr.SelectedIndex; set => cbxDarNashr.SelectedIndex=value; }
        public int cbxDarNashrselectdValue { get => Convert.ToInt32(cbxDarNashr.SelectedValue); set => cbxDarNashr.SelectedValue=value; }
        public int cbxBooksselectdIndex { get => cbxBooks.SelectedIndex; set => cbxBooks.SelectedIndex=value; }
        public int cbxBooksselectdValue { get => Convert.ToInt32(cbxBooks.SelectedValue); set => cbxBooks.SelectedValue=value; }


        bool IBooksData.btnAdd { get => btnAdd.Enabled; set => btnAdd.Enabled = Convert.ToBoolean(value); }
        bool IBooksData.btnNew { get => btnNew.Enabled; set => btnNew.Enabled = Convert.ToBoolean(value); }
        bool IBooksData.btnSave { get => btnSave.Enabled; set => btnSave.Enabled = Convert.ToBoolean(value); }
        bool IBooksData.btnDelete { get => btnDelete.Enabled; set => btnDelete.Enabled = Convert.ToBoolean(value); }
        bool IBooksData.btnDeleteAll { get => btnDeleteAll.Enabled; set => btnDeleteAll.Enabled = Convert.ToBoolean(value); }
        public int row = 0;
        public Frm_BooksData()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Frm_BooksData_Load(object sender, EventArgs e)
        {

        }
    }
}
