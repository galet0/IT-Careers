using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_02_OnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            //0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21
            //C h a n g e T h i s  1  2  a n  d  T  h  i   s  5  6  k
            string result = "";
            bool foundDigit = false;
            int lastAppend = -1;
            for (int i = 0; i < text.Length - 1; i++)
            {
                //0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21
                //C h a n g e T h i s  1  2  a n  d  T  h  i   s  5  6  k
                if (Char.IsDigit(text[i]))
                    //if(text[i]>='0' && text[i]<='9')
                {
                    foundDigit = true;
                }
                else
                {
                    if (foundDigit==true)
                    {
                        result += text[i];
                        foundDigit = false;
                    }
                    result += text[i];
                    lastAppend = i;
                }

            }
            if (lastAppend != text.Length - 1)
            {
                result += text.Substring(lastAppend + 1);
            }
            Console.WriteLine(result);
        }
    }
}
