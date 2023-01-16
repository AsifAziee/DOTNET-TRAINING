using System.Data.Common;
using System;
using System.Globalization;
using System.Reflection;


Statement bankStatement = new Statement();
string[] lines = System.IO.File.ReadAllLines(@"C:\Users\test\Downloads\testdoc\test.csv");
string[] column;
string[] date;

void ReadFromFile()
{
    int index = 0;
    while (index < lines.Length)
    {
        column = lines[index].Split(",");
        date = column[0].Split("-");
        Console.WriteLine();

        double amount = Convert.ToDouble(column[1]);
        DateTime transactionDate = DateTime.Parse($"{date[2]}/{date[1]}/{date[0]}", CultureInfo.InvariantCulture);
        DateOnly dateOnly = DateOnly.FromDateTime(transactionDate);

        BankTransaction transaction = new BankTransaction(dateOnly, amount, column[2]);
        bankStatement.AddStatement(transaction);
        index++;

    }
}
void MonthlyBalance()
{
    //Console.WriteLine("enter date");
    //int month 
    DateOnly StartMonth = new DateOnly( 2022, 2 ,1);
    DateOnly EndMonth = new DateOnly(2022, 2, 28);
    double amount = bankStatement.GetBalanceOn(StartMonth, EndMonth);
    Console.WriteLine($"balance for month feb :{amount}");
}
try
{
    ReadFromFile();
    Console.WriteLine($"Current Statement :");
    Console.WriteLine();
    bankStatement.PrintBalance();
    Console.WriteLine();
    Console.WriteLine($"Your current total Balance is :{bankStatement.GetBalance()}");
    MonthlyBalance();

}
catch (Exception)
{
    throw;
}
finally
{
    Console.WriteLine("Program Exited..!");
}

