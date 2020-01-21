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
    public partial class Frm_Country : Form ,ICountry
    {
        CountryPresenter countryPresenter;
        public Frm_Country()
        {
            InitializeComponent();
            countryPresenter = new CountryPresenter(this);
        }

        public int ID { get => Convert.ToInt32(txtID.Text); set => txtID.Text =value.ToString(); }
        public string CountryName { get => txtName.Text; set => txtName.Text = value.ToString(); }
        public object dataGridView { get => Dgv.DataSource; set => Dgv.DataSource = value ; }
        int ICountry.row { get => row; set => row = value; }
        object ICountry.btnAdd { get => btnAdd.Enabled; set => btnAdd.Enabled =Convert.ToBoolean( value); }
        object ICountry.btnNew { get => btnNew.Enabled; set => btnNew.Enabled = Convert.ToBoolean(value); }
        object ICountry.btnSave { get => btnSave.Enabled; set => btnSave.Enabled = Convert.ToBoolean(value); }
        object ICountry.btnDelete { get => btnDelete.Enabled; set => btnDelete.Enabled = Convert.ToBoolean(value); }
        object ICountry.btnDeleteAll { get => btnDeleteAll.Enabled; set => btnDeleteAll.Enabled = Convert.ToBoolean(value); }

        int row = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الدولة" ,"تاكيد",MessageBoxButtons.OK ,MessageBoxIcon.Information);
                return; 
            }
            bool check = countryPresenter.countInsert();
            if (check)
            {
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
                MessageBox.Show("من فضلك ادخل اسم الدولة", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool check = countryPresenter.countUpdate();
            if (check)
            {
                MessageBox.Show("تم التعديل");
            }
            else
            {
                MessageBox.Show("لم يتم");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool check = countryPresenter.countDelete();
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
            bool check = countryPresenter.countDeleteAll();
            if (check)
            {
                MessageBox.Show("تم المسح");
            }
            else
            {
                MessageBox.Show("لم يتم");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            countryPresenter.clearFiled();
            countryPresenter.AutoNumber(); 
        }

        private void Frm_Country_Load(object sender, EventArgs e)
        {
            countryPresenter.getAllData();
            countryPresenter.AutoNumber();
            
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            row = 0;
            countryPresenter.getRow(row);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {   try
            {
                int countRow = Convert.ToInt32(countryPresenter.getLastRow().Rows[0][0]);

                if (countRow == row)
                {
                    row = 0;
                }
                else
                {
                    row = row + 1;
                }
                countryPresenter.getRow(row);
            }
            catch (Exception) { }
        }

        private void btnPervios_Click(object sender, EventArgs e)
        {
            int countRow = Convert.ToInt32(countryPresenter.getLastRow().Rows[0][0]) - 1;
            if (row == 0)
            {
                row = countRow;
            } else
            {
                row = row - 1;
            }
            countryPresenter.getRow(row);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                int countLastrow = Convert.ToInt32(countryPresenter.getLastRow().Rows[0][0]) - 1;

                row = countLastrow;
                countryPresenter.getRow(row);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
