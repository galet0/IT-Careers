using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class CapacityList
    {
        private const int InitialCapacity = 2;
        private Pair[] items;

        private int startIndex = 0; //показва първият индекс, от който започваме да сумираме текущите елементи
        private int nextIndex = 0; //показва поредният индекс, на който можем да поставим елемент

        public CapacityList(int capacity = InitialCapacity)
        {
            this.items = new Pair[capacity];
        }

        public int Count
        {
            get { return this.items.Length; }
        }
        /*Методът SumIntervalPairs() трябва да 
         * може да сумира всички двойки, започвайки 
         * от зададен стартов индекс – този метод 
         * ще се използва вътрешно от класа, 
         * за да определя сумата от двойките 
         * за всеки следващ елемент, който запълва*/
        public Pair SumIntervalPairs()
        {
            //сумирайте двойките от startIndex до nextIndex
            Pair newPair = new Pair(0, 0);
            for (int i = startIndex; i < this.nextIndex; i++)
            {
                newPair.First += this.items[i].First;
                newPair.Last += this.items[i].Last;
            }

            return newPair;
        }

        public Pair Sum()
        {
            //TODO: сумирайте двойките от 0 до this.Count – 
            //всички двойки, които имат право да участват в класирането
            Pair sumPair = new Pair(0, 0);
            for (int i = 0; i < startIndex; i++)
            {
                sumPair.First += this.items[i].First;
                sumPair.Last += this.items[i].Last;
            }

            return sumPair;
        }

        public void Add(Pair item)
        {
            //Добавяне на двойката             
            if (nextIndex >= Count)
            {
                items[startIndex] = SumIntervalPairs();
                startIndex++;
                nextIndex = startIndex;
            }
            this.items[this.nextIndex] = item;
            this.nextIndex++;
            
        }

        public void PrintCurrentState()
        {
            for (int i = 0; i < this.nextIndex; i++)
            {
                Console.WriteLine(this.items[i]);
            }
        }

    }
}
