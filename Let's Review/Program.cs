using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_s_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                string str = Console.ReadLine();
                string evenPositions = "";
                string oddPositions = "";

                for (int i = 0; i < str.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenPositions += str[i];
                    }
                    else
                    {
                        oddPositions += str[i];
                    }
                }
                Console.WriteLine(evenPositions + " " + oddPositions);
                n--;
            }
        }
    }
}
