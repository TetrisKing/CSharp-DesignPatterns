using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Iterator
{
    public class ReverseIterator : IEnumerator
    {
        private readonly List<int> collection;
        int currentPosition;

        public ReverseIterator(List<int> collection)
        {
            this.collection = collection;
            currentPosition = collection.Count;
        }

        public object Current => collection[currentPosition];

        public bool MoveNext()
        {
            if (!HasMore())
                return false;
            currentPosition--;
            return true;
        }

        public void Reset()
        {
            currentPosition = 0;
        }
        public bool HasMore()
        {
            return 0 < currentPosition;
        }
    }
}
