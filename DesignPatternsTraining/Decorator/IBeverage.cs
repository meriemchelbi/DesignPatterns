namespace DesignPatternsTraining.Decorator
{
    public interface IBeverage
    {
        string Description { get; set; }

        int Cost();
        string GetDescription();
    }
}