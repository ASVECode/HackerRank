using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            // Write Your Code Here
            int numSwaps = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        Swap(j, j + 1, a);
                        numSwaps++;
                    }
                }

                if (numSwaps == 0)
                {
                    break;
                }
            }

            Console.WriteLine("Array is sorted in " + numSwaps + " swaps.");
            Console.WriteLine("First Element: " + a[0]);
            Console.WriteLine("Last Element: " + a[a.Length - 1]);
        }

        private static void Swap(int a, int b, int []arr)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
