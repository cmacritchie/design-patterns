using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst1
{
    class ClamPizza: Pizza
    {
        public ClamPizza()
        {
            name = "clam Pizza";
            dough = "Thin crust";
            sauce = "Wite garlic sauce";
            toppings.Add("Clams");
            toppings.Add("Grated parmesan cheese");
        }
    }
}
