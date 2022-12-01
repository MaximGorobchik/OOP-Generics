using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Custom_List_Sorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            CustomList<string> customlist = new CustomList<string>(list);
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
                    Console.WriteLine(string.Join(Environment.NewLine,list));
                }
                if (info[0].Equals("Greater"))
                {
                    Console.WriteLine(customlist.CountGreaterThan(info[1]));
                }
                if (info[0].Equals("Sort"))
                {
                    customlist.List_Sort();
                }
                inputline = Console.ReadLine();
            }
        }
    }
}
