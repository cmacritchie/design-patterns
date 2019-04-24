using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class SqueackyQuacks: IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeek, Squeek, Chirp");
        }
    }
}
