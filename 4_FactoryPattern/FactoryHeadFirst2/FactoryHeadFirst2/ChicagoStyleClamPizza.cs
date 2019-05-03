using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst2
{
    class ChicagoStyleClamPizza: Pizza
    {
        public ChicagoStyleClamPizza()
        {
            name = "Chicago Style Clam Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
            toppings.Add("Frozen Clams from Chesapeake Bay");
        }

        void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
