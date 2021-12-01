using System;

namespace DesignPatternsTraining.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyingBehaviour = new FlyWithWings();
            QuackingBehaviour = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I look like a mallard");
        }
    }
}
