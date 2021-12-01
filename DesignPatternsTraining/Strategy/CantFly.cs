using System;

namespace DesignPatternsTraining.Ducks
{
    public class CantFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
