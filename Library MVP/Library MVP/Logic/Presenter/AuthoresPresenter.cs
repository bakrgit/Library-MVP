using Library_MVP.Logic.Services;
using Library_MVP.Models;
using Library_MVP.Views.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Logic.Presenter
{
    class AuthoresPresenter
    {
        IAuthors iAuthors;
        AuthorsModel authorsModels = new AuthorsModel();

        public AuthoresPresenter(IAuthors view)
        {
            this.iAuthors = view;
        }

        //connect bewteen model cat and interface cat
        private void connectBetweenModelInterface()
        {
            authorsModels.ID = iAuthors.ID;
            authorsModels.AuthorName = iAuthors.AuthorName;
            authorsModels.CountryID = iAuthors.CountryID;
            authorsModels.AuthorDate = iAuthors.AuthorDate;
        }

        //this methoud to connect to services class to insert data in authors table
        public bool AuthorsInsert()
        {
            connectBetweenModelInterface();
            DateTime d1 = Convert.ToDateTime(authorsModels.AuthorDate);
            string d2 = d1.ToString("dd/MM/yyyy");

            return AuthoresServices.authoresInsert(authorsModels.ID, authorsModels.AuthorName, d2 , authorsModels.CountryID);
        }
        //this methoud to connect to services class to update data in authors table
        public bool AuthorsUpdate()
        {
            connectBetweenModelInterface();
            DateTime d1 = Convert.ToDateTime(authorsModels.AuthorDate);
            string d2 = d1.ToString("dd/MM/yyyy");

            return AuthoresServices.authoresUpdate(authorsModels.ID, authorsModels.AuthorName, d2, authorsModels.CountryID);
        }


        public void FillCbx ()
        {
            iAuthors.cbxCountry = AuthoresServices.getAllData();
            iAuthors.AuthorDisplayMember = "اسم الدولة";
            iAuthors.AuthorValueMember = "رقم الدولة";
        }

        public void AutoNumber ()
        {
            string val = Convert.ToString(AuthoresServices.getAuthorMaxID().Rows[0][0]);
            if (val == null || val == "")
            {
                iAuthors.ID = 1;
            }
            else
            {
                iAuthors.ID = Convert.ToInt32(AuthoresServices.getAuthorMaxID().Rows[0][0]) + 1;
            }
            iAuthors.AuthorName = "";
            iAuthors.AuthorDate = DateTime.Now.ToShortDateString();
            iAuthors.selectdIndex = 0;
            iAuthors.Dgv = AuthoresServices.getAllAuthorData();


            iAuthors.btnSave = false;
            iAuthors.btnDelete = false;
            iAuthors.btnDeleteAll = false;
            iAuthors.btnAdd = true;
        }



        public void getRow(int row)
        {
            DataTable tbl = new DataTable();
            tbl = AuthoresServices.getAllAuthorDataCountryID();

            iAuthors.ID = Convert.ToInt32(tbl.Rows[row][0]);
            iAuthors.AuthorName = Convert.ToString(tbl.Rows[row][1]);
            try
            {
                DateTime dt = DateTime.ParseExact(Convert.ToString(tbl.Rows[row][2]), "dd/MM/yyyy", null);
                iAuthors.AuthorDate = dt.ToString();
            }
            catch (Exception) { }
            iAuthors.selectdValue = Convert.ToInt32(tbl.Rows[row][3]);

            iAuthors.btnSave = true;
            iAuthors.btnDelete = true;
            iAuthors.btnDeleteAll = true;
            iAuthors.btnAdd = false;
        }


        public DataTable getLastRow()
        {
            DataTable tbl = new DataTable();
            tbl = AuthoresServices.getLastRow();


            return tbl;
        }

        public bool DeleteAuthor()
        {
            connectBetweenModelInterface();
            bool check = AuthoresServices.DeleteDeleteAuthor(authorsModels.ID);
            AutoNumber();
            return check;
        }

        public bool DeleteAuthorAll()
        {
            connectBetweenModelInterface();
            bool check = AuthoresServices.DeleteAuthorAll();
            AutoNumber();
            return check;
        }
    }
}
