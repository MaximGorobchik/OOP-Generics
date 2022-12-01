using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Generic_Swap_Method_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var inputline = int.Parse(Console.ReadLine());
                list.Add(inputline);
            }
            var index = Console.ReadLine().Split().Select(int.Parse).ToList();
            Swap<int>(list, index[0], index[1]);
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
