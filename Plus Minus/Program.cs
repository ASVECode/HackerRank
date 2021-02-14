using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Minus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr);
        }
        static void plusMinus(int[] arr)
        {
            decimal countPositive = 0;
            decimal countNegative = 0;
            decimal countZeros = 0;
            int total = arr.Length;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    countZeros++;
                }else if (arr[i] > 0)
                {
                    countPositive++;
                }
                else
                {
                    countNegative++;
                }
            }
            Console.WriteLine((countPositive / total).ToString("0.000000"));
            Console.WriteLine((countNegative / total).ToString("0.000000"));
            Console.WriteLine((countZeros / total).ToString("0.000000"));
        }
    }
}
