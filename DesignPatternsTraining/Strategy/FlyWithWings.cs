using System;

namespace DesignPatternsTraining.Ducks
{
    public class FlyWithWings : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I fly with wings");
        }
    }
}
