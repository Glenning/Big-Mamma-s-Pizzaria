using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiderman_2_Pizza_Theme
{
    public class Store
    {
        private string _name;
        private string _address;
        private string _email;
        public void Start();
        {
            Pizza p1 = new Pizza("Hawaii", 40);
            Pizza p2 = new Pizza("Diavolo", 50);
            Pizza p3 = new Pizza("Margherita", 35);

            Customer c1 = new Customer("Bente");
            Customer c2 = new Customer("Thea");
            Customer c3 = new Customer("John");

            Order o1 = new Order();
            Order o2 = new Order();
            Order o3 = new Order();
        }
    }
}