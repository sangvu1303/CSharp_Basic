using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // name,age,avg mark
            Console.Write("Nhap ho va ten : ");
            string fullName = Console.ReadLine();

            Console.Write("Nhap tuoi : ");
            //chuyen string sang int
            int age = Convert.ToInt32(Console.ReadLine()); // c1
            //int age = System.Int32.Parse(Console.ReadLine()); // c2

            Console.Write("Nhap diem TB : ");
            float avgMark = Convert.ToSingle(Console.ReadLine()); // c1
            //float avgMark = System.Single.Parse(Console.ReadLine()); // c2

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Hello, my name is " + fullName + " !!!");
            Console.WriteLine("I am " + age);
            Console.WriteLine("My avg mark is " + avgMark);

        }
    }
}
