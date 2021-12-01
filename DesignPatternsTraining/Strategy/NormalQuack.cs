using System;

namespace DesignPatternsTraining.Ducks
{
    public class NormalQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
