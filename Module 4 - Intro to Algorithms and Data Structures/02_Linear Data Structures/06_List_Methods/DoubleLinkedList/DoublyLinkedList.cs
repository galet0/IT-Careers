﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList
{
    class DoublyLinkedList<T> : IEnumerable<T>
    {
        private class Node<T>
        {
            public T Value { get; private set; }
            public Node<T> NextNode { get; set; }
            public Node<T> PrevNode { get; set; }

            public Node(T value)
            {
                this.Value = value;
            }
        }

        private Node<T> head;
        private Node<T> tail;

        public int Count { get; private set; }

        public void AddFirst(T element)
        {
            Node<T> newHead = new Node<T>(element);

            if (this.Count == 0)
            {
                this.head = newHead;
                this.tail = newHead;
            }
            else
            {
                newHead.NextNode = this.head;
                this.head.PrevNode = newHead;
                this.head = newHead;
            }

            this.Count++;
        }

        public void ForEach(Action<T> action)
        {
            Node<T> currentNode = this.head;
            while(currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public void AddLast(T element)
        {
            Node<T> newTail = new Node<T>(element);

            if (this.Count == 0)
            {
                this.head = newTail;
                this.tail = newTail;
            }
            else
            {
                newTail.PrevNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public T RemoveFirst()
        {
            CheckListIsEmpty();
            
            T firstElement = this.head.Value;
            this.head = this.head.NextNode;

            if (this.head != null)
            {
                this.head.PrevNode = null;
            }
            else
            {
                this.tail = null;
            }

            this.Count--;
            return firstElement;
        }

        public T RemoveLast()
        {
            CheckListIsEmpty();

            T lastElement = this.tail.Value;
            this.tail = this.tail.PrevNode;

            if (this.tail != null)
            {
                this.tail.NextNode = null;
            }
            else
            {
                this.head = null;
            }

            this.Count--;
            return lastElement;
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.Count];
            int index = 0;
            Node<T> currNode = this.head;

            while(currNode != null)
            {
                arr[index] = currNode.Value;
                currNode = currNode.NextNode;
                index++;
            }

            return arr;
        }

        public T[] Reverse()
        {
            Node<T> currNode = this.tail;
            T[] reversedList = new T[this.Count];
            int index = 0;
            while(currNode != null)
            {
                reversedList[index] = currNode.Value;
                currNode = currNode.PrevNode;
                index++;
            }

            return reversedList;
        }

        private void CheckListIsEmpty()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List empty");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> currentNode = this.head;

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
