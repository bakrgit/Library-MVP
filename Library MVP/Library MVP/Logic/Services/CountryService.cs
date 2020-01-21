using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Library_MVP.Logic.Services
{
   static class CountryService
    {
        //this methoud to add into country table in DB
        static public  bool countryInsert(int id, string name)
        {
            return DBHelper.excuteData("countryInsert", () => countryParmaterInsert(id, name, DBHelper.command));

        }

        //this methoud to add insert paramter into stord prosedure
        private static void countryParmaterInsert(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }

        //this methoud to update into country table in DB
        static public bool countryUpdate(int id, string name)
        {
            return DBHelper.excuteData("countryUpdate", () => countryParmaterUpdate(id, name, DBHelper.command));

        }

        //this methoud to add update paramter into stord prosedure
        private static void countryParmaterUpdate(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }
        static public bool countryDelete(int id)
        {
            return DBHelper.excuteData("countryDelete", () => countryParmaterDelete(id, DBHelper.command));

        }

        //this methoud to add Delete paramter into stord prosedure
        private static void countryParmaterDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }

        static public bool countryDeleteAll()
        {
            return DBHelper.excuteData("countryDeleteAll", () => countryParmaterDeleteAll());

        }

        //this methoud to add Delete All paramter into stord prosedure
        private static void countryParmaterDeleteAll()
        {
        }


        //this methoud to get all data to show in DGV or return as table
        static public DataTable getAllData()
        {
           return DBHelper.getData("countryGetAll", () => { });
        }

        //this methoud to get last row in table
        static public DataTable getLastRow()
        {
            return DBHelper.getData("countryGetLastRow", () => { });
        }

        //this methoud to get max ID in table
        static public DataTable getMaxID()
        {
            return DBHelper.getData("countryMaxID", () => { });
        }
    }
}
