using System;

namespace Minimum_Swaps_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 1, 3, 2, 4, 5, 6 };

            Console.WriteLine(minimumSwaps(arr));
        }

        static int minimumSwaps(int[] arr)
        {
            int countSwaps = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 != arr[i])
                {
                    int t = i;
                    while (arr[t] != i + 1)
                    {
                        t++;
                    }
                    int temp = arr[t];
                    arr[t] = arr[i];
                    arr[i] = temp;
                    countSwaps++;
                }
            }
            return countSwaps;

        }
    }
}
