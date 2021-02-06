using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise_AND
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int max = 0;
                for (int j = 1; j < n; j++)
                {
                    for (int m = j + 1; m <= n; m++)
                    {
                        int h = j & m;
                        if (h < k && max < h) max = h;
                    }
                }

                Console.WriteLine(max);
            }
        }
    }
}
