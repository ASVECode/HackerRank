using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Strings
{
    class Program
    {

        static void Main()
        {
            string s1 = "ads";
            string s2 = "ewq";
            Console.WriteLine(twoStrings(s1, s2));

        }
        static String twoStrings(String s1, String s2)
        {
            HashSet<Char> str1 = new HashSet<char>();
            HashSet<Char> str2 = new HashSet<char>();

            for (int i = 0; i < s1.Length; i++)
            {
                str1.Add(s1[i]);
            }
            for (int i = 0; i < s2.Length; i++)
            {
                str2.Add(s2[i]);
            }

            str1.IntersectWith(str2);
            if (str1.Count != 0)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
            //string result = "NO";
            //for (int i = 0; i < s1.Length; i++)
            //{
            //    char curChar = s1[i];
            //    for (int j = 0; j < s2.Length; j++)
            //    {
            //        if (s2[j] == curChar)
            //        {
            //            result = "YES";
            //            return result;
            //        }
            //    }
            //}
            //return result;
        }

    }
}
