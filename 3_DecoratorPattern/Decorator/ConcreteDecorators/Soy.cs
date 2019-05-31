using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Condiments
{
    class Soy: CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }

        public override double cost()
        {
            double cost = beverage.cost();
            if(beverage.GetSize() == Size.Tall){
                cost += .10;
            } else if(beverage.GetSize() == Size.Grande)
            {
                cost += .15;
            } else if(beverage.GetSize() == Size.Venti)
            {
                cost += .20;
            }

            return cost;
        }
    }
}
