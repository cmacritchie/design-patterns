using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Condiments
{
    class Mocha: CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override double cost()
        {
            return beverage.cost() + .20;
        }
    }
}
