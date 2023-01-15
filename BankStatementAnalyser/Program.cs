using System.Globalization;


Statement bankStatement = new Statement();

void ReadFromFile()
{
    string[] lines = System.IO.File.ReadAllLines(@"C:\Users\test\Downloads\testdoc\test.csv");

    string[] column;
    string[] date;


    Console.WriteLine("Current Bank Statements: ");
    Console.WriteLine();
    foreach (string line in lines)
    {

        Console.WriteLine(line);
    }
    Console.WriteLine();
    Console.WriteLine("Press any key for.");
    Console.WriteLine();
    Console.WriteLine("Total Account Balance:");
    Console.WriteLine("Net Balance on Specific month");
    Console.WriteLine();
    System.Console.ReadKey();

    int index = 0;
    while (index < lines.Length)
    {
        column = lines[index].Split(",");
        date = column[0].Split("-");
        Console.WriteLine();

        double amount = Convert.ToDouble(column[1]);
        DateTime transactionDate = DateTime.Parse($"{date[2]}/{date[1]}/{date[0]}", CultureInfo.InvariantCulture);
        DateOnly dateOnly = DateOnly.FromDateTime(transactionDate);

        BankTransaction transaction = new BankTransaction(dateOnly, amount);
        bankStatement.AddStatement(transaction);
        index++;
    }
}
//void ParticularTransaction()
//{
//    x[]= bankStatement.PrintBalance();
//    foreach (var transaction in x)
//    {

//    }
//}
try
{
    ReadFromFile();
    Console.WriteLine($"Your current total Balance is :{bankStatement.GetBalance()}");
    
}
catch (Exception)
{
    throw;
}
finally
{
    Console.WriteLine("Program Exited..!");
}

