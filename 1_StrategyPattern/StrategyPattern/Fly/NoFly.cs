using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class NoFly: IFlyBehaviour
    {
       public void Fly()
        {
            Console.WriteLine("I cannot Fly");
        }
    }
}
