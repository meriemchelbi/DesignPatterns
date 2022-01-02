using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTraining.Builder
{
    public class House
    {
        public string Name;
        public HouseType HouseType;
        public Roof Roof;
        public List<Wall> Walls;
        public List<Window> Windows;

        public House()
        {
            Walls = new List<Wall>();
            Windows = new List<Window>();
        }

        public House AddRoof(Roof roof)
        {
            Roof = roof;
            return this;
        }
        
        public House AddWall(Wall wall)
        {
            Walls.Add(wall);
            return this;
        }
    }
}
