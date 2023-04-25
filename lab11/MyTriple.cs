using lab11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class MyTriple<T1, T2, T3> : MyPair<T1, T2>
    {
        public T3 third;

        public MyTriple(T1 first, T2 second, T3 third) : base(first, second)
        {
            this.third = third;
        }
    }
}
