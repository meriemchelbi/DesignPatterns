using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTraining.Decorator
{
    public abstract class Beverage
    {
        public string Description => "Unknown beverage";

        public string GetDescription() => Description;

        public abstract double Cost();
    }
}
