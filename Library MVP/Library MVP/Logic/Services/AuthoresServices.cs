using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Logic.Services
{
    class AuthoresServices
    {
        //this methoud to add into authores table in DB
        static public bool authoresInsert(int id, string name , string date , int countryID)
        {
            return DBHelper.excuteData("AuthoresInsert", () => authoresParmaterInsert(id, name,date,countryID, DBHelper.command));

        }

        //this methoud to add insert paramter into stord prosedure
        private static void authoresParmaterInsert(int id, string name ,string date ,int countryID, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
            command.Parameters.Add("@countryID", SqlDbType.Int).Value = countryID;
        }


        //this methoud to update into authores table in DB
        static public bool authoresUpdate(int id, string name, string date, int countryID)
        {
            return DBHelper.excuteData("AuthoresUpdate", () => authoresParmaterUpdate(id, name, date, countryID, DBHelper.command));

        }

        //this methoud to add update paramter into stord prosedure
        private static void authoresParmaterUpdate(int id, string name, string date, int countryID, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
            command.Parameters.Add("@countryID", SqlDbType.Int).Value = countryID;
        }

        //this methoud to get all data to show in Cbx or return as table
        static public DataTable getAllData()
        {
            return DBHelper.getData("countryGetAll", () => { });
        }
        //this methoud to get all data to show in Cbx or return as table
        static public DataTable getAllAuthorData()
        {
            return DBHelper.getData("authorGetAll", () => { });
        }

        //this methoud to get all data to show in Cbx or return as table
        static public DataTable getAllAuthorDataCountryID()
        {
            return DBHelper.getData("authorGetAllCountryID", () => { });
        }
        //this methoud to get last row in table
        static public DataTable getLastRow()
        {
            return DBHelper.getData("authorGetLastRow", () => { });
        }


        //this methoud to get max id from Author Table
        static public DataTable getAuthorMaxID()
        {
            return DBHelper.getData("authorMaxID", () => { });
        }

        static public bool DeleteDeleteAuthor(int iD)
        {

            return DBHelper.excuteData("authorDelete", () => authorsParmaterDelete(iD, DBHelper.command));

        }

        //this methoud to add Delete paramter into stord prosedure
        private static void authorsParmaterDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }


        //this methoud to delete all author in table
        static public bool DeleteAuthorAll()
        {
            return DBHelper.excuteData("authorDeleteAll", () => { });

        }
    }
}
