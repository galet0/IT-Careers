using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //alyakeykala kalakey
            //key
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();
            //OUTPUT
            //alakeala kala
            while(pattern.Length > 0)
            {
                //След първата промяна текстът бива промен на: 
                //alyakeykala kala 
                //шаблонът бива изменен 
                //key -> ky -> yk
                //Console.WriteLine(text.LastIndexOf(pattern));
                int index = text.LastIndexOf(pattern);
                if (index != -1)
                {
                    text = text.Remove(text.LastIndexOf(pattern), pattern.Length);
                    //Console.WriteLine(text);
                    int patternIndex = pattern.Length / 2;
                    //Console.WriteLine(patternIndex);
                    pattern = pattern.Remove(patternIndex, 1);
                    char[] reversed = pattern.Reverse().ToArray();
                    pattern = new string(reversed);
                    //Console.WriteLine(string.Join("", pattern));
                    //Текстът се изменя отново: alyakeala kala
                    //Шаблонът също ky->y

                    //Отново търсим съвпадение - alyakeala kala

                    //Премахваме съвпадението и средния символ на шаблона, 
                    //в този случай шаблон вече не съществува и прекратяваме изпълнението на програмата. Печатаме текста

                }
                else
                {
                    break;
                }

            }
            Console.WriteLine(text);
        }
    }
}
