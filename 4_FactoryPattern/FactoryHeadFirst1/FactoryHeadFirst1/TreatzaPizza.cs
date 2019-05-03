using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst1
{
    class TreatzaPizza: Pizza
    {
        public TreatzaPizza()
        {
            name = "treatza Pizza";
            dough = "Cookies";
            sauce = "chocolate sauce";
            toppings.Add("Ice Crea");
            toppings.Add("Chocolate Mousse");
        }
    }
}
