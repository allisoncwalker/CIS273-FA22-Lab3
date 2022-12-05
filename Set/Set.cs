using System;
using System.Collections;
using System.Collections.Generic;

namespace Set
{
    public class Set<T> : ISet<T>
    {
        private HashSet<T> hashSet;
        public Set()
        {
            hashSet = new HashSet<T>();
        }
        public int Size => hashSet.Count;
        
        public List<T> Elements
        {
            get
            {
                //do work
                List<T> elements = new List<T>();
                foreach (var e in hashSet)
                {
                    elements.Add(e);
                }

                //return work
                return elements;
            }
        }

        public void Add(ISet<T> s)
        {
            foreach (var item in s)
            {
                this.Add(item);
            }
        }

        public void Add(T value)
        {
            hashSet.Add(value);
        }

        public bool Contains(T value)
        {
            if (hashSet.Contains(value))
            {
                return true;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return hashSet.GetEnumerator();
        }

        public void Remove(ISet<T> s)
        {
            foreach (var item in s)
            {
                this.Remove(item);
            }
        }

        public void Remove(T value)
        {
            hashSet.Remove(value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static Set<T> Union(ISet<T> set1, ISet<T> set2)
        {
            Set<T> set3 = new Set<T>();

            foreach (var e in set1)
            {
                set3.Add(e);
            }

            foreach (var f in set2)
            {
                set3.Add(f);
            }

            return set3;
        }

        public static Set<T> Intersection(ISet<T> set1, ISet<T> set2)
        {
            Set<T> set3 = new Set<T>();

            foreach (var e in set1)
            {
                foreach (var f in set2)
                {
                    if (e.Equals(f))
                    {
                        set3.Add(e);
                    }
                }
            }

            return set3;
        }
    }
}
