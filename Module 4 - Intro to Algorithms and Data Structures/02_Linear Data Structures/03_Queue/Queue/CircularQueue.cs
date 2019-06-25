using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class CircularQueue<T>
    {
        private const int DefaultCapacity = 4;
        private T[] elements;
        //пази началния индекс (индекса на първия влезнал елемент в опашката)
        private int startIndex;
        //индекса в масива, който е непосредствено след последния добавен елемент
        private int endIndex;

        public int Count { get; private set; }

        public CircularQueue(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
            this.startIndex = 0;
            this.endIndex = 0;
        }

        public void Enqueue(T element)
        {
            //ако опашката е пълна, увеличава я (т.е. нейния капацитет става двойно по-голям). 
            if (this.Count >= this.elements.Length)
            {
                this.Grow();
            }
            //добавя новият елемент на позиция endIndex (индексът, който е точно след последния елемент), 
            //а след това премества индекса с една позиция надясно, 
            //както и увеличава вътрешния брояч Count
            this.elements[this.endIndex] = element;

            //Забележете, че опашката е кръгова, така че елемента след последния елемент 
            //(this.elements.Length-1) е 0.
            //Така стигаме до формула: 
            //Елементът следващ p е на позиция(p +1) % capacity.В кода имаме:
            //(this.endIndex + 1) % this.elements.Length
            this.endIndex = (this.endIndex + 1) % this.elements.Length;
            this.Count++;
        }

        public T Dequeue()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("The Queue is empty!");
            }

            T element = this.elements[startIndex];
            this.startIndex = (this.startIndex + 1) % this.elements.Length;
            this.Count--;
            return element;
        }

        public T[] ToArray()
        {
            T[] temp = new T[this.elements.Length];
            CopyAllElementsTo(temp);
            return temp;
        }


        private void Grow()
        {
            T[] newElements = new T[this.elements.Length * 2];
            CopyAllElementsTo(newElements);
            this.elements = newElements;
            this.startIndex = 0;
            this.endIndex = this.Count;
        }

        private void CopyAllElementsTo(T[] resultArr)
        {
            int sourceIndex = this.startIndex;
            int destinationIndex = 0;
            for (int i = 0; i < this.Count; i++)
            {
                resultArr[destinationIndex] = this.elements[sourceIndex];
                sourceIndex = (sourceIndex + 1) % this.elements.Length;
                destinationIndex++;
            }
        }
    }
}
