
// ******* SIMPLE ATM MACHINE  *******

int cardNumber = 12345;
int pinNumber = 1234;
int balance = 1000;
int currentBalance = 0;


int withdraw()
{
    Console.WriteLine("Enter the amount to Withdraw :");
    int amt = Convert.ToInt32(Console.ReadLine());
    if (balance >= amt)
    {
        if (amt % 100 == 0)
        {
            Console.WriteLine($"Collect the amount: {amt}");
            currentBalance = balance - amt;
           
        }
        else
        {
            Console.WriteLine("Please enter the amount to withdraw in the multiples of 100 ");
        }
    }
    else
    {
        Console.WriteLine("Your account does not have sufficient balance");
    }
    return currentBalance;
}


int deposit()
{
    Console.WriteLine("Enter the amount to Deposit :");
    int deposit = Convert.ToInt32(Console.ReadLine());
    currentBalance = balance + deposit;
    return balance;
}
try
{
    Console.WriteLine("Please Enter your 5 digit card number :");
    var userNumber = Convert.ToString(Console.ReadLine());
    if (userNumber.Length != 5)    // Checking whether the number is 5 digit.
    {
        Console.WriteLine("You should enter 5 Digit number for your card");
        return;
    }
    Console.WriteLine("Please enter the secret 4 digit PIN :");
    int userPin = Convert.ToInt32(Console.ReadLine());
    int userdata = Int32.Parse(userNumber); // Converting checked string to integer.
    if (cardNumber == userdata && pinNumber == userPin) // Checking the access.
    {
        Console.WriteLine("Access granted");
        Console.WriteLine();
        Console.WriteLine("What would you like to do..?");
        Console.WriteLine("Press 1 TO Check balance :");
        Console.WriteLine("Press 2 To Withdraw the amount :");
        Console.WriteLine("Press 3 To Deposit the amount :");
        Console.WriteLine("Press 4 to QUIT..!");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Denied");  // Access denied.
        return;
    }
        Console.Write("Enter the value :");
        int value = Convert.ToInt32(Console.ReadLine());
        switch (value)
        {
            case 1:
                Console.WriteLine($"Current balance is: {balance}");
                break;
            case 2:
            withdraw();
            Console.WriteLine($"Now your current balance is {currentBalance}");
            break;
            case 3:                        
                deposit();
                Console.WriteLine($"The current balance is: {currentBalance}");
            break;
            case 4:
                Console.WriteLine("You choose to exit..!");
                break;
            default:
                Console.WriteLine("Invalid");
                break;
        }

}
catch
{
    Console.WriteLine("You Entered an Invalid string, Please enter Integer Value");
}
finally
{
    Console.WriteLine("Exited the program..!");
}
