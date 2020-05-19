using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Logic.Services
{
    class BooksDataService
    {

        //this methoud to get all data to show in Cbx or return as table
        static public DataTable getAllDarNashrData()
        {
            return DBHelper.getData("DarNashrGetAll", () => { });
        }

        //this methoud to get all data to show in Cbx or return as table
        static public DataTable getAllCountryData()
        {
            return DBHelper.getData("countryGetAll", () => { });
        }

        //this methoud to get all data to show in Cbx or return as table
        static public DataTable getAllCategory()
        {
            return DBHelper.getData("categoryGetAll", () => { });
        }


        //this methoud to get all data to show in Cbx or return as table
        static public DataTable getAllBookPlace()
        {
            return DBHelper.getData("bookPlaceGetAll", () => { });
        }
        //this methoud to get all data to show in Cbx or return as table
        static public DataTable getAllAuthore()
        {
            return DBHelper.getData("authorGetAll", () => { });
        }

        //this methoud to get all data to show in Cbx or return as table
        static public DataTable getAllBooks()
        {
            return DBHelper.getData("booksDataGetAll", () => { });
        }

        //this methoud to get all data to show in Cbx or return as table
        static public DataTable getMaxBookID()
        {
            return DBHelper.getData("booksMaxID", () => { });
        }


        //this methoud to add into bookData table in DB
        static public bool bookDataInsert(int id, string name, int cat_ID, int author_ID, int country_ID, int darNashr_ID, string sub_Cat, string date, int page_number, int place_ID, string book_Statu, decimal book_Price, string notes)
        {
            return DBHelper.excuteData("bookDataInsert", () => bookDataParmaterInsert(id, name, cat_ID, author_ID, country_ID, darNashr_ID, sub_Cat,  date,  page_number,  place_ID,  book_Statu,  book_Price,  notes, DBHelper.command));

        }

        //this methoud to add insert paramter into stord prosedure
        private static void bookDataParmaterInsert(int id, string name, int cat_ID, int author_ID, int country_ID,int darNashr_ID,string sub_Cat ,string date ,int page_number ,int place_ID ,string book_Statu  ,decimal book_Price ,string notes, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@book_name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@cat_ID", SqlDbType.Int).Value = cat_ID;
            command.Parameters.Add("@author_ID", SqlDbType.Int).Value = author_ID;
            command.Parameters.Add("@country_ID", SqlDbType.Int).Value = country_ID;
            command.Parameters.Add("@dar_NashrID", SqlDbType.Int).Value = darNashr_ID;
            command.Parameters.Add("@sub_Cat", SqlDbType.NVarChar).Value = sub_Cat;
            command.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
            command.Parameters.Add("@page_Number", SqlDbType.Int).Value = page_number;
            command.Parameters.Add("@place_ID", SqlDbType.Int).Value = place_ID;
            command.Parameters.Add("@book_Statu", SqlDbType.NVarChar).Value = book_Statu;
            command.Parameters.Add("@book_Price", SqlDbType.Real).Value = book_Price;
            command.Parameters.Add("@notes", SqlDbType.NVarChar).Value = notes;
        }


        //this methoud to add into bookData table in DB
        static public bool bookDataUpdate(int id, string name, int cat_ID, int author_ID, int country_ID, int darNashr_ID, string sub_Cat, string date, int page_number, int place_ID, string book_Statu, decimal book_Price, string notes)
        {
            return DBHelper.excuteData("bookDataUpdate", () => bookDataParmaterUpdate(id, name, cat_ID, author_ID, country_ID, darNashr_ID, sub_Cat, date, page_number, place_ID, book_Statu, book_Price, notes, DBHelper.command));

        }

        //this methoud to add insert paramter into stord prosedure
        private static void bookDataParmaterUpdate(int id, string name, int cat_ID, int author_ID, int country_ID, int darNashr_ID, string sub_Cat, string date, int page_number, int place_ID, string book_Statu, decimal book_Price, string notes, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@book_name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@cat_ID", SqlDbType.Int).Value = cat_ID;
            command.Parameters.Add("@author_ID", SqlDbType.Int).Value = author_ID;
            command.Parameters.Add("@country_ID", SqlDbType.Int).Value = country_ID;
            command.Parameters.Add("@dar_NashrID", SqlDbType.Int).Value = darNashr_ID;
            command.Parameters.Add("@sub_Cat", SqlDbType.NVarChar).Value = sub_Cat;
            command.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
            command.Parameters.Add("@page_Number", SqlDbType.Int).Value = page_number;
            command.Parameters.Add("@place_ID", SqlDbType.Int).Value = place_ID;
            command.Parameters.Add("@book_Statu", SqlDbType.NVarChar).Value = book_Statu;
            command.Parameters.Add("@book_Price", SqlDbType.Real).Value = book_Price;
            command.Parameters.Add("@notes", SqlDbType.NVarChar).Value = notes;
        }
        static public bool DeleteBookData(int iD)
        {

            return DBHelper.excuteData("bookDelete", () => bookDataParmaterDelete(iD, DBHelper.command));

        }

        //this methoud to add Delete paramter into stord prosedure
        private static void bookDataParmaterDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }



        static public bool DeleteBookDataAll()
        {

            return DBHelper.excuteData("bookDeleteAll", () => { });

        }

        internal static DataTable getAllbookDataDataID()
        {
            return DBHelper.getData("bookDataGetAllID", () => { });
        }

        //this methoud to get last row in table
        static public DataTable getLastRow()
        {
            return DBHelper.getData("bookDataGetLastRow", () => { });
        }
    }
}
