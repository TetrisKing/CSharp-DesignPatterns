namespace CSharp_DesignPatterns.Factory
{
    public interface IShape
    {
        public string Name { get; set; }
        public int Sides { get; set; }
        public int SideLengthTotal { get; set; }

        public void SetValues(int sideLength);
        public string GetInfo();
    }
}