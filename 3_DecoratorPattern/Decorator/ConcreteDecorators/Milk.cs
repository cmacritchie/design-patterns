using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Condiments
{
    class Milk: CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.description + ", Milk";
        }

        public override double cost()
        {
            return beverage.cost() + .10;
        }
    }
}
