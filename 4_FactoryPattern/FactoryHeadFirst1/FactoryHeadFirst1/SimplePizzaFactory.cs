using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst1
{
    class SimplePizzaFactory
    {
        public Pizza creatPizza(string type)
        {
            Pizza pizza = null;

            if(type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }
           else if(type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza();
            }
            else if(type.Equals("Treat"))
            {
                pizza = new TreatzaPizza();
            }
            return pizza;
        }

    }
}
