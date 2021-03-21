using _1_Strategy.FlyBehavior;
using _1_Strategy.QuackBehavior;
using System;


namespace _1_Strategy
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
