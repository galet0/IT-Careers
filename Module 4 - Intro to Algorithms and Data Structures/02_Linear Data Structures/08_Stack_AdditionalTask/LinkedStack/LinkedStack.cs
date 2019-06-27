using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedStack
{
    class LinkedStack<T>
    {
        private class Node<T>
        {
            public T Value { get; set; }
            public Node<T> PrevNode { get; private set; }

            public Node(T value, Node<T> prev = null)
            {
                this.Value = value;
                this.PrevNode = prev;
            }
        }

        private Node<T> firstNode;
        public int Count { get; private set; }

        public void Push(T element)
        {
            this.firstNode = new Node<T>(element, this.firstNode);
            this.Count++;
        }

        public T Pop()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            this.Count--;
            return this.firstNode.Value;
        }
        public T[] ToArray()
        {
            Node<T> currentNode = this.firstNode;
            T[] arr = new T[this.Count];
            int index = this.Count - 1;

            while(currentNode != null)
            {
                arr[index] = currentNode.Value;
                currentNode = currentNode.PrevNode;
                index--;
            }

            return arr;
        }

    }
}
