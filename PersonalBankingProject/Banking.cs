using System;

using System.Collections.Generic;

using System.Linq;

using System.Security.Principal;

using System.Text;

using System.Threading.Tasks;



namespace ATMWithMethods

{

    public class Banking

    {



        int res = 0;

        bool chek = false;

        string inputamount = "";

        int amt = 0;

        //String Account = "";



        public void printBalance(int bal, String Account)

        {

            Console.WriteLine($"Your {Account} account balnace is {bal}");

            receipts(Account, "Balance", bal, amt, 0);

        }

        public int deposit(int curBal, String Account)

        {

            Console.WriteLine("We are happy to help you to make deposit. :)");

            Console.WriteLine("Please enter amount for deposit.");

            inputamount = Console.ReadLine();

            bool isint = int.TryParse(inputamount, out amt);



            if (amt < 0 && isint)

            {

                Console.WriteLine("Invalid Amount!");

                return res;

            }

            else if (isint)

            {

                res = amt + curBal;

                receipts(Account, "Deposit", curBal, amt, res);

            }

            else

            {

                Console.WriteLine("Please Enter Corrct valid amount for deposit");

                res = curBal;

            }



            return res;



        }



        public int widthdraw(int curBal, int widthdrawoption, String Account)

        {

            if (widthdrawoption == 3)

            {

                Console.WriteLine("We will help you with withdraw.");

                Console.WriteLine("Please enter amount for Withdraw.");

                inputamount = Console.ReadLine();



                deductbal(Account, "Withdraw", curBal, inputamount);



            }

            else

            {



                Console.WriteLine("You will be withdraw $20 [1]Yes or [2]no?");

                string qwidtraw = Console.ReadLine();

                if (!String.IsNullOrEmpty(qwidtraw))

                {

                    int qsel = 0;

                    bool Cursel = int.TryParse(qwidtraw, out qsel);



                    if (qsel == 1)

                    {

                        deductbal(Account, "QuickWithdraw", curBal, "20");

                    }

                    else

                    {

                        Console.WriteLine("\nThank you for banking with us.........");

                        Console.WriteLine("have a wonderful day");

                    }

                }



            }

            return res;

        }



        public int deductbal(String Acc, String Tran, int curBal, String dedbal)

        {

            if (int.TryParse(dedbal, out amt))

            {

                if (amt > curBal)

                {

                    Console.WriteLine("Insufficient Fund sorry!");

                    //return res;



                }

                else

                if (amt < 0)

                {

                    Console.WriteLine("Invalid Amount!");

                    return res;

                }

                else

                {

                    res = curBal - amt;



                    receipts(Acc, Tran, curBal, amt, res);



                }

            }

            else

            {

                Console.WriteLine("Please Enter valid amount for Withdraw");

                res = curBal;

            }

            return res;

        }



        public void receipts(String Acc, String tSel, int cBal, int tBal, int nBal)

        {

            Console.WriteLine("Do you want receipt?");

            Console.WriteLine("Please select Y for Yes and N for No");

            char rsel = Console.ReadKey().KeyChar;



            if (rsel.ToString().ToUpper() == "Y")

            {

                printReceipt receipts = new printReceipt(Acc, tSel, cBal, tBal, nBal);

            }

            else

            {

                Console.WriteLine("\nThank you for banking with us.........");

            }

        }

    }

}