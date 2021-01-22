using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    public class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
       
    }
    public class Difference
    {
        private int[] elements;
        public int maximumDifference;

        // Add your code here
        public Difference (int []arr){
            this.elements=arr;
        }

        public int computeDifference(){
            Array.Sort(elements);
           return  maximumDifference= elements[elements.Length-1]-elements[0];
        }

    }
}
