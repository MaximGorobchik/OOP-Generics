using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Generic_Box_of_String
{
    public class Box<T>
    {
        private T something;
        public Box(T x) 
        { 
            this.something = x;
        }
        public override string ToString()
        {
            return $"{this.something.GetType()}: {this.something}";   
        }
    }
}
