namespace DesignPatternsTraining.Factory
{
    public interface ISimplePizzaFactory
    {
        Pizza CreatePizza(string type);
    }
}