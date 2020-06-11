using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Composite
{
    public interface ICompositeCompenent
    {

        public void Add(ICompositeCompenent c);
        public void Remove(ICompositeCompenent c);
        public void Display(int depth);
    }
}
