using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTraining.Decorator
{
    public class DarkRoast : Beverage
    {
        
        public override double Cost()
        {
            return 1;
        }
    }
}
