using System;

namespace DesignPatternsTraining.Observer
{
    public static class ObserverProgramme
    {
        public static void Observer()
        {
            // In this instance, the subject is responsible for updating the value on the subject
            // not ideal as this spreads the responsibilities around
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

            // Here's more of a pub/sub model - the observer is notified of an update but chooses when to fetch the data.
            var suspect = new Subject();
            var detective = new Observer("detective", suspect);

            suspect.RegisterObserver(detective);

            suspect.SetValue(500);

            Console.WriteLine($"Detective value {detective.GetValue()}");
            detective.UpdateAsync();
            Console.WriteLine($"Detective value {detective.GetValue()}");
        }
    }
}
