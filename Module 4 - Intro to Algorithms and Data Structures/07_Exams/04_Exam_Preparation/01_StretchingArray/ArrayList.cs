using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_StretchingArray
{
    class ArrayList<T>
    {
        private const int Default_Capacity = 2;

        private T[] items;
        private int count;
        private int capacity;

        public ArrayList(int capacity = Default_Capacity)
        {
            this.items = new T[capacity];
            this.Capacity = capacity;
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
                if (this.Count == this.Capacity)
                {
                    this.Resize();
                }

                CheckIndex(index);
                
                if (this.Count == index)
                {
                    this.Count++;                    
                }
                this.items[index] = value;                
            }
        }

        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        public int Capacity
        {
            get { return this.capacity; }
            set { this.capacity = value; }
        }

        public void Add(T item)
        {
            if(this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.items[this.Count] = item;
            this.Count++;
        }

        public T RemoveAt(int index)
        {
            CheckIndex(index);
            T element = this.items[index];

            //this.items = this.items.Take(index)
            //    .Concat(this.items.Skip(index + 1))
            //    .ToArray();

            this.items[index] = default(T);
            this.Shift(index);

            this.Count--;

            if(this.Count <= this.items.Length / 2)
            {
                this.Shrink();
            }
            return element;
        }

        private void Shrink()
        {
            T[] copy = new T[this.items.Length / 2];

            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count; i++)
            {
                this.items[index] = this.items[index + 1];

            }
        }

        private void Resize()
        {
            this.Capacity *= 2;
            T[] temp = new T[this.Capacity];

            for (int i = 0; i < this.items.Length; i++)
            {
                temp[i] = this.items[i];
            }

            this.items = temp;
        }

        private void CheckIndex(int index)
        {
            //0 1 2 
            //1 2 3
            if (index < 0 || index > this.items.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
