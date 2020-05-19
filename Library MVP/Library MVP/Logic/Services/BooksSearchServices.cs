using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Logic.Services
{
    class BooksSearchServices
    {
        //this methoud to get all data to show in Cbx or return as table
        static public DataTable getAllBooks()
        {
            return DBHelper.getData("booksGetAll", () => { });
        }

        //this methoud to get all data to show in Cbx or return as table
        static public DataTable getAllBooksByID(int id)
        {
            return DBHelper.getData("booksGetAllByID", () => booksSearchID(id, DBHelper.command));
        }
        

        //this methoud to add insert paramter into stord prosedure
        private static void booksSearchID(int id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }


        //this methoud to get all data to show in Cbx or return as table
        static public DataTable getAllBooksByCat(int catID)
        {
            return DBHelper.getData("booksGetAllByCat", () => booksSearchCat(catID, DBHelper.command));
        }


        //this methoud to add insert paramter into stord prosedure
        private static void booksSearchCat(int catID, SqlCommand command)
        {
            command.Parameters.Add("@catID", SqlDbType.Int).Value = catID;
        }
    }
}
