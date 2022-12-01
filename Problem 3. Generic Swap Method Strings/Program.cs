using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Generic_Swap_Method_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string inputline = (Console.ReadLine());
                list.Add(inputline);
            }
            var index = Console.ReadLine().Split().Select(int.Parse).ToList();
            Swap<string>(list, index[0], index[1]);
            for (int i=0;i<list.Count;i++)
            {
                Console.WriteLine($"{list[i].GetType()} : {list[i]}");
            }
        }
        static void Swap<T>(List<T> list, int firstindex, int secondindex)
        {
            var temp = list[firstindex];
            list[firstindex] = list[secondindex];
            list[secondindex] = temp;
        }
    }
}
