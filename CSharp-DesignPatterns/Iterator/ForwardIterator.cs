using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Iterator
{
    public class ForwardIterator : IEnumerator
    {
        private readonly List<int> collection;
        int currentPosition;

        public ForwardIterator(List<int> collection)
        {
            this.collection = collection;
            currentPosition = 0;
        }

        public object Current => collection[currentPosition];

        public bool MoveNext()
        {
            if (!HasMore())
                return false;
            currentPosition++;
            return true;
        }

        public void Reset()
        {
            currentPosition = 0;
        }
        public bool HasMore()
        {
            return collection.Count - 1 > currentPosition;
        }
    }
}
