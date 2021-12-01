using System;

namespace DesignPatternsTraining.Ducks
{
    public class Squeak : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
