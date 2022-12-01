using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Generic_Count_Method_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Box<string> box = new Box<string>(list);
            var n = int.Parse(Console.ReadLine());
            for (int i=0;i<n; i++) 
            {
                var inputline = (Console.ReadLine());
                list.Add(inputline);
            }
            string given_element = Console.ReadLine();
            Console.WriteLine(box.Count(given_element));
        }
    }
}
