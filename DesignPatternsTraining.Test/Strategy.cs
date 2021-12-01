using DesignPatternsTraining.Ducks;
using Xunit;

namespace DesignPatterns.Test
{
    public class Strategy
    {
        [Fact]
        public void Test1()
        {
            var mallard = new MallardDuck();
            mallard.Quack();
            mallard.Fly();

            // Change behaviour at runtime
            // Doesn't affect other ducks
            mallard.SetFlyBehaviour(new CantFly());
            mallard.Fly();
        }
    }
}
