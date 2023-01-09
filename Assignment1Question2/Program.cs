Console.WriteLine("Enter the first number");
double a = 0.0;
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the second number");
double b = 0.0;
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the third number");
double c = 0.0;
c = Convert.ToDouble(Console.ReadLine());

var value = (((a + b) / c) *a);


Console.WriteLine($"Result for the equation is {value}");
