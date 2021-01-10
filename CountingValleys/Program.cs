using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class Program
    {
        static void Main()
        {
            string path = "UDDDUDUU";
            int steps = path.Length;
            Console.WriteLine(CountingValleys(steps, path));
        }
        public static int CountingValleys(int steps, string path)
        {
            int sum = 0;
            int countValleys = 0;
            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'U')
                {
                    sum++;
                    if (sum == 0)
                    {
                        countValleys++;
                    }
                }
                else
                {
                    sum--;
                }
            }
            return countValleys;
        }
    }
}
