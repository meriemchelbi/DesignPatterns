using System;

namespace DesignPatternsTraining.Factory
{
    public class FactoryProgramme
    {
        public static void Factory()
        {
            Console.WriteLine("Factory pattern...");

            var factory = new SimplePizzaFactory();
            var store = new PizzaStore(factory);

            store.ProcessPizzaOrder("cheese");
            store.ProcessPizzaOrder("pepperoni");

        }
    }
}
