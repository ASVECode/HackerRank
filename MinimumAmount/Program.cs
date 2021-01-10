using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumAmount
{

    class Program
    {
        static void Main()
        {
            int[] prices = new int[] { 2, 5, 1, 4 };
            Console.WriteLine(CalculateAmount(prices));
        }

        static int CalculateAmount(int[] prices)
        {
            int sum = prices[0];
            int min = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (min > prices[i - 1])
                {
                    min = prices[i - 1];
                }
                int price = Math.Max(prices[i] - min, 0);
                sum += price;
            }
            return sum;
        }
    }
}
