using DesignPatternsTraining.Adapter;
using System;

namespace DesignPatternsTraining.Ducks
{
    public abstract class Duck : IFly, IQuack, IDuck
    {
        // This composition allows us to minimise code duplication, increase flexibility and dynamically change behaviour
        public IFly FlyingBehaviour { get; set; }
        public IQuack QuackingBehaviour { get; set; }

        public void Swim()
        {
            Console.WriteLine("Swimming...");
        }

        public abstract void Display();

        public void Quack()
        {
            QuackingBehaviour.Quack();
        }

        // delegation - delegate behaviour to a different class
        public void Fly()
        {
            FlyingBehaviour.Fly();
        }
        
        // for setting behaviour at runtime.
        public void SetFlyBehaviour(IFly flyBehaviour)
        {
            FlyingBehaviour = flyBehaviour;
        }
    }
}
