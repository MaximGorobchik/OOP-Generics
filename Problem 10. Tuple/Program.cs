using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split();
            var firstname_lastname = $"{input1[0]} {input1[1]}";
            var adress = input1[2];
            new Tuple<string, string>(firstname_lastname,adress);
            Console.WriteLine($"{firstname_lastname} -> {adress}");

            var input2 = Console.ReadLine().Split();
            var name = input2[0];
            var liters_of_beer = int.Parse(input2[1]);
            new Tuple<string, int>(name, liters_of_beer);
            Console.WriteLine($"{name} -> {liters_of_beer}");

            var input3 = Console.ReadLine().Split();
            var integer = int.Parse(input3[0]);
            var Double = double.Parse(input3[1]);
            new Tuple<int,double>(integer, Double);
            Console.WriteLine($"{integer} -> {Double}");
        }
    }
}
