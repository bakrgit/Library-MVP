using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Logic.Services
{
    class BorrowServices
    {

        //this methoud to get all data to show in Cbx or return as table
        static public DataTable getAllDataBorrow()
        {
            return DBHelper.getData("borrowGetAll", () => { });
        }

        static public DataTable getMaxID()
        {

            return DBHelper.getData("borrowGetMaxID", () => { });
        }
    }
}
