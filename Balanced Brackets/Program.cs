using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Brackets
{
    class Program
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string s = Console.ReadLine();

                string result = isBalanced(s);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }

        public string isBalanced(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char ch in s)
            {
                if (stack.Count == 0)
                    stack.Push(ch);
                else
                {
                    switch (stack.Peek())
                    {
                        case '{':
                            if (ch == '}') stack.Pop();
                            else stack.Push(ch);
                            break;

                        case '[':
                            if (ch == ']') stack.Pop();
                            else stack.Push(ch);
                            break;

                        case '(':
                            if (ch == ')') stack.Pop();
                            else stack.Push(ch);
                            break;

                        default:
                            stack.Push(ch);
                            break;
                    }
                }
            }

            return stack.Count == 0 ? "YES" : "NO";
        }
    }
}
