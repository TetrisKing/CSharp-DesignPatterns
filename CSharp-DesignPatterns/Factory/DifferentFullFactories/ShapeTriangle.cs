using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Factory
{
    public class ShapeTriangle : IShape
    {
        public int Sides { get; set; }
        public int SideLengthTotal { get; set; }
        public string Name { get; set; }

        public void SetValues(int sideLength)
        {
            Sides = 3;
            SideLengthTotal = Sides * sideLength;
            Name = "TRIANGLE";
        }
        public string GetInfo()
        {
            return $"Name:{Name} Sides:{Sides} SideLengthTotal:{SideLengthTotal}";
        }
    }
}
