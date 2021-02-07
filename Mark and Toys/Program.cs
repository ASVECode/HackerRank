using System;

namespace Mark_and_Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int numToys = int.Parse(input[0]);
            int moneyToSpend = int.Parse(input[1]);

            int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '),
                pricesTemp => Convert.ToInt32(pricesTemp));

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = 0; j < prices.Length - 1; j++)
                {
                    if (prices[j] > prices[j + 1])
                        Swap(j, j + 1, prices);
                }

            }
            int sum = 0;
            int toysToBuy = 0; ;
            for (int i = 0; i < prices.Length; i++)
            {
                sum += prices[i];

                if (sum > moneyToSpend)
                {
                    toysToBuy = i;
                    break;
                }
            }
            Console.WriteLine(toysToBuy);
        }

        private static void Swap(int index1, int index2, int[] arr)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

        static int maximumToys(int[] prices, int k)
        {
            int count = 0, sum = 0;
            Array.Sort(prices);
            for (int i = 0; i < prices.Length; i++)
            {
                if (sum <= k)
                {
                    sum = sum + prices[i];
                    count++;
                }
            }
            return count - 1;
        }

    }
}
