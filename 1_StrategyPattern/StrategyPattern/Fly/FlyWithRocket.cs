using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class FlyWithRocket: IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Thrusters ready, We have lift off!");
        }
    }
}
