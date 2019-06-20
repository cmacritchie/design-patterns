using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Condiments
{
    class Whip: CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        public override double cost()
        {
            return beverage.cost() + .10;
        }
    }
}
