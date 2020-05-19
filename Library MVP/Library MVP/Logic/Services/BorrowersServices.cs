using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Logic.Services
{
    class BorrowersServices
    {

        static public DataTable getMaxID()
        {
            return DBHelper.getData("borrowersMaxID", () => { });
        }


        public static bool borrowerInsert(int id, string name, string phone, string address, string notes)
        {
            return DBHelper.excuteData("borrowerInsert", () => borrowerParmaterInsert(id, name ,phone,address,notes, DBHelper.command));

        }

        //this methoud to add insert paramter into stord prosedure
        private static void borrowerParmaterInsert(int id, string name ,string phone ,string address,string notes, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@notes", SqlDbType.NVarChar).Value = notes;
        }


        public static bool borrowerUpdate(int id, string name, string phone, string address, string notes)
        {
            return DBHelper.excuteData("borrowerUpdate", () => borrowerParmaterUpdate(id, name, phone, address, notes, DBHelper.command));

        }

        //this methoud to add insert paramter into stord prosedure
        private static void borrowerParmaterUpdate(int id, string name, string phone, string address, string notes, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@notes", SqlDbType.NVarChar).Value = notes;
        }



        public static bool borrowerdelete(int id)
        {
            return DBHelper.excuteData("borroweDelete", () => borrowerParmaterdelete(id, DBHelper.command));

        }

        //this methoud to add insert paramter into stord prosedure
        private static void borrowerParmaterdelete(int id ,SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }

        

        public static bool borrowerdeleteAll()
        {
            return DBHelper.excuteData("borroweDeleteAll", () => { });

        }

        public static DataTable getAllData()
        { 

            return DBHelper.getData("borrowerGetAll", () => { });
        }

        static public DataTable getLastRow()
        {
            return DBHelper.getData("borrowersGetLastRow", () => { });
        }
    }
}
