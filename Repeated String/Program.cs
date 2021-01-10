using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeated_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aba";
            long n = 10;
            Console.WriteLine(RepeatedString(str, n));
           // Console.WriteLine(RepeatedString("a",1000000000000));

        }
        static long RepeatedString(string s, long n)
        {
            long countA = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    countA++;
                }
            }
            long result = n / s.Length * countA;
            if (n % s.Length != 0)
            {
                long rest = n % s.Length;
                countA = 0;
                for (int i = 0; i < rest; i++)
                {
                    if (s[i] == 'a')
                    {
                        countA++;
                    }
                }
                result += countA;
            }
            return result;
        }
    }
}
