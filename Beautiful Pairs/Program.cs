using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautiful_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            //read input
            int n = int.Parse(Console.ReadLine());
            int[] a = new int [n];
            int[] b = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }

        }
    }
}
