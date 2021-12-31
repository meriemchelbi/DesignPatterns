using System;

namespace DesignPatternsTraining.Factory
{
    public class Pizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing pizza");
        }
        
        public void Bake()
        {
            Console.WriteLine("Baking pizza");
        }
        
        public void Cut()
        {
            Console.WriteLine("Cutting pizza");
        }
        
        public void Box()
        {
            Console.WriteLine("Boxing pizza");
        }
    }
}
