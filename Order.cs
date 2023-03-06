using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiderman_2_Pizza_Theme
{
    public class Order
    {
        public Pizza _pizza;
        public Customer _customer;
        private string _cart;
        private int _orderNumber;
        public Order()
        {
            _cart = "";
        }
        Order(Pizza pizza, Customer customer, int orderNumber)
        {
            _orderNumber = orderNumber;
        }
    }
}
