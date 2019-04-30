using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            RubberDuck rubber = new RubberDuck();
            Duck rubberDucky = new RubberDuck();

            mallard.performFly();
            mallard.performQuack();
            mallard.swim();
            mallard.Display();

            rubber.performFly();
            rubber.performQuack();
            rubber.swim();
            rubber.Display();
            rubber.setFlyBehaviour(new FlyWithWings());
            rubber.performFly();

            mallard.setFlyBehaviour(new FlyWithRocket());
            mallard.performFly();
            mallard.setQuackBehaviour(new StrongQuack());
            mallard.performQuack();

            rubberDucky.setFlyBehaviour(new FlyWithRocket());
            rubberDucky.performQuack();

            Console.ReadLine();
        }
    }
}
