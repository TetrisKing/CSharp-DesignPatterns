namespace CSharp_DesignPatterns.Factory
{
    internal class ShapeNull : IShape
    {
        public int Sides { get; set; }
        public int SideLengthTotal { get; set; }
        public string Name { get; set; }

        public void SetValues(int sideLength = 0)
        {
            Sides = 0;
            SideLengthTotal = sideLength;
            Name = "NULLNAME";
        }
        public string GetInfo()
        {
            return $"Name:{Name} Sides:{Sides} SideLengthTotal:{SideLengthTotal}";
        }
    }
}