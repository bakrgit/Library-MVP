using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Views.Interface
{
   public interface ICountry
    {
        int ID { get; set; }
        int row { get; set; }
        string CountryName { get; set; }
        object dataGridView { get; set; }
        object btnAdd { get; set; }
        object btnNew { get; set; }
        object btnSave { get; set; }
        object btnDelete { get; set; }
        object btnDeleteAll { get; set; }
    }
}
