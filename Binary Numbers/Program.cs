using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int remainder;
            string result = "";
            while (n > 0)
            {
                remainder = n % 2;
                n /= 2;
                result = remainder + "" + result;
            }
            int counter = 0;
            int max = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '1')
                {
                    counter++;
                }

                if (result[i] == '0' || i==result.Length-1)
                {
                    if (counter > max)
                    {
                        max = counter;
                    }
                    counter = 0;
                }

            }
            Console.WriteLine(max);
        }
    }
}
