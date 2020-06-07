using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Factory
{
    public class ShapeSquare : IShape
    {
        public int Sides { get; set; }
        public int SideLengthTotal { get; set; }
        public string Name { get; set; }

        public void SetValues(int sideLength)
        {
            Sides = 4;
            SideLengthTotal = Sides * sideLength;
            Name = "SQUARE";
        }
        public string GetInfo()
        {
            return $"Name:{Name} Sides:{Sides} SideLengthTotal:{SideLengthTotal}";
        }

    }
}
