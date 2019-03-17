using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DirectSelectionSortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Метод на прекия избор (пряка селекция)
            //n-1 пъти  намираме индекса на най-малкия елемент от неподредената част на масива
            //На всяко завъртане на цикъла  поставяме най-малкия елемент на мястото му
            //в подредената част на масива

            int[] arr = { 2, 4, -5, 1, 10 };

            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[j] < arr[min])
                    {
                        //намира индекса на минималния елемент в масива
                        min = j;
                    }
                }
                //разменя минималния елемент с първия неподреден елемент в масива
                int swap = arr[i];
                arr[i] = arr[min];
                arr[min] = swap;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
