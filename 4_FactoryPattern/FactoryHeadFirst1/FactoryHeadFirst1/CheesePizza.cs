using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst1
{
    class CheesePizza: Pizza
    {
        public CheesePizza()
        {
            name = "Cheese Pizza";
            dough = "Regular Crust";
            sauce = "Marinara Pizza Sauce";
            toppings.Add("Fresh Mozzarella");
            toppings.Add("Parmesan");
        }
    }
}
