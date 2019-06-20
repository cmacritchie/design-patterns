using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;
        public abstract override string GetDescription();
        public Size getSize()
        {
            return beverage.GetSize();
        }
       
    }
}
