using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTraining.Builder
{
    public abstract class HouseBuilder
    {
        public readonly House House = new House();

        public HouseBuilder()
        {
        }

        public void SetHouseType(HouseType houseType)
        {
            Console.WriteLine($"Building house of type {houseType}");
            House.HouseType = houseType;
        }

        public abstract HouseBuilder AddWalls();
        public abstract HouseBuilder AddWindows();
        public abstract HouseBuilder AddRoof();
        public abstract House Build();
    }
}
