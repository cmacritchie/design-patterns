using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst2
{
    class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(String item)
        {
            if (item.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (item.Equals("veggie"))
            {
                return new ChicagoStyleVeggiePizza();
            }
            else if (item.Equals("clam"))
            {
                return new ChicagoStyleClamPizza();
            }
            else if (item.Equals("pepperoni"))
            {
                return new ChicagoStylePepperoniPizza();
            }
            else return null;
        }
    }
}
