using System;

namespace _10_02_03_RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] nums = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            int rotations = int.Parse(Console.ReadLine());
            int[] sum = new int[nums.Length];

            for (int i = 0; i < rotations; i++)
            {   //              3  2  4 -1
                //rotated1[] = -1  3  2  4
                //rotated2[] =  4 -1  3  2
                //sum[] =       3  2  5  6
                int[] rotated = Rotate(nums);
                for (int j = 0; j < rotated.Length; j++)
                {
                    sum[j] += rotated[j];
                }
                nums = rotated;

                //RightShift(nums);
                //Sum(sum, nums);
            }

            Console.WriteLine(string.Join(" ", sum));
            //RightShift(nums);
            //Console.WriteLine(string.Join(" ", nums));
        }

        static int[] Rotate(int[] array)
        {
            int lastElement = array[array.Length - 1];
            int[] rotatedArr = new int[array.Length];
            rotatedArr[0] = lastElement;

            for (int i = 1; i < array.Length; i++)
            {
                rotatedArr[i] = array[i - 1];
            }

            return rotatedArr;
        }

        static void RightShift(int[] arr)
        {
            //1 2 3 4 5
            //5 1 2 3 4
            int lastItem = arr[arr.Length - 1];            

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = lastItem;
        }

        static void Sum(int[] sum, int[] arr)
        {
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] += arr[i];
            }
        }
    }
}
