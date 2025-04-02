using ATMWithMethods;

 

int pin;

bool CurPin;

string userpin = "1234";

var sbal = 5000;

var cbal = 500;

string pinString;

 

Console.WriteLine("Welcome to the UWM Bank ATM......");

//Console.WriteLine("Please enter 4 digit pin: ");

do

{

    Console.WriteLine("Please enter 4 digit pin: ");

    pinString = Console.ReadLine();

 

    CurPin = int.TryParse(pinString, out pin);

    if (!CurPin || userpin != pinString)

    {

        Console.WriteLine($"You have entered \"{pinString}\" which is In-correct pin");

    }

    else

    {

        Console.WriteLine("Thank you for providing correct 4 digit pin");

        Console.WriteLine("Please select option which account you like to access...");

        Console.WriteLine("Please input 1 for Savings Account");

        Console.WriteLine("Please input 2 for Checking Account");

 

        char accSelect = Console.ReadKey().KeyChar;

        Console.WriteLine();

 

        if (accSelect == '1')

        {

            savingAccount savingAcc = new savingAccount();

            savingAcc.saving(sbal);

 

 

        }

        else

            if (accSelect == '2')

        {

            checkingAccount checkingAcc = new checkingAccount();

            checkingAcc.checking(cbal);

        }

        else

        {

            Console.WriteLine("Please provide correct selection");

        }

    }

 

}

while ((String.IsNullOrEmpty(pinString)) || (pinString ==" ") || (pinString.Length != 4));

 

 



 

 



 





 

 



 