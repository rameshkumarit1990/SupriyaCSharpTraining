using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupriyaCSharpTraining
{
    public class ImplicitExplicit
    {
        public static void Implicit()
        {
            int i = 10;

            float f = i;

            Console.WriteLine(f);
        }
        public static void Explicit()
        {
            float f = 123.34355F;

            int i = (int)f;

            Console.WriteLine(i);
        }
        public static void Stringconvert()
        {
            string floatnumber = "123.5";

            float number = Convert.ToSingle(floatnumber);

            Console.WriteLine(number);


        }



    }

}
