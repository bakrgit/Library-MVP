using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Views.Interface
{
    interface IBorrow
    {
         int ID { get; set; }
        int ROW { get; set; }
        int BookID { get; set; }
         int BorrowerID { get; set; }

         string StartDate { get; set; }
         string EndDate { get; set; }
         string Notes { get; set; }


        object btnAdd { get; set; }
        object btnNew { get; set; }
        object btnSave { get; set; }
        object btnDelete { get; set; }
        object btnDeleteAll { get; set; }


        object cbxBorrowDatasource { get; set; }
        string BorrowDisplayMember { get; set; }
        string BorrowValueMember { get; set; }
        int selectdIndexBorrow { get; set; }


        object cbxBooksDatasource { get; set; }
        string BookDisplayMember { get; set; }
        string BookValueMember { get; set; }
        int selectdIndexBook { get; set; }

    }
}
