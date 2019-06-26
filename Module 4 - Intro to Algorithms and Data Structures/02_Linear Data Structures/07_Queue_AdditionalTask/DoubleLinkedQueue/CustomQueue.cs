using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedQueue
{
    class CustomQueue<T> : IEnumerable<T>
    {
        private class QueueNode<T>
        {
            public T Value { get; private set; }
            public QueueNode<T> NextNode { get; set; }
            public QueueNode<T> PrevNode { get; set; }

            public QueueNode(T value)
            {
                this.Value = value;
            }
        }

        private QueueNode<T> head;
        private QueueNode<T> tail;
        public int Count { get; private set; }

        public void Enqueue(T element)
        {
            QueueNode<T> newNode = new QueueNode<T>(element);

            if (this.Count == 0)
            {
                this.head = newNode;
            }
            else
            {
                newNode.NextNode = null;
                newNode.PrevNode = this.tail;
                this.tail.NextNode = newNode;
            }
            
            this.tail = newNode;
            this.Count++;
        }

        public T Dequeue()
        {
            if(this.head == null)
            {
                throw new InvalidOperationException();
            }
            T element = this.head.Value;

            this.head = this.head.NextNode;
            if(this.head != null)
            {
                this.head.PrevNode = null;
            }
            
            this.Count--;
            return element;
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.Count];
            QueueNode<T> currentNode = this.head;
            int index = 0;

            while(currentNode != null)
            {
                arr[index] = currentNode.Value;
                currentNode = currentNode.NextNode;
                index++;
            }

            return arr;
        }

        public IEnumerator<T> GetEnumerator()
        {
            QueueNode<T> currentNode = this.head;

            while(currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
