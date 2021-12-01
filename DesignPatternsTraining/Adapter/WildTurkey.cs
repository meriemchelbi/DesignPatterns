using System;

namespace DesignPatternsTraining.Adapter
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("I'm a flying turkey!");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble");
        }
    }
}
