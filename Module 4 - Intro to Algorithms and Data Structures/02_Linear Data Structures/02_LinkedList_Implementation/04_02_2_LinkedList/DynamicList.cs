using System;
using System.Collections.Generic;
using System.Text;

namespace _04_02_2_LinkedList
{
    class DynamicList
    {
        private class Node
        {
            //полета
            //полето елемент ще ни служи да пазим обект, който са ни подали отвън
            private object element;
            //този нод е елемент, който ще бъде запазен като следващ в нашия свързан списък
            private Node next;

            //конструктор, който приема елемент,който сме му подали и предишен нод(последния елемент в списъка)
            public Node(object element, Node prevNode)
            {
                this.Element = element;
                //тук казваме, че на предишния(последния) нод, следващия елемент да бъде равен на текущата инстанция на нода
                prevNode.Next = this;
            }

            //конструктор, който приема само елемент,без да сме задали последен нод
            public Node(object element)
            {
                this.Element = element;
            }

            //пропъртита
            public object Element
            {
                get { return this.element; }
                set { this.element = value; }
            }

            public Node Next
            {
                get { return this.next; }
                set { this.next = value; }
            }
        }

        //полета
        //глава(начало) на списъка
        private Node head;
        //опашка(край) на списъка
        private Node tail;
        //броят на елементите в свързания списък
        private int count;

        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }
        //добавяне на елемент в свързания списък
        public void Add(object element)
        {
            //ако броя на елементите ни е 0, т.е. ако няма елементи в списъка 
            if(count == 0)
            {
                //създаваме си един нов нод с елемента, който ни се подава
                Node newNode = new Node(element);
                //в такъв случай и началото и края ще са равни на този нов нод
                head = newNode;
                tail = newNode;
                //и броя на елементите ни се увеличава
                count++;
            }
            //в противен случай, ако вече имаме елементи в нашия списък
            else
            {
                //вече ще ползваме конструктора на класа Node на който подаваме елемента и опашката(предишния нод), или 
                //последния елемент в нашия списък
                Node newNode = new Node(element, tail);
                //казваме на последния елемент, че вече ще бъде равен на този нов нод
                tail = newNode;
                //и увеличаваме броя на елементите в нашия списък
                count++;
            }
        }

        //намиране на индекса на даден елемент
        public int IndexOf(object item)
        {
            Node currentNode = head;
            int index = 0;

            while(currentNode != null)
            {
                if (currentNode.Element.Equals(item))
                {
                    return index;
                }

                index++;
                currentNode = currentNode.Next;
            }

            return -1;
        }

        //премахване на елемент от списъка
        public object Remove(int index)
        {
            int currentIndex = 0;
            Node current = head;
            Node previous = null;
            //zero, one, two, three
            while(current != null)
            {
                if(currentIndex == index)
                {
                    //a -> b -> c
                    if(previous != null)
                    {
                        //prev.next = one cuur.next = two
                        previous.Next = current.Next;
                    }
                    else
                    {
                        this.head = current.Next;
                    }
                    if(current.Next == null)
                    {
                        this.tail = previous;
                    }
                    count--;
                    return current.Element;
                }
                else
                {
                    //prev = zero
                    previous = current;
                    //curr = one
                    current = current.Next;
                    //currIndex = 1
                    currentIndex++;
                }
            }
            return null;
        }

        public int Remove(object element)
        {
            int index = this.IndexOf(element);
            object removed = this.Remove(index);
            if(removed != null)
            {
                return index;
            }
            else
            {
                return -1;
            }
        }

        public bool Contains(object element)
        {
            int index = this.IndexOf(element);
            //ако има такъв индекс, той ще е различен от -1 и ще ни върне true,
            //ако няма такъв индекс -1 != -1 ще ни върне false
            return index != -1;
        }

        public object this[int index]
        {
            get
            {
                int currentIndex = 0;
                Node currentNode = head;
                Node returnedNode = null;

                while(currentNode != null)
                {
                    if(currentIndex == index)
                    {
                        returnedNode = currentNode;
                        break;
                    }

                    currentNode = currentNode.Next;
                    currentIndex++;
                }

                if(returnedNode != null)
                {
                    return returnedNode.Element;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }

            set
            {
                int currentIndex = 0;
                Node currentNode = head;
                Node changedNode = null;

                while (currentNode != null)
                {
                    if (currentIndex == index)
                    {
                        changedNode = currentNode;
                        break;
                    }

                    currentNode = currentNode.Next;
                    currentIndex++;
                }

                if (changedNode != null)
                {
                    changedNode.Element = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
