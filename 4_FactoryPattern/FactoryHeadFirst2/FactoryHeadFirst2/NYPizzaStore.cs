using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst2
{
    class NYPizzaStore: PizzaStore
    {
      

        // override Pizza CreatePizza(String item)
        // {

        //  }

       public override  Pizza CreatePizza(string item)
        {
            if (item.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (item.Equals("veggie"))
            {
                return new NYStyleVeggiePizza();
            }
            else if (item.Equals("clam"))
            {
                return new NYStyleClamPizza();
            }
            else if (item.Equals("pepperoni"))
            {
                return new NYStylePepperoniPizza();
            }
            else return null;
        }
    }
}
