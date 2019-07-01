using System;
using System.Collections.Generic;

namespace _04_SubsequencesWithList
{
    class Program
    {
        static void Main(string[] args)
        {
            //най-дълга редица от еднакви елементи
            List<int> list = new List<int>() { 1, 1, 2, 2, 2};

            //най-дългата нестрого растяща редица
            List<int> lis = new List<int>() { 1, 5, 4, 5, 7 };

            //най-дългата нестрого намаляваща редица
            List<int> lds = new List<int>() { 100, 80, 50, 20, 90, 5, 2 };


            Console.WriteLine(string.Join(", ", MaxSubSequence(list)));
            Console.WriteLine(string.Join(", ", LongestIncreasingSubSequence(lis)));
            Console.WriteLine(string.Join(", ", LongestDecreasingSubSequence(lds)));
        }

        public static List<int> MaxSubSequence(List<int> list)
        {
            List<int> maxSubsequence = new List<int>();
            List<int> tempSubsequence = new List<int>();

            tempSubsequence.Add(list[0]);

            for (int i = 1; i < list.Count; i++)
            {
                ///summary
                ///Ако заменим знака за сравнение == с:
                ///< ще намерим най-дългата растяща редица leftmost subsequence
                ///> ще намерим най-дългата намаляваща редица leftmost subsequence
                ///<= ще намерим най-дългата нестрого растяща редица rightmost subsequence
                ///>= ще намерим най-дългата нестрого намаляваща редица rightmost subsequence
                ///1, 5, 4, 5, 7
                if (tempSubsequence[0] == list[i])
                {
                    tempSubsequence.Add(list[i]);

                    if (tempSubsequence.Count > maxSubsequence.Count)
                    {
                        maxSubsequence.Clear();
                        maxSubsequence.AddRange(tempSubsequence);
                    }

                }
                else
                {
                    tempSubsequence.Clear();
                    tempSubsequence.Add(list[i]);
                }
            }

            return maxSubsequence;
        }

        public static List<int> LongestIncreasingSubSequence(List<int> list)
        {
            List<int> maxSubsequence = new List<int>();
            List<int> tempSubsequence = new List<int>();

            tempSubsequence.Add(list[0]);
            int currentValue = tempSubsequence[0];

            for (int i = 1; i < list.Count; i++)
            {
                ///summary
                ///Ако заменим знака за сравнение == с:
                ///<= ще намерим най-дългата нестрого растяща редица
                ///1, 5, 4, 5, 7
                if (currentValue <= list[i])
                {
                    tempSubsequence.Add(list[i]);
                    currentValue = list[i];
                    if (tempSubsequence.Count > maxSubsequence.Count)
                    {
                        maxSubsequence.Clear();
                        maxSubsequence.AddRange(tempSubsequence);
                    }

                }
                else
                {
                    tempSubsequence.Clear();
                    tempSubsequence.Add(list[i]);
                }
            }

            return maxSubsequence;
        }

        public static List<int> LongestDecreasingSubSequence(List<int> list)
        {
            List<int> maxSubsequence = new List<int>();
            List<int> tempSubsequence = new List<int>();

            tempSubsequence.Add(list[0]);
            int currentValue = tempSubsequence[0];

            for (int i = 1; i < list.Count; i++)
            {
                ///summary
                ///Ако заменим знака за сравнение == с:
                ///>= ще намерим най-дългата нестрого намаляваща редица
                ///
                if (currentValue >= list[i])
                {
                    tempSubsequence.Add(list[i]);
                    currentValue = list[i];
                    if (tempSubsequence.Count > maxSubsequence.Count)
                    {
                        maxSubsequence.Clear();
                        maxSubsequence.AddRange(tempSubsequence);
                    }

                }
                else
                {
                    tempSubsequence.Clear();
                    tempSubsequence.Add(list[i]);
                }
            }

            return maxSubsequence;
        }
    }
}
