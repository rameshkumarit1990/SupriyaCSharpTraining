using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupriyaCSharpTraining
{
    public class ReadFromConsole
    {
        public static void Readconsole()
        {
            //Prompt the user for her name
            Console.WriteLine("Please enter my name");

            //Readconsole the name from console
            string Username = Console.ReadLine();


            //Concatination of two strings
            Console.WriteLine("Hello {0}",Username);


            //Console.WriteLine("Hello" +  Username);
        }
    }
}
