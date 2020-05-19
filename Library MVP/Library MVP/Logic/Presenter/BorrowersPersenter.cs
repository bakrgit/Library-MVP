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
    class BorrowersPersenter
    {
        IBorrowers iborrowers;
        BorrowersModel borrowerModel = new BorrowersModel();

        public BorrowersPersenter(IBorrowers view)
        {
            this.iborrowers = view;
        }


        public void AutoNumber()
        {
            string test = (BorrowersServices.getMaxID().Rows[0][0]).ToString();
            if (test == null || test == "")
            {
                iborrowers.ID = 1;
            }
            else
            {
                iborrowers.ID = Convert.ToInt32(BorrowersServices.getMaxID().Rows[0][0]) + 1;
            }
            iborrowers.Name = "";
            iborrowers.Notes = "";
            iborrowers.Phone = "";
            iborrowers.Address = "";
            iborrowers.btnSave = false;
            iborrowers.btnDelete = false;
            iborrowers.btnDeleteAll = false;
            iborrowers.btnAdd = true;
        }
        //connect bewteen model cat and interface cat
        private void connectBetweenModelInterface()
        {
            borrowerModel.ID = iborrowers.ID;
            borrowerModel.Name = iborrowers.Name;
            borrowerModel.Phone = iborrowers.Phone;
            borrowerModel.Address = iborrowers.Address;
            borrowerModel.Notes = iborrowers.Notes;
        }

        public bool BorrowerInsert()
        {
            connectBetweenModelInterface();
            return BorrowersServices.borrowerInsert(borrowerModel.ID, borrowerModel.Name , borrowerModel.Phone, borrowerModel.Address, borrowerModel.Notes);
        }
        public bool BorrowerUpdate()
        {
            connectBetweenModelInterface();
            return BorrowersServices.borrowerUpdate(borrowerModel.ID, borrowerModel.Name, borrowerModel.Phone, borrowerModel.Address, borrowerModel.Notes);
        }

        public bool BorrowerDelete()
        {
            connectBetweenModelInterface();
            return BorrowersServices.borrowerdelete(borrowerModel.ID);
        }

        public bool BorrowerDeleteAll()
        {

            return BorrowersServices.borrowerdeleteAll();
        }


        public void getRow(int row)
        {
            DataTable tbl = new DataTable();
            tbl = BorrowersServices.getAllData();

            iborrowers.ID = Convert.ToInt32(tbl.Rows[row][0]);
            iborrowers.Name = Convert.ToString(tbl.Rows[row][1]);
            iborrowers.Phone = Convert.ToString(tbl.Rows[row][2]);
            iborrowers.Address = Convert.ToString(tbl.Rows[row][3]);
            iborrowers.Notes = Convert.ToString(tbl.Rows[row][4]);


            iborrowers.btnSave = true;
            iborrowers.btnDelete = true;
            iborrowers.btnDeleteAll = true;
            iborrowers.btnAdd = false;
        }


        public DataTable getLastRow()
        {
            DataTable tbl = new DataTable();
            tbl = BorrowersServices.getLastRow();


            return tbl;
        }
    }
}
