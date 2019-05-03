using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst1
{
    class PepperoniPizza: Pizza
    {
        public PepperoniPizza()
        {
            name = "pepperoni pizza";
            dough = "thick stuffed Crust";
            sauce = "Marinara Sauce... lots of it";
            toppings.Add("Pepperoni");
            toppings.Add("Extra Cheese!");
        }
    }
}
