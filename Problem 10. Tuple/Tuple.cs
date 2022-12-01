using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Tuple
{
    public class Tuple<T1,T2>
    {
        private T1 item;
        private T2 item2;
        public Tuple(T1 item1, T2 item2)
        {
            this.item= item1;
            this.item2= item2;
        }

    }
}
