namespace DesignPatternsTraining.Decorator
{
    public abstract class CondimentDecorator : BaseBeverage
    {
        public BaseBeverage Beverage { get; set; }

        public CondimentDecorator(BaseBeverage beverage)
        {
            Beverage = beverage;
        }
    }
}
