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
<<<<<<< HEAD
        string r = "";
=======
        int n = 5;
        void GetT() {; }
>>>>>>> 9d31978014478be69d3048edeb58591a83bb428b
    }
}
