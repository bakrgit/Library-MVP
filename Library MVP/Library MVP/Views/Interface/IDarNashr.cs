using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Views.Interface
{
    interface IDarNashr
    {
        int ROW { get; set; }
        int ID { get; set; }
        string DarName { get; set; }
        int CountryID { get; set; }
        object Dgv { get; set; }
        object cbxCountry { get; set; }
        object btnAdd { get; set; }
        object btnNew { get; set; }
        object btnSave { get; set; }
        object btnDelete { get; set; }
        object btnDeleteAll { get; set; }
        string DarDisplayMember { get; set; }
        string DarValueMember { get; set; }
        int selectdIndex { get; set; }
        int selectdValue { get; set; }
    }
}
