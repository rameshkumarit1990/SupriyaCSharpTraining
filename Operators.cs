using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupriyaCSharpTraining
{
    public class Operators
    {
        public static void Arthemeticoperator()
        {
            int x = 12;
            int y = 3;

            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(x % y);
        }

        public static void Relationaloperator()
        {
            int x = 19;
            int y = 14;

            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(x <= y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x < y);
            Console.WriteLine(x > y);
        }
    }
}
