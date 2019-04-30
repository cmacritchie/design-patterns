using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public IFlyBehaviour flyBehaviour;
        public IQuackBehaviour quackBehaviour;

        public Duck()
        {

        }

        public void performFly()
        {
            flyBehaviour.Fly();
        }

        public void setFlyBehaviour(IFlyBehaviour fb)
        {
            flyBehaviour = fb;
        }

        public void setQuackBehaviour(IQuackBehaviour qb)
        {
            quackBehaviour = qb;
        }

        public void performQuack()
        {
            quackBehaviour.Quack();
        }

        public abstract void Display();

        public void swim()
        {
            Console.WriteLine("Ducks can swim no matter what");
        }
    }
}
