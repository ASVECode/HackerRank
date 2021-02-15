using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Compare_the_Triplets
{
    class Program
    {
        static void Main()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }

        static List<int>  compareTriplets(List<int> a, List<int> b)
        {
            List < int > result= new List<int>();
            int pointsAlice = ((a[0] > b[0]) ? 1 : 0) + ((a[1] > b[1]) ? 1 : 0) + ((a[2] > b[2]) ? 1 : 0);
            int pointsBob = ((a[0] < b[0]) ? 1 : 0) + ((a[1] < b[1]) ? 1 : 0) + ((a[2] < b[2]) ? 1 : 0);

            result.Add(pointsAlice);
            result.Add(pointsBob);

            return result;

        }
    }
}
