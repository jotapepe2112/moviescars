using System;
using System.Collections.Generic;

namespace Ucu.Poo.Repositories
{
    public class Repository<T>
    {
        private readonly List<T> items = new List<T>();

        public void Add (T item)
        {
            if (item != null)
            {
                items.Add(item);
            }
        }

        public void Remove(T item)
        {
            this.items.Remove(item);
        }
        public T Find (Predicate<T> predicate)
        {
            foreach (T item in items)
            {
                if (predicate(item))
                {
                    return item;
                }
            }

            return default(T);
        }
    }
}