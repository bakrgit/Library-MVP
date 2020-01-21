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
    class CountryPresenter
    {

        ICountry icountry;
        CountryModel countryModel = new CountryModel();

        public CountryPresenter(ICountry view)
        {
            this.icountry = view;
        }


        //connect bewteen model cat and interface cat
        private void connectBetweenModelInterface()
        {
            countryModel.ID = icountry.ID;
            countryModel.CountryName = icountry.CountryName;
        }


        public bool countInsert()
        {
            connectBetweenModelInterface();
            bool check =  CountryService.countryInsert(countryModel.ID, countryModel.CountryName);
            getAllData();
            AutoNumber();
            return check;
        }

        public bool countDelete()
        {
            connectBetweenModelInterface();
            bool check = CountryService.countryDelete(countryModel.ID);
            getAllData();
            AutoNumber();
            return check;
        }

        public bool countDeleteAll()
        {
            connectBetweenModelInterface();
            bool check = CountryService.countryDeleteAll();
            getAllData();
            AutoNumber();
            return check;
        }

        public bool countUpdate()
        {
            connectBetweenModelInterface();
            bool check = CountryService.countryUpdate(countryModel.ID, countryModel.CountryName);
            getAllData();
            AutoNumber();
            return check;
        }



        public void clearFiled()
        {
            icountry.ID = 0;
            icountry.CountryName = "";
        }

        public void getAllData()
        {
            //connectBetweenModelInterface();

            icountry.dataGridView = CountryService.getAllData();
            clearFiled();
        }
        public void AutoNumber()
        {
            string test = (CountryService.getMaxID().Rows[0][0]).ToString();
            if (test == null || test == "")
            {
                icountry.ID = 1;
            }
            else
            {
                icountry.ID = Convert.ToInt32(CountryService.getMaxID().Rows[0][0]) + 1;
            }
            icountry.CountryName = "";
            icountry.btnSave = false;
            icountry.btnDelete = false;
            icountry.btnDeleteAll = false;
            icountry.btnAdd = true;

        }


        public void getRow(int row)
        {
            DataTable tbl = new DataTable();
            tbl =CountryService.getAllData();

            icountry.ID =Convert.ToInt32( tbl.Rows[row][0]);
            icountry.CountryName = Convert.ToString(tbl.Rows[row][1]);

            icountry.btnSave = true;
            icountry.btnDelete = true;
            icountry.btnDeleteAll = true;
            icountry.btnAdd = false;
        }


        public DataTable  getLastRow()
        {
            DataTable tbl = new DataTable();
            tbl = CountryService.getLastRow();


            return tbl;
        }
    }
}
