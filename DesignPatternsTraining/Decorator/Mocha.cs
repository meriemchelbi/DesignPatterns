namespace DesignPatternsTraining.Decorator
{
    public class Mocha : CondimentDecorator
    {

        public Mocha(BaseBeverage beverage) : base(beverage)
        {
        }

        public override double Cost() => Beverage.Cost() + 2;

        public override string GetDescription() => $"{Beverage.GetDescription()} Mocha";
    }
}
