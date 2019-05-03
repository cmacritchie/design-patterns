using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the factory Method");
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);

            Pizza pizza = store.orderPizza("cheese");
            Console.WriteLine("we ordered a " + pizza.getName());
            Console.Write(pizza.ToString());

            pizza = store.orderPizza("clam");
            Console.WriteLine("we ordered a " + pizza.getName());
            Console.Write(pizza.ToString());

            pizza = store.orderPizza("pepperoni");
            Console.WriteLine("we ordered a " + pizza.getName());
            Console.Write(pizza.ToString());
            pizza = store.orderPizza("Treat");
            Console.WriteLine("we ordered a " + pizza.getName());
            Console.Write(pizza.ToString());




            Console.ReadLine();
        }
    }
}
