using System;

namespace DesignPatternsTraining.Ducks
{
    public abstract class InflexibleDuck
    {
        // Issue with this class design is that if we have a decoy duck that doesn't swim, or fly, then some of these methods don't hold true
        // Forced to implement functions we don't need
        // Changes to the super class can affect other ducks
        
        // Had to make void because need to be able to override it -
        // change to the superclass when I find out my original design does't extend well 
        public virtual void Quack()
        {
            Console.WriteLine("Quack!");
        }

        public void Swim()
        {
            Console.WriteLine("Swimming...");
        }

        public abstract void Display();
    }
}
