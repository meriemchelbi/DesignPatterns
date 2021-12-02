namespace DesignPatternsTraining.Decorator
{
    public class Whip : CondimentDecorator
    {
        public Whip(BaseBeverage beverage) : base(beverage)
        {
        }

        public override double Cost() => Beverage.Cost() + 1.5;

        public override string GetDescription() => $"{Beverage.GetDescription()} Whip";
    }
}
