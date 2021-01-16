using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries_and_Maps
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneRegister = new Dictionary<string, string>();
            int numEntries = int.Parse(Console.ReadLine());
            for (int i = 0; i < numEntries; i++)
            {
                string[] line = Console.ReadLine().Split();
                if (!phoneRegister.ContainsKey(line[0]))
                {
                    phoneRegister.Add(line[0], line[1]);
                }
            }
            
            while(true){
                var name=Console.ReadLine();
                if(String.IsNullOrEmpty(name)){
                    break;
                }
                if(phoneRegister.ContainsKey(name)){
                    string value = "";
                    if (phoneRegister.TryGetValue(name, out value))
                    {
                        Console.WriteLine("{0}={1}", name,value);
                    }
                    
                }else{
                    Console.WriteLine($"Not found");
                }
            }

        }
    }
}
