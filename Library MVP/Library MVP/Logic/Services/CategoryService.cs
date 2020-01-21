using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Library_MVP.Logic.Services
{
    static class CategoryService
    {
        public static bool categoryInsert(int id ,string name)
        {
           return DBHelper.excuteData("categoryInsert", () => categoryParmaterInsert(id, name, DBHelper.command));
            
        }

        //this methoud to add insert paramter into stord prosedure
        private static void categoryParmaterInsert(int id ,string name ,SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }


        public static bool categoryDelete(int id)
        {
            return DBHelper.excuteData("categoryDelete", () => categoryParmaterDelete(id, DBHelper.command));
             
        }
        //this methoud to delete  paramter into stord prosedure
        private static void categoryParmaterDelete(int id,  SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        public static bool categoryUpdate(int id ,string name)
        {
            return DBHelper.excuteData("categoryUpdate", () => categoryParmaterUpdate(id, name, DBHelper.command));
             
        }

        //this methoud to update  paramter into stord prosedure
        private static void categoryParmaterUpdate(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }


        public static bool categoryDeleteAll()
        {
            return DBHelper.excuteData("categoryDeleteAll", () => categoryParmaterDeleteAll());

        }
        //this methoud to delete All  paramter into stord prosedure
        private static void categoryParmaterDeleteAll()
        {

        }


        //this methoud to get all data to show in DGV or return as table
        static public DataTable getAllData()
        {
            return DBHelper.getData("categoryGetAll", () => { });
        }
        //this methoud to get max ID in table
        static public DataTable getMaxID()
        {
            return DBHelper.getData("categoryMaxID", () => { });
        }
        //this methoud to get last row in table
        static public DataTable getLastRow()
        {
            return DBHelper.getData("categoryGetLastRow", () => { });
        }
    }
}
