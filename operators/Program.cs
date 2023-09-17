using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {   // + - * / % -- ++
            float a = 100.25f;
            int b = 200;
            float sum = a + b;

            // int,long,float,double
            string msg = "hello";
            string str = msg + a;
            Console.WriteLine(str);

            int x = 1, y = 2;
            Console.WriteLine(1.0*x / y);

            x++;y--;
            Console.WriteLine("x = " + x + ", y = " + y);
        }
    }
}
