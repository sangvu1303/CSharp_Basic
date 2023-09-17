using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    internal class compare
    {
        static void Main()
        {
            // == != <= >= > < 
            int a = 100, b = 200;
            bool isGreater = a > b;
            bool isLess = a < b;
            bool isGreaterOrEqual = a >= b;
            bool isLessOrEqual = a <= b;

            Console.WriteLine(isGreater);
            Console.WriteLine(a!=b);
        }
    }
}
