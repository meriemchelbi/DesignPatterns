using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTraining.Builder
{
    public class BuilderProgramme
    {
        public static void Builder()
        {
            Console.WriteLine("Builder programme");

            var builder = new GingerbreadHouseBuilder();

            var house = builder.AddWalls()
                               .AddRoof()
                               .Build();
        }
    }
}
