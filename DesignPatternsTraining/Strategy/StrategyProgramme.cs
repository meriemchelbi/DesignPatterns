using DesignPatternsTraining.Ducks;
using System;

namespace DesignPatternsTraining.Strategy
{
    public class StrategyProgramme
    {
        public static void Strategy()
        {
            Console.WriteLine("Changing a mallard's behaviour at runtime to stop flying using the Strategy pattern...");

            Console.WriteLine("This is how a Mallard behaves...");
            var mallard = new MallardDuck();
            mallard.Quack();
            mallard.Fly();

            // Change behaviour at runtime
            // Doesn't affect other ducks
            Console.WriteLine("Mallard's new flying behaviour:");
            mallard.SetFlyBehaviour(new CantFly());
            mallard.Fly();
        }
    }
}
