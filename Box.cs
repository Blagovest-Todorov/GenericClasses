using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> data; //field
        public int Count 
        {
            get 
            {
                return data.Count; 
            }         
        }

        public Box()
        {
            data = new List<T>();
           
        }

        public void Add(T element)
        {
            data.Add(element);
           
        }

        public T Remove() 
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Cannot remove from empty collection");
            }

            T result = data.Last();
            data.Remove(result);

            return result;
        }
    }
}
