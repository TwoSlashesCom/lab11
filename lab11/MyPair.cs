﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class MyPair<T1, T2>
    {
        public T1 first;
        public T2 second;

        public MyPair(T1 first, T2 second)
        {
            this.first = first;
            this.second = second;
        }
    }
}
