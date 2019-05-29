using System;

namespace _04_02_2_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicList dynamicList = new DynamicList();
            dynamicList.Add("Zero");
            dynamicList.Add("One");
            dynamicList.Add("Two");
            dynamicList.Add("Three");

            Console.WriteLine("Count: " + dynamicList.Count);
            Console.WriteLine("IndexOf Three: " + dynamicList.IndexOf("Three"));//3
            Console.WriteLine("IndexOf Tree: " + dynamicList.IndexOf("Tree"));//-1
            Console.WriteLine("Remove element of index 1: " + dynamicList.Remove(1));//One връща node.element
            Console.WriteLine("Remove element Zero: " + dynamicList.Remove("Zero"));//0 връща индекса на елемента
            Console.WriteLine("Contains element Zero: " + dynamicList.Contains("Zero"));//False
            Console.WriteLine("Contains element Two: " + dynamicList.Contains("Two"));//True
            Console.WriteLine("Print element of index 0: " + dynamicList[0]);//Two
            dynamicList[0] = "Four";
            Console.WriteLine("Change element of index 0!");
            Console.WriteLine("Print element of index 0: " + dynamicList[0]);//Four
            Console.WriteLine("Count: " + dynamicList.Count);
            Console.WriteLine("----- Print the dynamic list -----");
            for (int i = 0; i < dynamicList.Count; i++)
            {
                Console.WriteLine(dynamicList[i]);
            }
        }
    }
}
