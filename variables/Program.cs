using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Vu Quang Sang";
            int age = 23;
            Console.WriteLine("name :"+ fullName);
            Console.WriteLine("age :"+ age);

            int a = 20,b = 30;
            int sum = a + b;
            float div = (float)a / b;
            Console.WriteLine("a + b = " + sum);
            Console.WriteLine("a : b = " + div);
        }
    }
}
