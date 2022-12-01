using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Generic_Box_of_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var inputline = new Box<int>(int.Parse(Console.ReadLine()));
                Console.WriteLine(inputline);
            }

        }
    }
}
