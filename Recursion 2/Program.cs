using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine(Fact(n));
        }

        private static long Fact(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n* Fact(n -1);
            }
        }
    }
}
