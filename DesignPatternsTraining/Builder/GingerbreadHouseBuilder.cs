using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTraining.Builder
{
    public class GingerbreadHouseBuilder : HouseBuilder
    {
        public GingerbreadHouseBuilder()
        {
            SetHouseType(HouseType.Gingerbread);
        }

        public override HouseBuilder AddWalls()
        {
            for (int i = 0; i < 4; i++)
            {
                House.AddWall(new Wall());
                Console.WriteLine($"Wall no. {i + 1} added");
            }

            return this;
        }

        public override HouseBuilder AddRoof()
        {
            House.AddRoof(new Roof());
            Console.WriteLine("Roof added");

            return this;
        }

        public override House Build()
        {
            Console.WriteLine("Here's your house!");
            return House;
        }

        public override HouseBuilder AddWindows()
        {
            throw new NotImplementedException();
        }
    }
}
