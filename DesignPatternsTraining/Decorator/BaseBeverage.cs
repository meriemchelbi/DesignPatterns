namespace DesignPatternsTraining.Decorator
{
    public abstract class BaseBeverage
    {
        private string Description => "Unknown Beverage";

        public virtual string GetDescription() => Description;

        public abstract double Cost();
    }
}
