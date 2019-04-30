using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class StrongQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("QUACK... QUACK... QUACK...");
        }
    }
}
