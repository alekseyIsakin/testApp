using System;
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
        int n = 5;
        void GetT() {; }
    }
}
