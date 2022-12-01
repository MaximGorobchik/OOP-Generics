using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_0.Generic_Box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputline = new Box<string>(Console.ReadLine());
            Console.WriteLine(inputline);
        }
    }
}
