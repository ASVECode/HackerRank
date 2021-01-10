using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Valleys
{
    class Program
    {
        static void Main()
        {

        }
        static int CountingValleys(int n, string s)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'U')
                {
                    if (++sum == 0)
                        count++;
                }
                else sum--;
            }
            return count;
        }
    }
}
