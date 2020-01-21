using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Views.Interface
{
    interface IAuthors
    {
        int ID { get; set; }
        string AuthorName { get; set; }
        string AuthorDate { get; set; }
        int CountryID { get; set; }
        object Dgv { get; set; }
        object cbxCountry { get; set; }
        object btnAdd { get; set; }
        object btnNew { get; set; }
        object btnSave { get; set; }
        object btnDelete { get; set; }
        object btnDeleteAll { get; set; }
        string AuthorDisplayMember { get; set; }
        string AuthorValueMember { get; set; }
        int selectdIndex { get; set; }
    }
}
