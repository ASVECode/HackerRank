
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall
{
    class Program
    {
        static void Main(string[] args)
        {
            int []layerSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = layerSize[0];
            int m = layerSize[1];

            int[] bricks = new int[n * m / 2];
            int count = 0;

            int[,] firstLayer = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    firstLayer[i, j] = row[j];
                    if (!bricks.Contains(row[j]))
                    {
                        bricks[count] = row[j];
                        count++;
                    }
                }

            }
            Console.WriteLine();
            SwapPositions(bricks);
            int[,] secondLayer = new int[n, m];
            count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (secondLayer[i, j] != 0)
                    {
                        continue;
                    }
                    secondLayer[i, j] = bricks[count];
                    if (j + 1 > m - 1 || firstLayer[i, j + 1] != firstLayer[i, j])
                    {
                        secondLayer[i + 1, j] = bricks[count];
                    }
                    else
                    {
                        secondLayer[i, j + 1] = bricks[count];
                    }
                    count++;
                }
            }
            //PrintOutline(secondLayer, bricks);
            Print(secondLayer,bricks);
        }

        private static void PrintOutline(int[,]layer,int[]bricks){
            int numCols=layer.GetLength(1);
            int numRows=layer.GetLength(0);
            //print first line
            string line = new String('*',numCols*2+1);
            Console.WriteLine(line);
            for (int i = 0; i < numRows; i++)
			{
                Console.Write("*");
                for (int j = 0; j < numCols; j++)
			    {
                     if(j==numCols-1){
                         Console.Write($"{layer[i,j]}*");
                        break;
                     }
                    if(layer[i,j]!=layer[i,j+1] ){
                        Console.Write($"{layer[i,j]}*");
                    }else{
                        Console.Write($"{layer[i,j]} ");
                    }
			    }
               Console.WriteLine();
                line = "*";
                for (int col = 0; col < numCols; col++)
			    {
                   if(i==numRows-1){
                        line = new String('*',numCols*2+1);
                        break;
                   }
                    if(layer[i,col]==layer[i+1,col]){
                        line+=" *";
                        
                    }else{
                        line+="**";
                    }
			    }
                Console.WriteLine(line);
			}
        }

        private static void Print(int[,]layer,int[]bricks){
            int numCols=layer.GetLength(1);
            int numRows=layer.GetLength(0);
            //print first line
           string line = new String('*',numCols*2+1);
          // Console.WriteLine(line);
            for (int i = 0; i < numRows; i++)
			{
                Console.Write("*");
                for (int j=0; j < numCols; j++)
			    { 
                    if(layer[i,j]<10){
                       if(j==numCols-1){
                          Console.Write($" {layer[i,j]} *");
                          break;
                       }
                       if(layer[i,j]!=layer[i,j+1] ){
                        Console.Write($" {layer[i,j]} *");
                       }else{
                        Console.Write($" {layer[i,j]}  ");
                       }
                    }else{
                        if(j==numCols-1){
                          Console.Write($" {layer[i,j]}*");
                          break;
                        }
                         if(i==numRows-1){
                             if(j==0 ||(layer[i,j]!=layer[i,j+1] && layer[i,j]!=layer[i,j-1]) ){
                              Console.Write($" {layer[i,j]} *");
                             }else if(layer[i,j]==layer[i,j+1]){
                              Console.Write($" {layer[i,j]} ");
                             }else if(layer[i,j]!=layer[i,j+1] && layer[i,j]==layer[i,j-1]){
                              Console.Write($"{layer[i,j]} *");
                             }

                            }
                              continue;
                         }

                        if(layer[i,j]!=layer[i,j+1] && layer[i,j]==layer[i+1,j]){
                          Console.Write($" {layer[i,j]}*");
                        }else if(layer[i,j]==layer[i,j+1]){
                          Console.Write($" {layer[i,j]} ");
                        }else if(layer[i,j]!=layer[i,j+1] && layer[i,j]!=layer[i+1,j]){
                            if(layer[i,j]==layer[i,j-1]){
                              Console.Write($"{layer[i,j]} *");
                            }else{
                              Console.Write($" {layer[i,j]}*");
                            }
                        }
                    }
			    }
               Console.WriteLine();
                line = "*";

                for (int col = 0; col < numCols; col++)
			    {
                  
                   if(i==numRows-1){
                        line = new String('*',numCols*2+1);
                        break;
                   }
                    if(layer[i,col]==layer[i+1,col]){
                        if(layer[i,col]<10){
                          line+="   *";
                        }else{
                          line+="  *";
                        }
                        
                    }else{
                        line+="****";
                    }
			    }
                Console.WriteLine(line);
			}
        }
       
        private static void SwapPositions(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    i--;
                    Swap(i, i + 1, arr);
                    break;
                }
                Swap(i, i + 1, arr);
                i++;
            }
        }
        private static void Swap(int i, int j, int[] arr)
        {
            int t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }


    }
}
