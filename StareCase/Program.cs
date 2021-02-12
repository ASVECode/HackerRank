using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            staircase(N);
        }
        static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));
        }

    }
}
