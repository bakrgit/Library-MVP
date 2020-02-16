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
    public partial class Frm_DarNashr : Form ,IDarNashr
    {
        DarNashrPersenter darPresenter;
        public Frm_DarNashr()
        {
            InitializeComponent();
            darPresenter = new DarNashrPersenter(this);
        }
        public int ID { get => Convert.ToInt32(txtID.Text); set => txtID.Text = value.ToString(); }
        public string DarName { get => txtName.Text; set => txtName.Text = value; }
        public int CountryID { get => Convert.ToInt32(cbxCountry.SelectedValue); set => cbxCountry.SelectedValue = value; }
        object IDarNashr.Dgv { get => Dgv.DataSource; set => Dgv.DataSource = value; }
        object IDarNashr.cbxCountry { get => cbxCountry.DataSource; set => cbxCountry.DataSource = value; }
        object IDarNashr.btnAdd { get => btnAdd.Enabled; set => btnAdd.Enabled = Convert.ToBoolean(value); }
        object IDarNashr.btnNew { get => btnNew.Enabled; set => btnNew.Enabled = Convert.ToBoolean(value); }
        object IDarNashr.btnSave { get => btnSave.Enabled; set => btnSave.Enabled = Convert.ToBoolean(value); }
        object IDarNashr.btnDelete { get => btnDelete.Enabled; set => btnDelete.Enabled = Convert.ToBoolean(value); }
        object IDarNashr.btnDeleteAll { get => btnDeleteAll.Enabled; set => btnDeleteAll.Enabled = Convert.ToBoolean(value); }
        public string DarDisplayMember { get => cbxCountry.DisplayMember; set => cbxCountry.DisplayMember = value; }
        public string DarValueMember { get => cbxCountry.ValueMember; set => cbxCountry.ValueMember = value; }
        public int selectdIndex { get => cbxCountry.SelectedIndex; set => cbxCountry.SelectedIndex = value; }
        public int selectdValue { get => Convert.ToInt32(cbxCountry.SelectedValue); set => cbxCountry.SelectedValue = value; }
        public int ROW { get => row; set => row = value; }

        public int row;


        private void Frm_DarNashr_Load(object sender, EventArgs e)
        {
            darPresenter.FillCbx();
            darPresenter.AutoNumber();
        }

        private void cbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            darPresenter.AutoNumber();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           


            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الدار", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool check = darPresenter.DarNashrInsert();
            if (check)
            {
                MessageBox.Show("تم الاضافة");
                darPresenter.AutoNumber();
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
                MessageBox.Show("من فضلك ادخل اسم الدار", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool check = darPresenter.DarnashrUpdate();
            if (check)
            {
                MessageBox.Show("تم التعديل");
                darPresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("لم التعديل");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool check = darPresenter.DarnashrDeleteID();
            if (check)
            {
                MessageBox.Show("تم المسح");
                darPresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("لم يتم المسح");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            bool check = darPresenter.DarnashrDeleteAll();
            if (check)
            {
                MessageBox.Show("تم المسح");
                darPresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("لم يتم المسح");
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            row = 0;
            darPresenter.getRow(row);
        }

        private void btnPervios_Click(object sender, EventArgs e)
        {
            int countRow = Convert.ToInt32(darPresenter.getLastRow().Rows[0][0]) - 1;
            if (row == 0)
            {
                row = countRow;
            }
            else
            {
                row = row - 1;
            }
            darPresenter.getRow(row);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                int countRow = Convert.ToInt32(darPresenter.getLastRow().Rows[0][0]);

                if (countRow == row)
                {
                    row = 0;
                }
                else
                {
                    row = row + 1;
                }
                darPresenter.getRow(row);
            }
            catch (Exception) { }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                int countLastrow = Convert.ToInt32(darPresenter.getLastRow().Rows[0][0]) - 1;

                row = countLastrow;
                darPresenter.getRow(row);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
