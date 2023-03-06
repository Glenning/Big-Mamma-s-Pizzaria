using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiderman_2_Pizza_Theme
{
    public class Drinks
    {
        private string _drinkName;
        private double _drinkPrice;
        public Drinks()
        {
            _drinkName = "";
            _drinkPrice = 0.0;
        }
        public Drinks(string drinkName, double drinkPrice)
        {
            _drinkName = drinkName;
            _drinkPrice = drinkPrice;
        }
    }
}
