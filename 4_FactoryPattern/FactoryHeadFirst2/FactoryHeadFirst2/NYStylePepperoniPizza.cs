using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst2
{
    class NYStylePepperoniPizza: Pizza
    {
        public NYStylePepperoniPizza()
        {
            name = "NY Style Pepperoni Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Sliced Pepperoni");
            toppings.Add("Garlic");
            toppings.Add("Onion");
            toppings.Add("Mushrooms");
            toppings.Add("Red Pepper");
        }
    }
}
