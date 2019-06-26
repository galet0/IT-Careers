using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List_AdditionalTask
{
    class ReversedList<T> : IEnumerable<T>
    {
        private const int INITIAL_CAPACITY = 2;

        private T[] items;
        public int Count { get; private set; }
        public int Capacity { get; private set; }

        public ReversedList()
        {
            this.Capacity = INITIAL_CAPACITY;
            this.items = new T[this.Capacity];
        }

        public T this[int index]
        {
            get
            {
                CheckIndex(index);
                return this.items[index];
            }

            set
            {
                CheckIndex(index);
                this.items[index] = value;
            }
        }

        private void CheckIndex(int index)
        {
            //1, 2, 3
            if(index < 0 || index > this.items.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void Add(T element)
        {
            if(this.Count == this.items.Length)
            {
                this.Grow();
            }

            this.items[this.Count] = element;
            this.Count++;
        }

        public T RemoveAt(int index)
        {
            CheckIndex(index);
            //0 1 2 3
            //2 3 4 5
            //0 1 2 3
            //5 4 3 2
            T element = this.items[this.Count - 1 - index];

            this.items = this.items.Take(this.Count - 1 - index)
                .Concat(this.items.Skip(this.Count - index))
                .ToArray();
            this.Count--;
            
            return element;
        }

        public T[] GetReversed()
        {
            return this.items.Take(this.Count).Reverse().ToArray();
        }

        public T GetReversedByIndex(int index)
        {
            CheckIndex(index);
            return this.GetReversed()[index];
        }

        private void Grow()
        {
            this.Capacity *= 2;
            T[] temp = new T[this.Capacity];
            for (int i = 0; i < this.Count; i++)
            {
                temp[i] = this.items[i];
            }

            this.items = temp;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.items[i];
            }
            //foreach (T item in this.items)
            //{
            //    yield return item;
            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
