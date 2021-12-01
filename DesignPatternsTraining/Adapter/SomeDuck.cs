using System;

namespace DesignPatternsTraining.Adapter
{
    public class SomeDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I'm a duck flying!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
