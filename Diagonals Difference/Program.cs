using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonals_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());
            List <List<int>> matrix = new List<List<int>> ();
            //read matrix
            for (int i = 0; i < sizeMatrix; i++)
            {
                int [] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                matrix.Add(line.ToList());
            }
            //Print the result
            Console.WriteLine(DiagonalDifference(matrix));
        }

        static int DiagonalDifference(List<List<int>>arr)
        {
            int[,] matrix = new int [arr.Count,arr.Count];
            for (int i = 0; i < arr.Count; i++)
            {
                int []line=arr[i].ToArray();
                for (int j = 0; j <arr.Count; j++)
                {
                    matrix[i, j] = line[j];
                }
            }
            int rD = 0;
            int lD = 0;
            for (int i = 0, j = matrix.GetLength(0)-1; i < matrix.GetLength(0); i++, j--)
            {
                rD += matrix[i, i];
                lD += matrix[i, j];
            }
            return Math.Abs(rD - lD);
        }
    }
}
