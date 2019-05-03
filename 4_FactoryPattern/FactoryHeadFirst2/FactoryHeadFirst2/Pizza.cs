using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeadFirst2
{
    public abstract class Pizza
    {
        public String name;
        public String dough;
        public String sauce;
        public List<String> toppings = new List<string>();

        public String getName() { return name; }

        public void Prepare() { Console.Write("preparing " + name); }
        public void Bake() { Console.WriteLine("baking " + name); }
        public void Cut() { Console.WriteLine("Cutting " + name); }
        public void Box() { Console.WriteLine("Boxing" + name); }

        public override String ToString()
        {
            string display = "------ " + name + " -------" + Environment.NewLine;
            display += dough + Environment.NewLine;
            display += sauce + Environment.NewLine;
            foreach (String topping in toppings)
            {
                display += topping + Environment.NewLine;
            }
            return display;
        }

    }
}
