using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Views.Interface
{
    interface IBooksSearch
    {
        object dGVSearch { get; set; }
        int bookID { get; set; }
        int catID { get; set; }
        object cbxBooks { get; set; }

        string cbxBooksDisplayMember { get; set; }
        string cbxBooksValueMember { get; set; }


        object cbxCat{ get; set; }
        string cbxCatDisplayMember { get; set; }
        string cbxCatValueMember { get; set; }
    }
}
