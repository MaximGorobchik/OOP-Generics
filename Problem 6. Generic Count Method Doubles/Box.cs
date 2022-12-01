using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Generic_Count_Method_Doubles
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> list;
        public Box(List<T> list) 
        { 
            this.list = list;
        }
        public int Count(T givenelemet)
        {
            var count = 0;
            foreach (var item in list)
            {
                if(givenelemet.CompareTo(item) < 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
