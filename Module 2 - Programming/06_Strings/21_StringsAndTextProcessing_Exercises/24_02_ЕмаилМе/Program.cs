using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_02_EmailMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            int index = email.IndexOf("@");
            int sumBefore = 0;
            int sumAfter = 0;

            for (int i = 0; i < index; i++)
            {
                sumBefore += email[i];
            }

            for (int i = index+1; i < email.Length; i++)
            {
                sumAfter += email[i];
            }
            //Той ще ви даде мейла си и вашата задача е да се извади сборът 
            //от символите след "@" от сбора на символите преди ' @'. 
            //Ако резултатът е равен или по-голямо от 0 - той ще напише мейла си, иначе не.
            if ((sumAfter - sumBefore) >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
