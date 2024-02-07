using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SupriyaCSharpTraining
{
    public class Nullablevalues
    {
        public static void Nullabletypes()
        {
            //If value is null
            bool? AreYouMajor = null;

            if (AreYouMajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if (AreYouMajor == false)
            {
                Console.WriteLine("User is not Major");
            }
            else
            {
                Console.WriteLine("User did not answer the question") ;
            }
        }
        public static void Nullabletypes2()
        {
            //If value is true
            bool? AreYouMajor = true;

            if (AreYouMajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if (AreYouMajor == false)
            {
                Console.WriteLine("User is not Major");
            }
            else
            {
                Console.WriteLine("User did not answer the question");
            }
        }
        public static void Nullabletypes3()
        {
            //If value is false
            bool? AreYouMajor = false;

            if (AreYouMajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if (AreYouMajor == false)
            {
                Console.WriteLine("User is not Major");
            }
            else
            {
                Console.WriteLine("User did not answer the question");
            }
        }

        //Implict nullable values to convert Explict nullable values
        public static void ConvertNullabletype4()
        {
            int? TicketOnSale = 0;
            int AvaliableTickets;
            
            if(TicketOnSale ==null)
            {
                AvaliableTickets = 0;
            }
            else
            {
                AvaliableTickets=TicketOnSale.Value;
                //AvaliableTickets=(int)TicketOnSale; 
            }
            Console.WriteLine("AvaliableTickets ={0}",AvaliableTickets);
        }
    }
}
