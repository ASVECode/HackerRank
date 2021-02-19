using System;
using System.Collections.Generic;

namespace Hash_Tables__Ice_Cream_Parlor
{
    class Program
    {
        static void whatFlavors(int[] cost, int money)
        {
            HashSet<int> values = new HashSet<int>();
            for (int i = 0; i < cost.Length; i++)
            {
                if (values.Contains(money - cost[i]))
                {
                    Console.WriteLine(money - cost[i] + " " + cost[i]);
                    return;
                }
                values.Add(cost[i]);
            }

            throw new Exception("No two sum solution");

        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int money = Convert.ToInt32(Console.ReadLine());

                int n = Convert.ToInt32(Console.ReadLine());

                int[] cost = Array.ConvertAll(Console.ReadLine().Split(' '), costTemp => Convert.ToInt32(costTemp))
                ;
                whatFlavors(cost, money);
            }

        }
    }
}
