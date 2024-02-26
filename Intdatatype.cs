using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupriyaCSharpTraining
{
    public class Intdatatype
    {
        public static void RunProgram()
        {
            Inttype();
            Inttype2();
            Inttype3();
        }
        public static void Inttype()
        {
            //intdata type int add values between two variables
            int x = 10;
            int y = 20;
             Console.WriteLine(x + y);
        }
        public static void Inttype2()
        {
            //int data type show the value of an int 
            int MyNum = 10000;
            Console.WriteLine(MyNum);
        }
        public static void Inttype3()
        {
            //int data type of Min value and Max value
            int i = 0;
            Console.WriteLine("Min ={0}",int.MinValue);
            Console.WriteLine("Max ={0}", int.MaxValue);
        }

    }
}
