using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_02_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 20 30
            //2
            //0 5
            //1 25
            List<int> scores = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int examsCount = int.Parse(Console.ReadLine());

            //брой изпитвания
            for (int i = 0; i < examsCount; i++)
            {
                int[] exam = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int studentNumber = exam[0];//0
                int currentScore = exam[1];//5

                /*
                 * 2 40 – Ученик, номер 2, с оценка 40 – добавяме я към резултата
                    получаваме 15 25 75

                    1 35 – Ученик, номер 1, с оценка 35 - добавяме я към резултата
                    получаваме 15 60 75

                    0 5 – Ученик, номер 0, с оценка 5, по-ниска от резултата, тоест вадим я от него.
                    получаваме 10 60 75

                    0 6 - Ученик, номер 0, с оценка 6, по-ниска от резултата, тоест вадим я от него. 
                    Резултата на ученика става -1, при проверка дали текущия резултат е двойно 
                    по-малък от първоначални, разбираме, че е така, съответно ученика бива премахнат.

                    Остават двама 60 75

                 */
                int prevResult = scores[studentNumber];
                if (studentNumber >= 0 && studentNumber < scores.Count)
                {
                    if (currentScore < scores[studentNumber])
                    {
                        scores[studentNumber] -= currentScore;
                    }
                    else
                    {
                        scores[studentNumber] += currentScore;
                    }
                    Console.WriteLine(string.Join("; ", scores));
                }

                if(scores[studentNumber] < (prevResult / 2))
                {
                    scores.RemoveAt(studentNumber);
                }

                if(scores.Count == 0)
                {
                    break;
                }
            }

            if(scores.Count > 0)
            {
                Console.WriteLine(string.Join("; ", scores));
            }
            else
            {
                Console.WriteLine("All studets has been expelled due bad results!");
            }
        }
    }
}
