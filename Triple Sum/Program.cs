using System;
using System.IO;
using System.Linq;

namespace Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = { 7, 5, 3, 5, 7 };
            int[] b = { 3, 6 };
            int[] c = { 4, 6, 9 };
            long ans = triplets(a, b, c);
            Console.WriteLine(ans);

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //string[] lenaLenbLenc = Console.ReadLine().Split(' ');

            //int lena = Convert.ToInt32(lenaLenbLenc[0]);

            //int lenb = Convert.ToInt32(lenaLenbLenc[1]);

            //int lenc = Convert.ToInt32(lenaLenbLenc[2]);

            //int[] arra = Array.ConvertAll(Console.ReadLine()
            //    .Split(' '), arraTemp => Convert.ToInt32(arraTemp));

            //int[] arrb = Array.ConvertAll(Console.ReadLine()
            //    .Split(' '), arrbTemp => Convert.ToInt32(arrbTemp));

            //int[] arrc = Array.ConvertAll(Console.ReadLine()
            //    .Split(' '), arrcTemp => Convert.ToInt32(arrcTemp));

            //long ans = triplets(arra, arrb, arrc);

            //textWriter.WriteLine(ans);

            //textWriter.Flush();
            //textWriter.Close();
        }

        private static long triplets(int[] a, int[] b, int[] c)
        {
            a = a.Distinct().OrderBy(f => f).ToArray();
            b = b.Distinct().OrderBy(f => f).ToArray();
            c = c.Distinct().OrderBy(f => f).ToArray();

            long i = 0;
            long j = 0;
            long sum = 0;

            foreach (var val in b)
            {
                while (i < a.Length && a[i] <= val) i++;
                while (j < c.Length && c[j] <= val) j++;

                sum += i * j;
            }

            return sum;
        }
    }
}
