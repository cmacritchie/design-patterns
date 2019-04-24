using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehaviour = new RegularQuack();
            flyBehaviour = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I am a mallard Duck");
        }
    }
}
