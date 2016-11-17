using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Functions
    {


        private int AplusB(int a, int b)
        {
            return a + b;
        }

        private void Test1()
        {
            var summe = AplusB(1, 2);
        }

        private Func<int, int> AplusB_Funktional(int a)
        {
            return b => a + b;
        }

        private void Test2()
        {
            var summe = AplusB_Funktional(1)(2);
        }

        private int OnePlusMapTwo(Func<int, int> f)
        {
            return 1 + f(2);
        }

        private void Test3()
        {
            var result = OnePlusMapTwo(a => a * a);
        }


    }
}
