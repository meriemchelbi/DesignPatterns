using System;

namespace DesignPatternsTraining.Ducks
{
    public class DecoyDuck : InflexibleDuck
    {
        // Swimming and quacking behaviour on superclass may not be relevant here
        // the abstraction of inheritance means my subclass's behaviour is difficult to establish on its own

        public override void Quack()
        {
            return;
        }

        public override void Display()
        {
            Console.WriteLine("I look like a decoy");
        }
    }
}
