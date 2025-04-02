using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ATMWithMethods

{

    public class savingAccount

    {

        int balance = 0;

        public void saving(int curBal)

        {

            Console.WriteLine("You have selected to view Savings account details");

            Console.WriteLine("Please select 1 to See Balance");

            Console.WriteLine("Please select 2 for Deposit");

            Console.WriteLine("Please select 3 for Withdraw");

            Banking bank = new Banking();



            balance = curBal;



            char sTransSelect = Console.ReadKey().KeyChar;

            Console.WriteLine();

            // call banking clas and method based on option selected

            if (sTransSelect == '1')

            {

                bank.printBalance(curBal, "Saving");

            }

            else

            if (sTransSelect == '2')

            {

                balance = bank.deposit(curBal, "Saving");

            }

            else

            if (sTransSelect == '3')

            {

                balance = bank.widthdraw(curBal, 3, "Saving");

            }

            else

            {

                Console.WriteLine("Please make wise selection.");

            }

        }

    }

}