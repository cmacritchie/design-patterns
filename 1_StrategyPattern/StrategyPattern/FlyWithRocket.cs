using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class FlyWithRocket: IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Get he thrusters ready, We're rocket flying");
        }
    }
}
