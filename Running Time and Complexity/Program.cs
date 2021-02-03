using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Running_Time_and_Complexity
{
    class Program
    {
        public static bool isPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n >= 2 && isPrime(n)) Console.WriteLine("Prime");
                else Console.WriteLine("Not prime");
            }
        }
    }
}
