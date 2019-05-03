using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst2
{
   public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(String item);

        public Pizza OrderPizza(String type)
        {
            Pizza pizza = CreatePizza(type);
            Console.WriteLine("--- Making a " + pizza.getName() + " ---");
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }




    }
}
