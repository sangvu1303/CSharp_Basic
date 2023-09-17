using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInput
{
    internal class output
    {
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;

            Console.WriteLine("a + b = " + sum); // c1
            Console.WriteLine("a + b = {0}" , sum); // c2.1
            Console.WriteLine("{0} + {1} = {2}" ,a,b,sum); // c2.2 gán luôn giá trị vào output
            Console.WriteLine($"{a} + {b} = {sum}"); // c3 gán luôn giá trị vào output, nên dùng
        }
    }
}
