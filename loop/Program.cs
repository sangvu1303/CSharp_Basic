using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hien thi cac so le nho hon hoac bang n");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <= n; i++)
            //{
            //    if(i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            Console.WriteLine("tinh tong trong doan a den b");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            Console.WriteLine($"tong tu {a} den {b} bang {sum}");
        }
    }
}
