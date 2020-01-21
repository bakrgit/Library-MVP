using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Models
{
    class AuthorsModel
    {
        public int ID { get; set; }
        public string AuthorName { get; set; }
        public string AuthorDate { get; set; }

        public int CountryID { get; set; }
    }
}
