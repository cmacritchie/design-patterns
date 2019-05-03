using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst2
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.getName());
            Console.WriteLine(pizza.ToString());

            pizza = nyStore.OrderPizza("pepperoni");
            Console.WriteLine("Dwayne ordered a " + pizza.getName());
            Console.WriteLine(pizza.ToString());

            pizza = nyStore.OrderPizza("clam");
            Console.WriteLine("Ethan ordered a " + pizza.getName());
            Console.WriteLine(pizza.ToString());

            pizza = nyStore.OrderPizza("veggie");
            Console.WriteLine("Ethan ordered a " + pizza.getName());
            Console.WriteLine(pizza.ToString());

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.getName());
            Console.WriteLine(pizza.ToString());

            pizza = chicagoStore.OrderPizza("veggie");
            Console.WriteLine("Ethan ordered a " + pizza.getName());
            Console.WriteLine(pizza.ToString());

            pizza = chicagoStore.OrderPizza("pepperoni");
            Console.WriteLine("Ethan ordered a " + pizza.getName());
            Console.WriteLine(pizza.ToString());

            pizza = chicagoStore.OrderPizza("clam");
            Console.WriteLine("Ethan ordered a " + pizza.getName());
            Console.WriteLine(pizza.ToString());

            Console.ReadLine();

        }
    }
}
