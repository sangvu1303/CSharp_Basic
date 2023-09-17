using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    internal class logicalOperator
    {
        static void Main()
        {
            // || && !
            int a = 200, b = 111, c = 300;

            //bool isOK = (a % 2 == 1) || (b % 2 == 1);
            bool isOK = (a % 2 == 1) && (b % 2 == 1);
            Console.WriteLine(isOK);

            bool isOdd = (c % 2 == 1);
            Console.WriteLine(!isOdd);
        }
    }
}
