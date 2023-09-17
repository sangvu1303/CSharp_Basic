using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = Math.Max(10, 25);
            int min = Math.Min(10, 25);
            Console.WriteLine(max);

            float x = -255.255f;
            float y = Math.Abs(x);
            Console.WriteLine(y);

            double a = Math.Sqrt(500);
            Console.WriteLine(a);
            
            Console.WriteLine("PI = " + Math.PI);
        }
    }
}
