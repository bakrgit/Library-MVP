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
    class DarNashrPersenter
    {

        IDarNashr iDarNashr;
        DarNasherModel darModels = new DarNasherModel();

        public DarNashrPersenter(IDarNashr view)
        {
            this.iDarNashr = view;
        }


        //connect bewteen model cat and interface cat
        private void connectBetweenModelInterface()
        {
            darModels.ID = iDarNashr.ID;
            darModels.DarName = iDarNashr.DarName;
            darModels.CountryID = iDarNashr.CountryID;
        }

        //this methoud to connect to services class to insert data in darnashr table
        public bool DarNashrInsert()
        {
            connectBetweenModelInterface();
            return DarNashrService.darInsert(darModels.ID, darModels.DarName, darModels.CountryID);
        }
        //this methoud to connect to services class to update data in authors table
        public bool DarnashrUpdate()
        {
            connectBetweenModelInterface();
            return DarNashrService.darUpdate(darModels.ID, darModels.DarName, darModels.CountryID);
        }

        //this methoud to connect to services class to delete Dar By ID
        public bool DarnashrDeleteID()
        {
            connectBetweenModelInterface();
            return DarNashrService.darDeleteID(darModels.ID);
        }

        //this methoud to connect to services class to delete Dar By ID
        public bool DarnashrDeleteAll()
        {

            return DarNashrService.darDeleteAll();
        }
        public void FillCbx()
        {
            iDarNashr.cbxCountry = DarNashrService.getAllDataCountry();
            iDarNashr.DarDisplayMember = "اسم الدولة";
            iDarNashr.DarValueMember = "رقم الدولة";
        }
        public void AutoNumber()
        {
            string val = Convert.ToString(DarNashrService.getDarMaxID().Rows[0][0]);
            if (val == null || val == "")
            {
                iDarNashr.ID = 1;
            }
            else
            {
                iDarNashr.ID = Convert.ToInt32(DarNashrService.getDarMaxID().Rows[0][0]) + 1;
            }
            iDarNashr.DarName = "";

            iDarNashr.selectdIndex = 0;
            iDarNashr.Dgv = DarNashrService.getAllDarData();


            iDarNashr.btnSave = false;
            iDarNashr.btnDelete = false;
            iDarNashr.btnDeleteAll = false;
            iDarNashr.btnAdd = true;
        }



        public void getRow(int row)
        {
            DataTable tbl = new DataTable();
            tbl.Clear();
            tbl = DarNashrService.getAllDarDataByID();

            iDarNashr.ID = Convert.ToInt32(tbl.Rows[row][0]);
            iDarNashr.DarName = Convert.ToString(tbl.Rows[row][1]);
            iDarNashr.selectdValue = Convert.ToInt32(tbl.Rows[row][2]);

            iDarNashr.btnSave = true;
            iDarNashr.btnDelete = true;
            iDarNashr.btnDeleteAll = true;
            iDarNashr.btnAdd = false;
        }


        public DataTable getLastRow()
        {
            DataTable tbl = new DataTable();
            tbl.Clear();
            tbl = DarNashrService.getLastRow();


            return tbl;
        }
    }
}
