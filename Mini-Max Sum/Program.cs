using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
         ;
            miniMaxSum(arr);
        }

        static void miniMaxSum(int[] arr)
        {
            Array.Sort(arr);
            long min = 0, max = 0;
            for (int i = 0, j = arr.Length - 1; i < arr.Length - 1; i++, j--)
            {
                max = max + arr[j];
                min = min + arr[i];
            }
            Console.WriteLine(min + " " + max);
         
        }
    }
}
