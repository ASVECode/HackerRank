using System;
using System.Collections.Generic;

namespace Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 3, 4, 2 };
            int k = 2;

            Console.WriteLine(pairs(k, arr));
        }

        static int pairs(int k, int[] arr)
        {
            Array.Sort(arr);
            HashSet<int> numbers = new HashSet<int>();
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (numbers.Contains(arr[i] - k))
                {
                    result++;
                }
                numbers.Add(arr[i]);
            }
            return result;
        }
    }
}
