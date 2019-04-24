using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I am flying with wings");
        }
    }
}
