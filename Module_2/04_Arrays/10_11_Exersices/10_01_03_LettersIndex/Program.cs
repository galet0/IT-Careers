using System;

namespace _10_01_03_LettersIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            //char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] alphabet = new char[26];

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)(97 + i);                
            }

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if(input[i] == alphabet[j])
                    {
                        Console.WriteLine("{0} -> {1}", input[i], j);
                    }
                }
            }
        }
    }
}
