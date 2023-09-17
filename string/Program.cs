using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "     hello world   ";
            Console.WriteLine(msg);
            Console.WriteLine(msg.Length); //độ dài
            Console.WriteLine(msg.ToUpper()); //viết hoa 
            Console.WriteLine(msg.Trim()); // loại bỏ khoảng trắng
            Console.WriteLine(msg.Contains("o"));//xem trong str có ký tự o không,trả về true false
            Console.WriteLine(msg.IndexOf('o'));//tìm vị trí của o đầu tiên
            Console.WriteLine(msg.LastIndexOf('o'));//tìm vị trí của o cuối cùng
        }
    }
}
