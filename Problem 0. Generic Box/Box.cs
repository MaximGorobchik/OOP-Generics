using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_0.Generic_Box
{
    public class Box<T>
    {
        public Box(T something) 
        {
            this.Something = something;
        }
        private T Something;
        public override string ToString()
        {
            return $"{this.Something.GetType().FullName}: {this.Something}";
        }
    }
}
