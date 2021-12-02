using System;

namespace DesignPatternsTraining.Decorator
{
    public static class DecoratorProgramme
    {
        public static void Decorator()
        {
            Console.WriteLine("Decorator pattern...");

            Console.WriteLine("I'd like a Dark Roast Mocha, please.");
            var darkRoast = new DarkRoast();
            var mocha = new Mocha(darkRoast);
            Console.WriteLine($"Here's your {mocha.GetDescription()}. That'll be USD {mocha.Cost()}");

            Console.WriteLine("Oh, and could you please add whip?");
            var whip = new Whip(mocha);
            Console.WriteLine($"Here's your {whip.GetDescription()}. That'll be USD {whip.Cost()}");

        }
    }
}
