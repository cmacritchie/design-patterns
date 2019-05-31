using System;
using Decorator.Condiments;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage1 = new Espresso();
            Console.WriteLine("{0} costs {1}$", beverage1.GetDescription(), beverage1.cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Milk(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            beverage2.GetDescription();
            Console.WriteLine("{0} costs {1}$", beverage2.GetDescription(), beverage2.cost());

            Beverage beverage3 = new Decaf();
            beverage3.setSize(Beverage.Size.Venti);
            beverage3 = new Soy(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine("{0} costs {1}$", beverage3.GetDescription(), beverage3.cost());

            Console.ReadLine();
        }
    }
}
