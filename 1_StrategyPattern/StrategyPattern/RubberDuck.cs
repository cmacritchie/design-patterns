using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class RubberDuck: Duck
    {
        public override void Display()
        {
            Console.WriteLine("I am a rubber duck");
        }

        public RubberDuck()
        {
            flyBehaviour = new NoFly();
            quackBehaviour = new SqueackyQuacks();
        }
    }
}
