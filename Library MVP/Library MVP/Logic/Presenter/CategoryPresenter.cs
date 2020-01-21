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
    class CategoryPresenter
    {
        ICategory icateory;
        CategoryModel catModel = new CategoryModel();

        public CategoryPresenter(ICategory view)
        {
            this.icateory = view;
        }

        //connect bewteen model cat and interface cat
        private void connectBetweenModelInterface ()
        {
            catModel.ID = icateory.ID;
            catModel.CatName = icateory.CatName;
        }

        public bool CatInsert ()
        {
            connectBetweenModelInterface();
            return CategoryService.categoryInsert(catModel.ID , catModel.CatName);
        }

        public bool CatUpdate()
        {
            connectBetweenModelInterface();
            return CategoryService.categoryUpdate(catModel.ID, catModel.CatName);
        }
        public bool CatDelete()
        {
            connectBetweenModelInterface();
            return CategoryService.categoryDelete(catModel.ID);
        }
        public bool CatDeleteAll()
        {
            connectBetweenModelInterface();
            return CategoryService.categoryDeleteAll();
        }


        public void clearFileds()
        {
            connectBetweenModelInterface();
            icateory.ID =0;
            icateory.CatName = "";
        }

        public void ShowInGridView ()
        {
           icateory.dGVCat = CategoryService.getAllData();

        }

        public void AutoNumber()
        {
            string test = (CategoryService.getMaxID().Rows[0][0]).ToString();
            if (test == null || test == "")
            {
                icateory.ID = 1;
            }
            else
            {
                icateory.ID = Convert.ToInt32(CategoryService.getMaxID().Rows[0][0]) + 1;
            }
            icateory.CatName = "";
            icateory.btnSave = false;
            icateory.btnDelete = false;
            icateory.btnDeleteAll = false;
            icateory.btnAdd = true;
            ShowInGridView();
        }


        public void getRow(int row)
        {
            DataTable tbl = new DataTable();
            tbl = CategoryService.getAllData();

            icateory.ID = Convert.ToInt32(tbl.Rows[row][0]);
            icateory.CatName = Convert.ToString(tbl.Rows[row][1]);

            icateory.btnSave = true;
            icateory.btnDelete = true;
            icateory.btnDeleteAll = true;
            icateory.btnAdd = false;
        }


        public DataTable getLastRow()
        {
            DataTable tbl = new DataTable();
            tbl = CategoryService.getLastRow();


            return tbl;
        }

    }
}
