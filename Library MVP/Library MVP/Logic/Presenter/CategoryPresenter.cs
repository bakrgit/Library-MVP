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

    }
}
