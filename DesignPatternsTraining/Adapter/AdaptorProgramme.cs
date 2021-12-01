using System;

namespace DesignPatternsTraining.Adapter
{
    public static class AdaptorProgramme
    {
        public static void Adaptor()
        {
            Console.WriteLine("Adapting a turkey to behave like a duck...");

            var duck = new SomeDuck();
            var turkey = new WildTurkey();

            var turkeyAdaptor = new TurkeyToDuckAdaptor(turkey);

            Console.WriteLine("The duck says:");
            TestDuck(duck);

            Console.WriteLine("The Turkey-adapted duck says:");
            TestDuck(turkeyAdaptor);
        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
