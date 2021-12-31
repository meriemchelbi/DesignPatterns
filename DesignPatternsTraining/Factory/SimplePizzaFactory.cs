using System;

namespace DesignPatternsTraining.Factory
{
    public class SimplePizzaFactory : ISimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Console.WriteLine($"Making new {type} pizza");
            return (type.ToLower()) switch
            {
                "cheese" => new CheesePizza(),
                "pepperoni" => new PepperoniPizza(),
                _ => default,
            };
        }
    }
}
