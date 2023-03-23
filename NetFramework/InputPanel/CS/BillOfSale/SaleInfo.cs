using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillOfSale
{
    class SaleInfo
    {
        public DateTime DateSold { get; set; }
        public Transactor Seller { get; set; }
        public Transactor Buyer { get; set; }
        public string ItemsInfo { get; set; }
        public int ItemsValue { get; set; }
        public string FormOfPayment { get; set; }
        public SaleInfo(DateTime dateS, Transactor s, Transactor b, string itemsInfo, int itemsValue, string formPayment)
        {
            DateSold = dateS;
            Seller = s;
            Buyer = b;
            ItemsInfo = itemsInfo;
            ItemsValue = itemsValue;
            FormOfPayment = formPayment;
        }

    }
    struct Transactor
    {
        public string PrintedName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string Work { get; set; }
        public DateTime DateSign { get; set; }

        public Transactor(string printName, string adress, string city, string state, string zip,
            string homePhone, string cellPhone, string work, DateTime dateSign)
        {

            PrintedName = printName;
            Address = adress;
            City = city;
            State = state;
            Zip = zip;
            HomePhone = homePhone;
            CellPhone = cellPhone;
            Work = work;
            DateSign = dateSign;
        }

    }
}
