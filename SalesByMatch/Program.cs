using System;

namespace SalesByMatch
{
    class Program
    {
        static void Main()
        {
            int[] socksNum = new int[] { 1, 2, 1, 2, 1, 3, 2 };
            //int[] socksNum = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int n = socksNum.Length;
            Console.WriteLine(SockMerchant(n, socksNum));
        }
        static int SockMerchant(int n, int[] ar)
        {
            int pairs = 0;
            for (int i = 0; i < n; i++)
            {
                if (ar[i] == 0)
                {
                    continue;
                }
                int currentSock = ar[i];
                for (int j = i + 1; j < n; j++)
                {
                    if (currentSock == ar[j])
                    {
                        ar[j] = 0;
                        pairs++;
                        break;
                    }
                }
            }
            return pairs;
        }
    }
}
