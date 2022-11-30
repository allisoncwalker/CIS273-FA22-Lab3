using System;
using System.Collections;
using System.Collections.Generic;

namespace Set
{
    public class Set<T> : ISet<T>
    {
        public int Size => throw new NotImplementedException();

        public List<T> Elements => throw new NotImplementedException();

        public void Add(ISet<T> s)
        {
            throw new NotImplementedException();
        }

        public void Add(T value)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T value)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Remove(ISet<T> s)
        {
            throw new NotImplementedException();
        }

        public void Remove(T value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public static Set<T> Union(ISet<T> set1, ISet<T> set2)
        {
            return null;
        }

        public static Set<T> Intersection(ISet<T> set1, ISet<T> set2)
        {
            return null;
        }
    }
}
