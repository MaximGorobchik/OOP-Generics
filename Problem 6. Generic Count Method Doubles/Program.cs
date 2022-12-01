using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Generic_Count_Method_Doubles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();
            Box<double> box = new Box<double>(list);
            var n = int.Parse(Console.ReadLine());
            for (int i=0;i<n; i++) 
            {
                var inputline = double.Parse(Console.ReadLine());
                list.Add(inputline);
            }
            double given_element = double.Parse(Console.ReadLine());
            Console.WriteLine(box.Count(given_element));
        }
    }
}
