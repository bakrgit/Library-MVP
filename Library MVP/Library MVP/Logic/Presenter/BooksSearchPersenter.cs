using Library_MVP.Logic.Services;
using Library_MVP.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Logic.Presenter
{
   

    class BooksSearchPersenter
    {
        IBooksSearch ibooksSearch;

        public BooksSearchPersenter(IBooksSearch view)
        {
            this.ibooksSearch = view;
        }

        public void FillDGV()
        {
            ibooksSearch.dGVSearch = BooksSearchServices.getAllBooks();
        }

        public void FillDGVByID()
        {
            ibooksSearch.dGVSearch = BooksSearchServices.getAllBooksByID(ibooksSearch.bookID);
        }

        public void FillDGVByICat()
        {
            ibooksSearch.dGVSearch = BooksSearchServices.getAllBooksByCat(ibooksSearch.catID);
        }
        public void FillCbxBooks()
        {
            ibooksSearch.cbxBooks = BooksDataService.getAllBooks();
            ibooksSearch.cbxBooksDisplayMember = "Book_Name";
            ibooksSearch.cbxBooksValueMember = "ID";
        }

        public void FillCbxCategory()
        {
            ibooksSearch.cbxCat = BooksDataService.getAllCategory();
            ibooksSearch.cbxCatDisplayMember = "اسم التصنيف";
            ibooksSearch.cbxCatValueMember = "رقم التصنيف";
        }
    }
}
