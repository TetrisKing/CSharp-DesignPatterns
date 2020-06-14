using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Iterator
{
    public interface IIterator 
    {
        int getNext();
        bool hasMore();
    }
}
