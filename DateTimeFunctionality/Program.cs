//DateTime related fuction
//Empty date

using System.Globalization;
using System.Net.WebSockets;

DateTime date = new DateTime();
Console.WriteLine(date);

//Create DateTime from date
DateTime dateOfbirth = new DateTime(1997, 1, 25);
Console.WriteLine($"Date is : {dateOfbirth}");

//Create date from String
DateTime parsedDate = DateTime.Parse("3/31/2000", CultureInfo.InvariantCulture);
Console.WriteLine($"Parsed date is {parsedDate}");

// Create DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine($"Current time is {now}");

// Date to ticks
Console.WriteLine($"Current time is {now}");

// Add hours to DateTime
Console.WriteLine($"2 hours from now is {now.AddHours(2)}");

//DateOnly
DateOnly dob = DateOnly.FromDateTime(dateOfbirth);

// TimeOnly
TimeOnly tob = TimeOnly.FromDateTime(dateOfbirth);
