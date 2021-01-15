using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            //int.Parse(Console.ReadLine());
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            for (int i = n - 1; i > -1; --i)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
