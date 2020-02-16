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
  

    class BookPlacePresenter
    {
        IBookPlace iBookPlace;
        BookPlacesModel bookPlacesModel = new BookPlacesModel();

        public BookPlacePresenter(IBookPlace i)
        {
            this.iBookPlace = i;
        }

        //connect bewteen model cat and interface cat
        private void connectBetweenModelInterface()
        {
            bookPlacesModel.ID = iBookPlace.ID;
            bookPlacesModel.CatName = iBookPlace.CatName;
        }


        public bool BookPlaceInsert()
        {
            connectBetweenModelInterface();
            return BookPlaceServeice.bookPlaceInsert(bookPlacesModel.ID, bookPlacesModel.CatName);
        }

        public bool BookPlaceUpdate()
        {
            connectBetweenModelInterface();
            return BookPlaceServeice.bookPlaceUpdate(bookPlacesModel.ID, bookPlacesModel.CatName);
        }
        public bool BookPlaceDeleteAll()
        {

            return BookPlaceServeice.bookPlaceDeleteAll();
        }

        public bool BookPlaceDelete()
        {
            connectBetweenModelInterface();
            return BookPlaceServeice.bookPlaceDelete(bookPlacesModel.ID);
        }
        public void ShowInGridView()
        {
            iBookPlace.dGVPlace = BookPlaceServeice.getAllData();

        }

        public void AutoNumber()
        {
            string test = (BookPlaceServeice.getMaxID().Rows[0][0]).ToString();
            if (test == null || test == "")
            {
                iBookPlace.ID = 1;
            }
            else
            {
                iBookPlace.ID = Convert.ToInt32(BookPlaceServeice.getMaxID().Rows[0][0]) + 1;
            }
            iBookPlace.CatName = "";
            iBookPlace.btnSave = false;
            iBookPlace.btnDelete = false;
            iBookPlace.btnDeleteAll = false;
            iBookPlace.btnAdd = true;
            ShowInGridView();
        }


        public void getRow(int row)
        {
            DataTable tbl = new DataTable();
            tbl = BookPlaceServeice.getAllData();

            iBookPlace.ID = Convert.ToInt32(tbl.Rows[row][0]);
            iBookPlace.CatName = Convert.ToString(tbl.Rows[row][1]);

            iBookPlace.btnSave = true;
            iBookPlace.btnDelete = true;
            iBookPlace.btnDeleteAll = true;
            iBookPlace.btnAdd = false;
        }


        public DataTable getLastRow()
        {
            DataTable tbl = new DataTable();
            tbl = BookPlaceServeice.getLastRow();


            return tbl;
        }
    }
}
