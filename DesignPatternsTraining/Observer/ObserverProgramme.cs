using System;

namespace DesignPatternsTraining.Observer
{
    public static class ObserverProgramme
    {
        public static void Observer()
        {
            Console.WriteLine("Observer pattern...");

            var victim = new Subject();
            var sniper = new Observer("sniper");
            var hawk = new Observer("hawk");

            victim.RegisterObserver(sniper);
            victim.RegisterObserver(hawk);

            victim.SetValue(5);

            victim.UnregisterObserver(sniper);

            victim.SetValue(10);

            victim.UnregisterObserver(hawk);

            victim.SetValue(15);
        }
    }
}
