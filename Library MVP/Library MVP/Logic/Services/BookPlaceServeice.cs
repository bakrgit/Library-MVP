using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Logic.Services
{
    class BookPlaceServeice
    {
        public static bool bookPlaceInsert(int id, string name)
        {
            return DBHelper.excuteData("bookPlaceInsert", () => bookPlaceParmaterInsert(id, name, DBHelper.command));

        }

        //this methoud to add insert paramter into stord prosedure
        private static void bookPlaceParmaterInsert(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }


        public static bool bookPlaceUpdate(int id, string name)
        {
            return DBHelper.excuteData("bookPlaceUpdate", () => bookPlaceParmaterUpdate(id, name, DBHelper.command));

        }

        //this methoud to update paramter into stord prosedure
        private static void bookPlaceParmaterUpdate(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }


        public static bool bookPlaceDeleteAll()
        {
            return DBHelper.excuteData("bookPlaceDeleteAll", () => { });

        }



        public static bool bookPlaceDelete(int id)
        {
            return DBHelper.excuteData("bookPlaceDelete", () => bookPlaceParmaterDelete(id, DBHelper.command));

        }

        //this methoud to delete paramter into stord prosedure
        private static void bookPlaceParmaterDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

        }


        //this methoud to get all data to show in DGV or return as table
        static public DataTable getAllData()
        {
            return DBHelper.getData("bookPlaceGetAll", () => { });
        }


        static public DataTable getMaxID()
        {
            return DBHelper.getData("bookPlaceMaxID", () => { });
        }


        //this methoud to get last row in table
        static public DataTable getLastRow()
        {
            return DBHelper.getData("bookPlaceGetLastRow", () => { });
        }
    }
}
