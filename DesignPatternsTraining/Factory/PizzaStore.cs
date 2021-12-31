namespace DesignPatternsTraining.Factory
{
    public class PizzaStore
    {
        private readonly ISimplePizzaFactory _simplyPizzaFactory;

        public PizzaStore(ISimplePizzaFactory simplyPizzaFactory)
        {
            _simplyPizzaFactory = simplyPizzaFactory;
        }

        public Pizza ProcessPizzaOrder(string type)
        {
            var pizza = _simplyPizzaFactory.CreatePizza(type);
            
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

    }
}
