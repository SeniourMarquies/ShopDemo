using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemo.Classes
{
    public class Vendor
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double Commission { get; set; }
        public decimal PaymentDue { get; set; }

        public string Display
        {
            get
            {
                return string.Format("{0} {1} - ${2}", firstName, lastName, PaymentDue);
            }
        }


        public Vendor()
        {
            Commission = .5;
        }
    }
}
