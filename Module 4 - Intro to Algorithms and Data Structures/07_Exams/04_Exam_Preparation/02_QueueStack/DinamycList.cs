using System;
using System.Collections.Generic;
using System.Text;

namespace _02_QueueStack
{
    class DinamycList<T>
    {
        private class Node<T>
        {
            private T item;
            private Node<T> next;

            public Node(T item)
            {
                this.Item = item;
            }

            public Node<T> Next { get; set; }
            public T Item { get; set; }
        }

        private Node<T> head;
        private Node<T> tail;

        public int Count { get; private set; }

        public void Enqueue(T item)
        {
            Node<T> newHead = new Node<T>(item);

            if(this.Count == 0)
            {
                this.head = newHead;
                this.tail = newHead;
            }
            else
            {
                newHead.Next = this.head;
                this.head = newHead;
            }

            this.Count++;
        }

        public void Push(T item)
        {
            Node<T> newTail = new Node<T>(item);

            if (this.Count == 0)
            {
                this.head = newTail;
                this.tail = newTail;
            }
            else
            {
                this.tail.Next = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public T Dequeue()
        {
            IsEmptyList();
            T element = this.head.Item;

            this.head = this.head.Next;
            this.Count--;

            return element;
        }

        public T Pop()
        {
            IsEmptyList();
            T element = this.tail.Item;

            Node<T> currentNode = this.head;
            Node<T> prevNode = null;

            while(currentNode != null)
            {
                prevNode = currentNode;
                currentNode = currentNode.Next;

                if (currentNode.Next == null)
                {
                    this.tail = prevNode;
                    this.tail.Next = null;
                    currentNode = null;
                }
            }            

            this.Count--;

            return element;
        }

        public T GetFirst()
        {
            IsEmptyList();
            T item = this.head.Item;

            return item;
        }

        public T GetLast()
        {
            IsEmptyList();
            T item = this.tail.Item;

            return item;
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.Count];
            int index = 0;

            Node<T> current = this.head;
            while(current != null)
            {
                arr[index] = current.Item;
                current = current.Next;
                index++;
            }

            return arr;
        }

        private void IsEmptyList()
        {
            if(this.Count == 0)
            {
                throw new IndexOutOfRangeException("Empty Dinamyc list");
            }
        }
    }
}
