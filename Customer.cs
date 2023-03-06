using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiderman_2_Pizza_Theme
{
    public class Customer
    {
        private string _customerName;
        public Customer(string customerName)
        {
            _customerName = customerName;
        }
        public string CustomerName
        { 
            get { return _customerName; }
        }
    }
}
