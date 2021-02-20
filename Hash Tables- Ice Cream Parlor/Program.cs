using System;
using System.Collections.Generic;

namespace Hash_Tables__Ice_Cream_Parlor
{
    class Program
    {
        static void whatFlavors(int[] cost, int money)
        {
            Dictionary<int, int> values = new Dictionary<int, int>();
            for (int i = 0; i < cost.Length; i++)
            {
                if (values.ContainsKey(money - cost[i]))
                {
                    Console.WriteLine(values[money - cost[i]]+1 + " " + (i+1));
                    return;
                }
                values.Add(cost[i], i);
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

                int[] cost = Array.ConvertAll(Console.ReadLine().Trim()
                    .Split(' '), costTemp => Convert.ToInt32(costTemp));
                
                whatFlavors(cost, money);
            }

        }
    }
}
