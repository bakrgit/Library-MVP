using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Logic.Services
{
    class DarNashrService
    {
        //this methoud to add into darnashr table in DB
        static public bool darInsert(int id, string name, int countryID)
        {
            return DBHelper.excuteData("DarNashrInsert", () => darParmaterInsert(id, name, countryID, DBHelper.command));

        }

        //this methoud to add insert paramter into stord prosedure
        private static void darParmaterInsert(int id, string name, int countryID, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@countryID", SqlDbType.Int).Value = countryID;
        }


        //this methoud to update into darnashr table in DB
        static public bool darUpdate(int id, string name, int countryID)
        {
            return DBHelper.excuteData("DarnashrUpdate", () => darParmaterUpdate(id, name, countryID, DBHelper.command));

        }

        //this methoud to add update paramter into stord prosedure
        private static void darParmaterUpdate(int id, string name, int countryID, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@countryID", SqlDbType.Int).Value = countryID;
        }

        //this methoud to get all data to show in Cbx or return as table
        static public DataTable getAllDataCountry()
        {
            return DBHelper.getData("countryGetAll", () => { });
        }
       


        //this methoud to delete into darnashr table in DB
        static public bool darDeleteID(int id)
        {
            return DBHelper.excuteData("DarnashrDelete", () => darDeleteIDParmater(id, DBHelper.command));

        }

        //this methoud to add update paramter into stord prosedure
        private static void darDeleteIDParmater(int id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }

        //this methoud to delete All into darnashr table in DB
        static public bool darDeleteAll()
        {
            return DBHelper.excuteData("DarnashrDeleteAll", () => { });

        }


        //this methoud to get max id from Dar Table
        static public DataTable getDarMaxID()
        {
            return DBHelper.getData("DarnashrMaxID", () => { });
        }


        //this methoud to get last row in table
        static public DataTable getLastRow()
        {
            return DBHelper.getData("darNashrauthorGetLastRow", () => { });
        }
        //this methoud to get all data to show in Cbx or return as table
        static public DataTable getAllDarData()
        {
            return DBHelper.getData("DarNashrGetAll", () => { });
        }

        //this methoud to get all data to show in Cbx or return as table
        static public DataTable getAllDarDataByID()
        {
            return DBHelper.getData("DarNashrGetAllID", () => { });
        }
    }
}
