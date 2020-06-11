using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_DesignPatterns.Iterator
{
    public class IteratorDataCollection : IEnumerable
    {
        private readonly bool reverse;
        private List<int> collection;

        public IteratorDataCollection(bool reverse = false)
        {
            collection = Enumerable.Range(1, 10).ToList();
            this.reverse = reverse;
        }

        public IEnumerator GetEnumerator()
        {
            return reverse ? new ReverseIterator(collection) : (IEnumerator)new ForwardIterator(collection);
        }
    }
}
