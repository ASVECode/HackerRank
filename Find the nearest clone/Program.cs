using System;
using System.IO;

namespace Find_the_nearest_clone
{
    class Program
    {
        static void Main(string[] args)
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] graphNodesEdges = Console.ReadLine().Split(' ');
            int graphNodes = Convert.ToInt32(graphNodesEdges[0]);
            int graphEdges = Convert.ToInt32(graphNodesEdges[1]);

            int[] graphFrom = new int[graphEdges];
            int[] graphTo = new int[graphEdges];

            for (int i = 0; i < graphEdges; i++)
            {
                string[] graphFromTo = Console.ReadLine().Split(' ');
                graphFrom[i] = Convert.ToInt32(graphFromTo[0]);
                graphTo[i] = Convert.ToInt32(graphFromTo[1]);

                Console.WriteLine("--" + graphFrom[i] + " " + graphTo[i]);
            }

            long[] ids = Array.ConvertAll(Console.ReadLine()
                .Split(' '), idsTemp => Convert.ToInt64(idsTemp));

            int val = Convert.ToInt32(Console.ReadLine());

            int ans = findShortest(graphNodes, graphFrom, graphTo, ids, val);

            //textWriter.WriteLine(ans);

            //textWriter.Flush();
            //textWriter.Close();
        }

        public static int findShortest(int graphNodes, int[] graphFrom, int[] graphTo, long[] ids, int val)
        {
            int result = 0;

            return result;
        }
    }


}
