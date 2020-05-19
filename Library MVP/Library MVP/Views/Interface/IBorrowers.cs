using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Views.Interface
{
    interface IBorrowers
    {
         int ID { get; set; }
         int row { get; set; }
         string Name { get; set; }
         string Phone { get; set; }

         string Address { get; set; }

         string Notes { get; set; }


        object btnAdd { get; set; }
        object btnNew { get; set; }
        object btnSave { get; set; }
        object btnDelete { get; set; }
        object btnDeleteAll { get; set; }



    }
}
