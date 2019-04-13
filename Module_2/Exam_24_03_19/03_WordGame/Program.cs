using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WordGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int maxPoints = 0;
            string winningWord = "";

            while (!word.Equals("END OF GAME"))
            {
                int points = 0;
                foreach (char ch in word)
                {
                    points += ch;
                }

                if (Char.IsUpper(word[0]))
                {
                    points += 15;
                }
                if(word[word.Length - 1] == 't')
                {
                    points += 20;
                }
                if(word.Length >= 10)
                {
                    points += 30;
                }

                if(points > maxPoints)
                {
                    maxPoints = points;
                    winningWord = word;
                }
                word = Console.ReadLine();
            }

            Console.WriteLine("Winner is word: {0}", winningWord);
            Console.WriteLine("Points: {0}", maxPoints);
        }
    }
}
