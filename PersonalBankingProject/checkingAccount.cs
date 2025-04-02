using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ATMWithMethods

{



    public class checkingAccount

    {

        int balance;

        public void checking(int curBal)

        {

            Console.WriteLine("You have selected to view Checking account details");

            Console.WriteLine("Please select 1 to See Balance");

            Console.WriteLine("Please select 2 for Quick Withdraw");

            Console.WriteLine("Please select 3 for Withdraw");

            Console.WriteLine("Please select 4 for Deposit");

            char cTransSelect = Console.ReadKey().KeyChar;

            Console.WriteLine();

            Banking bank = new Banking();

            balance = curBal;



            // call banking clas and method based on option selected

            if (cTransSelect == '1')

            {

                bank.printBalance(curBal, "Checking");

            }

            else

            if (cTransSelect == '2')

            {

                balance = bank.widthdraw(curBal, 2, "Checking");

            }

            else

            if (cTransSelect == '3')

            {

                balance = bank.widthdraw(curBal, 3, "Checking");

            }

            else

            if (cTransSelect == '4')

            {

                balance = bank.deposit(curBal, "Checking");

            }

            else

            {

                Console.WriteLine("Please make wise selection.");

            }



        }



    }



}