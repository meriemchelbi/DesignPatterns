using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTraining.Decorator
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double Cost()
        {
            return Beverage.Cost() + 2;
        }

        public override string GetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
