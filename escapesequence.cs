using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SupriyaCSharpTraining
{
    public class escapesequence
    {
        //string datatype to a variable
        public static void stringmethod()
        {
            string Message = "Good Evening";
            Console.WriteLine(Message);

        }

        //Escape squence to a string
        public static void Escapemethod() 
        {
            string str = "\"Supriya\"";
            string name = "\n\'My name\'";
            string Animal = "\ncat,\nrat,\nLion";

            string concatenation = str + name + Animal;

            Console.WriteLine(concatenation);
        }

        //Verbatim literal to a string
        public static void Verbatim()
        {
            string str = @"\Supriya\";
            string name = @"\n\'My name\'";
            string Animal = @"\ncat,\nrat,\nLion";

            string concatenation = str + name + Animal;

            Console.WriteLine(concatenation);
        }

    }
}
