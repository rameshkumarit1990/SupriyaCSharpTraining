using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SupriyaCSharpTraining
{
    public class WriteReadConsole
    {
        public static void WriteRead()

        {
            Console.WriteLine("Please enter my firstname");
            string FirstName=Console.ReadLine();

            Console.WriteLine("Please enter my lastname");
            string LastName=Console.ReadLine();

            //Placeholder syntax to print name with hello word
            Console.WriteLine("Hello {0} {1}",FirstName,LastName);

        }
    }
}
