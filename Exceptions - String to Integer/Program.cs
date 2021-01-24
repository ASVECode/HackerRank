using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions___String_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            try
            { //Try to parse string S as integer.
                int x = int.Parse(S);
                Console.WriteLine(x); //If it works, writeline.
            }
            catch (Exception)
            { //If it doesn't work, "catch" the exception and print the following string instead.
                Console.WriteLine("Bad String");
            }
        }
    }
}
