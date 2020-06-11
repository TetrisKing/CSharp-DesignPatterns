using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_DesignPatterns.Composite
{
    public class Leaf : ICompositeCompenent
    {
        private readonly string name;

        public Leaf(string name)
        {
            this.name = name;
        }

        public void Add(ICompositeCompenent c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public void Remove(ICompositeCompenent c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
