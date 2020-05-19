using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Models
{
    class BorrowersModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public string Address { get; set; }

        public string Notes { get; set; }
    }
}
