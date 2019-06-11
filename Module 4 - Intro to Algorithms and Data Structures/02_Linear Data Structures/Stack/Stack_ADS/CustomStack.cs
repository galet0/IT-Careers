using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_ADS
{
    class CustomStack<T>
    {
        public const int INITIAL_CAPACITY = 16;

        private T[] items;
        public int Count { get; set; }

        public CustomStack(int initialCapacity = INITIAL_CAPACITY)
        {
            this.items = new T[initialCapacity];
        }

        public void Push(T element)
        {
            if (this.Count == this.items.Length)
            {
                //TO DO Grow();
            }

            this.items[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Empty stack");
            }
            this.Count--;
            T element = this.items[this.Count];

            T[] temp = new T[this.items.Length];
            for (int i = 0; i < this.Count; i++)
            {
                temp[i] = this.items[i];
            }

            this.items = temp;
            return element;
        }

    }
}
