using System;

namespace Jumping_on_the_Clouds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clouds = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            // int[] clouds = new int[] { 0, 0, 0, 1, 0, 0 };


            Console.WriteLine(JumpingOnClouds(clouds));

        }
        static int JumpingOnClouds(int[] c)
        {
            int jumps = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (i == c.Length - 1)
                {
                    return jumps;
                }
                if (i + 2 >= c.Length)
                {
                    jumps++;
                    return jumps;
                }
                //try jump with 2
                i += 2;
                if (c[i] == 1)
                {
                    i -= 2;
                }
                else
                {
                    i--;
                }
                jumps++;
            }
            return jumps;
        }
    }
}
