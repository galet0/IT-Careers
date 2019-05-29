using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_03_Punctoation
{
    class Program
    {
        static void Main(string[] args)
        {
            //abala L*ANica1203.!ze{LEee
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            
            string pattern = "!#%&()*-.:,?@[]_{}";
            char[] charArr = pattern.ToCharArray();

            foreach (char singleChar in charArr)
            {
                text = text.Replace(singleChar, '.');
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLower(text[i]))
                {
                    result.Append(Char.ToUpper(text[i]));
                }
                else if (Char.IsUpper(text[i]))
                {
                    result.Append(Char.ToLower(text[i]));
                }
                else if (Char.IsDigit(text[i]))
                {
                    int num = int.Parse(text[i].ToString()) * 2;
                    result.Append(num);
                }
                else if(text[i].Equals(' '))
                {
                    result.Append("");
                }
                else 
                {
                    result.Append(text[i]);
                }
            }

            
            Console.WriteLine(new string(result.ToString().Reverse().ToArray()));
        }
    }
}
