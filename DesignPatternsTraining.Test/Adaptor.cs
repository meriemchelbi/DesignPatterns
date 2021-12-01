using DesignPatternsTraining.Adapter;
using System;
using Xunit;
using Xunit.Abstractions;

namespace DesignPatternsTraining.Test
{
    public class Adaptor
    {
        private readonly ITestOutputHelper _output;

        public Adaptor(ITestOutputHelper testOutputHelper)
        {
            _output = testOutputHelper;
        }

        [Fact]
        public void TestTurkey()
        {
            var duck = new SomeDuck();
            var turkey = new WildTurkey();

            var turkeyAdaptor = new TurkeyToDuckAdaptor(turkey);

            _output.WriteLine("The duck says:");
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
