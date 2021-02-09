using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Digit_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nk = Console.ReadLine().Split(' ');

            string n = nk[0];

            int k = Convert.ToInt32(nk[1]);

            int result = superDigit(n, k);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        static int superDigit(string n, int k)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < k % 9; i++)
            {
                sb.Append(n);
            }
            return Helper(sb);
        }

        static int Helper(StringBuilder str)
        {
            if (str.Length == 1)
                return Convert.ToInt32(str.ToString());
            else
            {
                long sum = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    sum += Convert.ToInt32(str[i].ToString());
                }
                return Helper(new StringBuilder(sum.ToString()));
            }
        }
    }
}
