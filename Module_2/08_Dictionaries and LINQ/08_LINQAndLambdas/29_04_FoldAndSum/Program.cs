using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_04_FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 2 3 4 5 6 7 8
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int k = input.Length / 4;

            //Ред 1, лява част: вземете първите k числа и обърнете наобратно.
            //2 1
            int[] left = input.Take(k).Reverse().ToArray();
            //Ред 1, дясна част: обърнете наобратно и вземете първите k числа.
            //8 7
            int[] right = input.Reverse().Take(k).ToArray();
            //Слейте лявата и дясната част на ред 1.
            //2 1 8 7
            int[] row1 = left.Concat(right).ToArray();
            //Ред 2: пропуснете първите k числа и вземете следващите 2*k числа.
            //3 4 5 6
            int[] row2 = input.Skip(k).Take(2 * k).ToArray();
            //Сумирайте масивите row1 и row2: var sum = row1.Select((x, index) => x + row2[index]).
            int[] sum = row1.Select((i, j) => i + row2[j]).ToArray();

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
