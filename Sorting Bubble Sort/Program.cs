using System;

namespace Sorting_Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            countSwaps(a);
        }

        static void countSwaps(int[] a)
        {
            int count = 0;
            int i, j, temp;
            for (i = 0; i < a.Length - 1; ++i)
            {
                for (j = 0; j < a.Length - 1 - i; ++j)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                        count++;
                    }
                }
            }
            Console.WriteLine($"Array is sorted in {count} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[a.Length - 1]}");
        }
    }
}
