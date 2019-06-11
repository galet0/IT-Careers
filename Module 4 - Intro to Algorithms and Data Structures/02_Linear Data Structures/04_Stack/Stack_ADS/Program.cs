using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_ADS
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack<string> stack = new CustomStack<string>();
            stack.Push("pesho");
            stack.Push("gosho");
            stack.Push("tosho");


            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Count);
        }
    }
}
 