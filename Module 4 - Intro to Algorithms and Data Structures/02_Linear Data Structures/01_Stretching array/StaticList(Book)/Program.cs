using System;

namespace StaticList_Book_
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomArrayList list = new CustomArrayList();
            list.Add(5);
            Console.WriteLine(list[1]);
            Console.WriteLine();
        }
    }
}
