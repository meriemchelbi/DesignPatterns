using System;

namespace DesignPatternsTraining.Ducks
{
    // This is a bit more flexible but if there is shared behaviour there could be a lot of code duplication
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyingBehaviour = new CantFly();
            QuackingBehaviour = new Squeak();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
