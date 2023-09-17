using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controls
{
    internal class ternaryOperator
    {
        static void Main(string[] args)
        {
            int time = 12;
            string msg = default;

            //if (time < 12)
            //{
            //    msg = "hello";
            //}
            //else
            //{
            //    msg = "goodbye";
            //}

            msg = (time < 12) ? "hello" : "goodbye";

            Console.WriteLine(msg);
        }
    }
}
