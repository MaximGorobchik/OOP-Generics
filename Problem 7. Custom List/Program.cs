using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Custom_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> customlist = new CustomList<string>();
            string inputline = Console.ReadLine();
            while (!inputline.Equals("END"))
            {
                var info = inputline.Split();
                if (info[0].Equals("Add"))
                {
                    customlist.Add(info[1]);
                }
                if (info[0].Equals("Remove"))
                {
                    customlist.Remove(int.Parse(info[1]));
                }
                if (info[0].Equals("Contains"))
                {
                    Console.WriteLine(customlist.Contains(info[1]));
                }
                if (info[0].Equals("Swap"))
                {
                    customlist.Swap(int.Parse(info[1]), int.Parse(info[2]));
                }
                if (info[0].Equals("Min"))
                {
                    Console.WriteLine(customlist.Min());
                }
                if (info[0].Equals("Max"))
                {
                    Console.WriteLine(customlist.Max());
                }
                if (info[0].Equals("Print"))
                {
                    customlist.Print();
                }
                if (info[0].Equals("Greater"))
                {
                    Console.WriteLine(customlist.CountGreaterThan(info[1]));
                }
                inputline = Console.ReadLine();
            }
        }
    }
}
