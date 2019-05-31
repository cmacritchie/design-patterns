using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Decaf: Beverage
    {
        public Decaf()
        {
            description = "Decaf Coffee";
        }

        public override double cost()
        {
            return 1.05;
        }
    }
}
