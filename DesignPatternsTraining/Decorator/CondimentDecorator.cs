using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTraining.Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage Beverage { get; set; }

        public CondimentDecorator(Beverage beverage)
        {
            Beverage = beverage;
        }

        public new abstract string GetDescription();
        public override abstract double Cost();
    }
}
