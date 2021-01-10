using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Left_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 13;
            // int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int[] arr = new int[] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 };
            Console.WriteLine(string.Join(" ", rotLeft(arr, d)));

        }
        static int[] rotLeft(int[] a, int d)
        {
            int[] temp = new int[d];
            for (int i = 0; i < a.Length; i++)
            {
                if (i < d)
                {
                    temp[i] = a[i];
                }

            }
            for (int i = 0; i < a.Length; i++)
            {
                if (i + d >= a.Length)
                {
                    break;
                }
                a[i] = a[i + d];
            }
            int j = d;

            for (int i = 0; i < d; i++)
            {
                a[a.Length - j] = temp[i];
                j--;
            }
            return a;
        }

    }
}
