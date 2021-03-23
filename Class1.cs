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
        string r = "";
        int n = 5;
        void GetT() {; }
    }
}
