
// ******* SIMPLE ATM MACHINE  *******

int cardNumber = 12345;
int pinNumber = 1234;
int balance = 0;
int value = 0;
int amount = 0;


void UserMenu()
{
    Console.WriteLine();
    Console.WriteLine("Press 1 TO Check balance :");
    Console.WriteLine("Press 2 To Withdraw the amount :");
    Console.WriteLine("Press 3 To Deposit the amount :");
    Console.WriteLine("Press 4 to QUIT..!");
    Console.WriteLine();
    Console.Write("Enter the value :");
    value = Convert.ToInt32(Console.ReadLine());
}


int UserDeposit(int amount)
{
    balance += amount;
    Console.WriteLine("Deposite Successfully Completed");
    return balance;
}


void UserBalance()
{
    Console.WriteLine($"Current balance is: {balance}");
}


int UserWithdraw(int amt)
{
    balance -= amt;
    Console.WriteLine("\nTransaction Successfully Completed");
    return balance;
}

try
{
    Console.WriteLine("Please Enter your 5 digit card number : ");
    var userNumber = Convert.ToString(Console.ReadLine());

    if (userNumber.Length != 5)    // Checking whether the number is 5 digit.
    {
        Console.WriteLine("You should enter 5 Digit number for your card");
        return;
    }

    Console.WriteLine("Please enter the secret 4 digit PIN : ");
    int userPin = Convert.ToInt32(Console.ReadLine());
    int userdata = Int32.Parse(userNumber); // Converting checked string to integer.

    if (cardNumber == userdata && pinNumber == userPin) // Checking the access.
    {
        Console.WriteLine("Access granted");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Denied");  // Access denied.
        return;
    }
    while (!value.Equals(4))
    {
        UserMenu();
        Console.Clear();
        switch (value)
        {
            case 1:
                Console.WriteLine();
                UserBalance();
                break;
            case 2:
                Console.Write("Enter amount : ");
                amount = Convert.ToInt32(Console.ReadLine());
                if (amount > balance)
                {
                    Console.WriteLine("Your account does not have sufficient balance");
                }
                else
                {
                    UserWithdraw(amount);
                    UserBalance();
                    break;
                }
                break;
            case 3:
                Console.Write("Enter amount : ");
                amount = Convert.ToInt32(Console.ReadLine());
                UserDeposit(amount);
                UserBalance();
                break;

            case 4:
                Console.WriteLine("Thank you for using,..!");
                break;
            default:
                Console.WriteLine("Invalid Choice ");
                break;
        }
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
