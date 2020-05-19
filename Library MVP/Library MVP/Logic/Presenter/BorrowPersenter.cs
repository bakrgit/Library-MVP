using Library_MVP.Logic.Services;
using Library_MVP.Models;
using Library_MVP.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Logic.Presenter
{
    class BorrowPersenter
    {
        IBorrow iborrow;
        BorrowModel borrowModels = new BorrowModel();

        public BorrowPersenter(IBorrow view)
        {
            this.iborrow = view;
        }


        public void fillBorrowerCbx()
        {
            iborrow.cbxBorrowDatasource = BorrowServices.getAllDataBorrow();
            iborrow.BorrowDisplayMember = "Name";
            iborrow.BorrowValueMember = "ID";
        }

        public void fillBooksCbx()
        {
            iborrow.cbxBooksDatasource = BooksDataService.getAllBooks();
            iborrow.BookDisplayMember = "Book_Name";
            iborrow.BookValueMember = "ID";
        }


        public void AutoNumber()
        {
            string val = Convert.ToString(BorrowServices.getMaxID().Rows[0][0]);
            if (val == null || val == "")
            {
                iborrow.ID = 1;
            }
            else
            {
                iborrow.ID = Convert.ToInt32(BorrowServices.getMaxID().Rows[0][0]) + 1;
            }
            iborrow.Notes = "";
            iborrow.StartDate = DateTime.Now.ToShortDateString();
            iborrow.EndDate = DateTime.Now.ToShortDateString();
            iborrow.selectdIndexBook = 0;
            iborrow.selectdIndexBorrow = 0;
            iborrow.btnSave = false;
            iborrow.btnDelete = false;
            iborrow.btnDeleteAll = false;
            iborrow.btnAdd = true;
        }
    }
}
