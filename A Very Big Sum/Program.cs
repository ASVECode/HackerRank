using System;
using System.IO;

namespace A_Very_Big_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
            ;
            long result = aVeryBigSum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        private static long aVeryBigSum(long[] ar)
        {
            long sum = 0;
            foreach (long a in ar)
            {
                sum += a;
            }
            return sum;
        }
    }
}

