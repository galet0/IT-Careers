using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_01_MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();
            int indexFirst = 0;
            int indexLast = 0;

            while (pattern.Length > 0)
            {
                if (text.Length > pattern.Length)
                {
                    indexFirst = text.IndexOf(pattern);
                    
                    if (indexFirst != -1 && indexLast != -1)
                    {
                        text = text.Remove(indexFirst, pattern.Length);
                        indexLast = text.LastIndexOf(pattern);
                        text = text.Remove(indexLast, pattern.Length);
                        pattern = pattern.Remove(pattern.Length / 2, 1);
                        Console.WriteLine("Shaked it.");
                    }
                    else
                    {
                        break;
                    }
                }
                
            }
            
            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}
