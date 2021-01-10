using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array___DS
{
    class Program
    {
        static void Main()
        {
            int[][] matrix = new int[6][];
            for (int i = 0; i < 6; i++)
            {
                matrix[i] = new int[6];
                for (int j = 0; j < 6; j++)
                {
                    matrix[i][j] = 1;
                }
            }
            Console.WriteLine(HourglassSum(matrix));
        }
        static int HourglassSum(int[][] arr)
        {
            int SumHourGlass(int r, int c, int[][] matrix)
            {
                int sumResult = matrix[r][c]
                    + matrix[r][c + 1]
                    + matrix[r][c + 2]
                    + matrix[r + 1][c + 1]
                    + matrix[r + 2][c]
                    + matrix[r + 2][c + 1]
                    + matrix[r + 2][c + 2];

                return sumResult;
            }
            int sum = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j + 2 == 4)
                    {
                        break;
                    }
                    if (sum < SumHourGlass(i, j, arr))
                    {
                        sum = SumHourGlass(i, j, arr);
                    }
                }
                if (i + 2 == 4)
                {
                    break;
                }
            }
            return sum;
        }

    }
}
