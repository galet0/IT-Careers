using System;

namespace _04_02_01_StretchingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<String> list = new CustomList<string>();
            list.Add("Pesho");
            list.Add("Gosho");
            list.Add("Tosho");
            Console.WriteLine(list.Length);
            Console.WriteLine(list.Capacity);

            Console.WriteLine(list.Get(2));
            list.Set(2, "Geri");
            Console.WriteLine(list.Get(2));
            list.RemoveAt(1);
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list.Get(i));
            }
        }
    }
}
