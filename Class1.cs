﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{
    ref struct TestClass<T>
    {
        Span<T> Tspan;
    }
    class Class1<T>
    {
        int try_ = 1;
        int tryt_ = 2;
    }
}
