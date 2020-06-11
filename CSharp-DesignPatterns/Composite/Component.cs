using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Composite
{
    public class CompositeComponent : ICompositeCompenent
    {
        private readonly string name;
        private List<ICompositeCompenent> children = new List<ICompositeCompenent>();
        public CompositeComponent(string name)
        {
            this.name = name;
        }

        public void Add(ICompositeCompenent c)
        {
            children.Add(c);
        }

        public void Remove(ICompositeCompenent c)
        {
            children.Remove(c);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
            foreach (var child in children)
            {
                child.Display(depth+2);
            }
        }
    }
}
