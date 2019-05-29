using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_02_01_LongestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(); //{ "hi", "php", "java", "csharp", "sql", "html", "css", "js" };
            string[] arr2 = Console.ReadLine().Split();//{ "hi", "php", "java", "js", "softuni", "nakov", "java", "learn" };

            int minLength = Math.Min(arr1.Length, arr2.Length);
            int maxLength = Math.Max(arr1.Length, arr2.Length);
            //Console.WriteLine(minLength);
            int countLeftEqualsItems = 0;
            int countRightEqualsItems = 0;

            //0   1   2    3    4     5   6    7   8
            //hi php java xml csharp sql html css js
            //0       1   2   3    4  5
            //nakov java sql html css js

            //Console.WriteLine("arr1 " + arr1.Length);
            //Console.WriteLine("arr2 " + arr2.Length);
            for (int i = 0; i < minLength; i++)
            {
                string item1 = arr1[i];
                string item2 = arr2[i];
                if (item1 == item2)
                {
                    countLeftEqualsItems++;
                }
                if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i])
                {
                    countRightEqualsItems++;
                }
            }
            

            //Console.WriteLine("Left items: " + countLeftEqualsItems);
            
            //Console.WriteLine("Right items: " + countRightEqualsItems);
            Console.WriteLine(Math.Max(countLeftEqualsItems, countRightEqualsItems));
        }
    }
}
