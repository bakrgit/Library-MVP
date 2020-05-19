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
    class BookDataPresenter
    {

        IBooksData iBookData;
        BookDataModel bookDataModels = new BookDataModel();

        public BookDataPresenter(IBooksData view)
        {
            this.iBookData = view;
        }

        //connect bewteen model cat and interface cat
        private void connectBetweenModelInterface()
        {
            bookDataModels.ID = iBookData.ID;
            bookDataModels.BookName = iBookData.BookName;
            bookDataModels.CountryID = iBookData.CountryID;
            bookDataModels.BookPrice = iBookData.BookPrice;
            bookDataModels.BookStatu = iBookData.BookStatu;
            bookDataModels.CatID = iBookData.CatID;
            bookDataModels.DarID = iBookData.DarID;
            bookDataModels.Date = iBookData.Date;
            bookDataModels.Notes = iBookData.Notes;
            bookDataModels.PageNumbers = iBookData.PageNumbers;
            bookDataModels.PlcaeID = iBookData.PlcaeID;
            bookDataModels.SubCat = iBookData.SubCat;
            bookDataModels.AuthorID = iBookData.AuthorID;
        }
        public void FillCbxDarNashr()
        {
            iBookData.cbxDarNashr = BooksDataService.getAllDarNashrData();
            iBookData.cbxDarNashrDisplayMember = "اسم الدار";
            iBookData.cbxDarNashrValueMember = "رقم الدار";
        }

        public void FillCbxCountry()
        {
            iBookData.cbxCountry = BooksDataService.getAllCountryData();
            iBookData.cbxCountryDisplayMember = "اسم الدولة";
            iBookData.cbxCountryValueMember = "رقم الدولة";
        }

        public void FillCbxCategory()
        {
            iBookData.cbxCat = BooksDataService.getAllCategory();
            iBookData.cbxCatDisplayMember = "اسم التصنيف";
            iBookData.cbxCatValueMember = "رقم التصنيف";
        }

        public void FillCbxBookPlaces()
        {
            iBookData.cbxPlace = BooksDataService.getAllBookPlace();
            iBookData.cbxPlaceDisplayMember = "اسم المكان";
            iBookData.cbxPlaceValueMember = "رقم المكان";
        }
        public void FillCbxAuthore()
        {
            iBookData.cbxAuthores = BooksDataService.getAllAuthore();
            iBookData.cbxAuthoresDisplayMember = "الاسم";
            iBookData.cbxAuthoresValueMember = "رقم المؤلف";
        }

        public void FillCbxBooks()
        {
            iBookData.cbxBooks = BooksDataService.getAllBooks();
            iBookData.cbxBooksDisplayMember = "Book_Name";
            iBookData.cbxBooksValueMember = "ID";
        }

        public void AutoNumber()
        {
            string val = Convert.ToString(BooksDataService.getMaxBookID().Rows[0][0]);
            if (val == null || val == "")
            {
                iBookData.ID = 1;
            }
            else
            {
                iBookData.ID = Convert.ToInt32(BooksDataService.getMaxBookID().Rows[0][0]) + 1;
            }
            iBookData.BookName = "";
            iBookData.Date= DateTime.Now.ToShortDateString();
            iBookData.cbxDarNashrselectdIndex = 0;
            iBookData.cbxPlaceselectdIndex = 0;
            iBookData.cbxCountryselectdIndex = 0;
            iBookData.cbxCatselectdIndex = 0;
            iBookData.cbxBooksselectdIndex = 0;

            iBookData.BookPrice = 1;
            iBookData.PageNumbers = 1;
            iBookData.Notes = "";

            iBookData.btnSave = false;
            iBookData.btnDelete = false;
            iBookData.btnDeleteAll = false;
            iBookData.btnAdd = true;
        }

        //this methoud to connect to services class to insert data in bookData table
        public bool BookDataInsert()
        {
            connectBetweenModelInterface();
            DateTime d1 = Convert.ToDateTime(bookDataModels.Date);
            string d2 = d1.ToString("dd/MM/yyyy");

            return BooksDataService.bookDataInsert(bookDataModels.ID, bookDataModels.BookName, bookDataModels.CatID , bookDataModels.AuthorID, bookDataModels.CountryID, bookDataModels.DarID, bookDataModels.SubCat, d2 , bookDataModels.PageNumbers, bookDataModels.PlcaeID , bookDataModels.BookStatu, bookDataModels.BookPrice, bookDataModels.Notes);
        }

        public bool DeleteBookData()
        {
            connectBetweenModelInterface();
            bool check = BooksDataService.DeleteBookData(bookDataModels.ID);
            AutoNumber();
            return check;
        }
        public bool DeleteBookDataAll()
        {
            connectBetweenModelInterface();
            bool check = BooksDataService.DeleteBookDataAll();
            AutoNumber();
            return check;
        }


        public void getRow(int row)
        {
            DataTable tbl = new DataTable();
            tbl = BooksDataService.getAllbookDataDataID();

            iBookData.ID = Convert.ToInt32(tbl.Rows[row][0]);
            iBookData.BookName = Convert.ToString(tbl.Rows[row][1]);
            iBookData.CatID = Convert.ToInt32(tbl.Rows[row][2]);
            iBookData.AuthorID = Convert.ToInt32(tbl.Rows[row][3]);
            iBookData.CountryID = Convert.ToInt32(tbl.Rows[row][4]);
            iBookData.DarID = Convert.ToInt32(tbl.Rows[row][5]);
            iBookData.SubCat = Convert.ToString(tbl.Rows[row][6]);

            try
            {
                DateTime dt = DateTime.ParseExact(Convert.ToString(tbl.Rows[row][7]), "dd/MM/yyyy", null);
                iBookData.Date = dt.ToString();
            }
            catch (Exception) { }
            iBookData.PageNumbers = Convert.ToInt32(tbl.Rows[row][8]);
            iBookData.PlcaeID = Convert.ToInt32(tbl.Rows[row][9]);
            iBookData.BookStatu = Convert.ToString(tbl.Rows[row][10]);
            iBookData.BookPrice = Convert.ToDecimal(tbl.Rows[row][11]);
            iBookData.Notes = Convert.ToString(tbl.Rows[row][12]);

            iBookData.btnSave = true;
            iBookData.btnDelete = true;
            iBookData.btnDeleteAll = true;
            iBookData.btnAdd = false;
        }


        public DataTable getLastRow()
        {
            DataTable tbl = new DataTable();
            tbl = BooksDataService.getLastRow();
            return tbl;
        }

        //this methoud to connect to services class to insert data in bookData table
        public bool BookDataUpdate()
        {
            connectBetweenModelInterface();
            DateTime d1 = Convert.ToDateTime(bookDataModels.Date);
            string d2 = d1.ToString("dd/MM/yyyy");

            return BooksDataService.bookDataUpdate(bookDataModels.ID, bookDataModels.BookName, bookDataModels.CatID, bookDataModels.AuthorID, bookDataModels.CountryID, bookDataModels.DarID, bookDataModels.SubCat, d2, bookDataModels.PageNumbers, bookDataModels.PlcaeID, bookDataModels.BookStatu, bookDataModels.BookPrice, bookDataModels.Notes);
        }
    }
}
