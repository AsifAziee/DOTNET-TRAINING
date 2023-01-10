/*using System;

Console.WriteLine("Enter the first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int num2 = Convert.ToInt32(Console.ReadLine());

void Add(int a, int b)
{
    Console.WriteLine($"Addition: {a + b}");
}
Add(num1, num2);
Add(1, 3);

int GreaterThan(int a, int b, int c)
{
    int largest = a;
    if(b> largest)
    {
        largest= b;
    }
    if (c> largest) 
    {
        largest= c;
    }
    return largest;
}
int largest = GreaterThan(0, 15, 8);
    Console.WriteLine($"{largest}");

//Exception handling
Console.WriteLine("first number");
int num =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("second  number:");
int num4 =Convert.ToInt32(Console.ReadLine());
try
{
    double quotient = num / num4;
    Console.WriteLine($"result{quotient}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine($"Illegal operation {e.Message}");
}
catch (Exception ex)
{
    throw ex;
}
finally
{
    Console.WriteLine("Exited the program");
}*/


//Arrays
//initialization
int[] marks = new int[5];

//itearating array
for(int i = 0;i <marks.Length;i++)
{
    Console.WriteLine("Enter marks :");
    marks[i] = Convert.ToInt32(Console.ReadLine());
}

//print an array eements
for(int i=0;i<marks.Length;i++)
{
    Console.WriteLine(marks[i]);
}

string[] names = new string[] { "asif", "c#" };

//list
List<string> devs = new List<string>();
string dev = string.Empty;

while(!dev.Equals("-1"))
{
    Console.WriteLine("Enter the name of developer: ");
    dev = Console.ReadLine();
    if (dev != string.Empty && !dev.Equals("-1"))
    {
        devs.Add(dev);
    }
}
foreach (string name in devs)
{
    Console.WriteLine(name);
}

