using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupriyaCSharpTraining
{
    public class Operators
    {
        //Arthemetic operator
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
        //Relational Operators
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
        //Logical operators
        public static void Logicaloperator()
        {
            int m = 34;
            int n = 12;

            Console.WriteLine(m>n && n<m);
            Console.WriteLine(m < n || n>m);
            Console.WriteLine(!(m < n));
        }

        public static void RunProgram() 
        {
            Arthemeticoperator();
            Relationaloperator();
            Logicaloperator();


        }

    }
}
