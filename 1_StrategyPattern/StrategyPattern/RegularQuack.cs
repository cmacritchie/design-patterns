using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class RegularQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack, Quack, Quack");
        }
    }
}
