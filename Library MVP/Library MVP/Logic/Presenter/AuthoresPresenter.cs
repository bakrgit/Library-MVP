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
            return AuthoresServices.authoresInsert(authorsModels.ID, authorsModels.AuthorName, authorsModels.AuthorDate , authorsModels.CountryID);
        }


        public void FillCbx ()
        {
            iAuthors.cbxCountry = AuthoresServices.getAllData();
            iAuthors.AuthorDisplayMember = "اسم الدولة";
            iAuthors.AuthorValueMember = "رقم الدولة";
        }

        public void AutoNumber ()
        {
            iAuthors.ID = Convert.ToInt32(AuthoresServices.getAuthorMaxID().Rows[0][0]) + 1 ;
            iAuthors.AuthorName = "";
            iAuthors.AuthorDate = DateTime.Now.ToShortDateString();
            iAuthors.selectdIndex = 0;
            iAuthors.Dgv = AuthoresServices.getAllAuthorData();


            iAuthors.btnSave = false;
            iAuthors.btnDelete = false;
            iAuthors.btnDeleteAll = false;
            iAuthors.btnAdd = true;
        }
    }
}
