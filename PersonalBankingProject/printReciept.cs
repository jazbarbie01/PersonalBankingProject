using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

 

namespace ATMWithMethods

{

    public class printReceipt

    {

        public printReceipt(string acsel, String tsel, int curBal,int tranBal,int newBal)

        {

            Console.WriteLine("\n" + DateTime.Now);

          

            Console.WriteLine($"this is {acsel} account details");

              

            if (tsel=="Balance")

            {

                Console.WriteLine($"you have chosen to see {acsel} account balance.");

                Console.WriteLine($"Your {acsel} account balance is {curBal}");

            }

            else

            {

                Console.WriteLine($"you Choose to make {tsel}.:)");

                Console.WriteLine($"Your {acsel} account details as follows:");

                Console.WriteLine($"Current Balance is {curBal}");

                Console.WriteLine($"{tsel} Amount is {tranBal}");

                Console.WriteLine($"New Balance is {newBal}");

            }

           

            Console.WriteLine("Have a wonderful day");

        }

    }

}