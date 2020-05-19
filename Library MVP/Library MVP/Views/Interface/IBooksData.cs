using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Views.Interface
{
    interface IBooksData
    {
        int ROW { get; set; }
        int ID { get; set; }
        string BookName { get; set; }
        int CatID { get; set; }
        int AuthorID { get; set; }
        int CountryID { get; set; }
        int DarID { get; set; }
        string SubCat { get; set; }
        string Date { get; set; }
        int PageNumbers { get; set; }
        int PlcaeID { get; set; }
        string BookStatu { get; set; }
        decimal BookPrice { get; set; }
        string Notes { get; set; }
        //this variables to store cbxDataSource Properties
        object cbxCountry { get; set; }
        object cbxCat { get; set; }
        object cbxPlace { get; set; }
        object cbxDarNashr{ get; set; }
        object cbxBooks { get; set; }
        object cbxAuthores { get; set; }

        //this variables to store DisplayMember and Value Member in cbx
        string cbxCountryDisplayMember  { get; set; }
        string cbxCountryValueMember { get; set; }
        string cbxCatDisplayMember { get; set; }
        string cbxCatValueMember { get; set; }
        string cbxPlaceDisplayMember { get; set; }
        string cbxPlaceValueMember { get; set; }
        string cbxDarNashrDisplayMember { get; set; }
        string cbxDarNashrValueMember { get; set; }
        string cbxBooksDisplayMember { get; set; }
        string cbxBooksValueMember { get; set; }
        string cbxAuthoresValueMember { get; set; }
        string cbxAuthoresDisplayMember { get; set; }
        //this variables to store selected value and selected index in cbx 
        int cbxCountryselectdIndex  { get; set; }
        int cbxCountryselectdValue { get; set; }
        int cbxCatselectdIndex { get; set; }
        int cbxCatselectdValue { get; set; }
        int cbxPlaceselectdIndex { get; set; }
        int cbxPlaceselectdValue { get; set; }
        int cbxDarNashrselectdIndex { get; set; }
        int cbxDarNashrselectdValue { get; set; }
        int cbxBooksselectdIndex { get; set; }
        int cbxBooksselectdValue { get; set; }


        bool btnAdd { get; set; }
        bool btnNew { get; set; }
        bool btnSave { get; set; }
        bool btnDelete { get; set; }
        bool btnDeleteAll { get; set; }
       
    }
}
