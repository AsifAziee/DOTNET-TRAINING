int num = 0;
int n = 5;

Random rd = new Random();
int rand_num = rd.Next(0, 100); // random number generated between (0-100)


for (int i = 0; i <= n - 1; i++)
{
    Console.WriteLine("Enter the number");
    num = Convert.ToInt16(Console.ReadLine());
    int chances = (n - 1) - i ;
    Console.WriteLine($"Remainig chances : {chances}");
    if (chances == 0)
    {
        Console.WriteLine("You Lost...!Better luck next time");
    }

    if (rand_num == num)
    {
        Console.WriteLine("Yes..!, You have found it.");
        break;
    }
    if (num < rand_num)
    {
        Console.WriteLine($"Guessed number is greater than {num}");
    }
    else
    {
        Console.WriteLine($"Guessed number is lesser than {num}");
    }
}

Console.WriteLine($"The answer was{rand_num}"); // random number

  
