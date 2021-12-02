namespace DesignPatternsTraining.Decorator
{
    public class DarkRoast : BaseBeverage
    {
        public override double Cost() => 1;

        public override string GetDescription() => "Dark Roast";
    }
}
