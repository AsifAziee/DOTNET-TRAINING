/*string firstName = string.Empty;
string lastName = string.Empty;
string middleName = string.Empty;
double salary = 0.0;

Console.WriteLine("Enter firstname");
firstName = Console.ReadLine();

Console.WriteLine("Enter middlename");
middleName = Console.ReadLine();

Console.WriteLine("Enter lastname");
lastName = Console.ReadLine();

Person person = new Person(firstName, lastName, salary);


//Person person = new Person();
//person.FirstName = FirstName;
//person.LastName = LastName;
//person.SetSalary();

if(string.IsNullOrEmpty(middleName))
{
    Console.WriteLine($"The name Entered is {person.GetFullName()}");

}
else
{
    Console.WriteLine($"The entered is {person.GetFullName(middleName)}");
}
//Console.WriteLine($"The name entered is {person.GetFullName()}");
Console.WriteLine($"The Salary is {person.GetSalary}");*/


Triange triangle = new Triange() { Height= 10, Width = 20 };
Console.WriteLine($"Area of trianagle {triangle.CalculateArea()}");

//Square square= new Square() { Height = 10, Width = 25};
//Console.WriteLine(square.CalculateArea());

Rectangle rectangle = new Rectangle() { Height= 125, Width= 25 };
Console.WriteLine($"Area of rectangle {rectangle.CalculateArea()}");


Rectangle square = new Rectangle() { Height=5, Width= 5};
Console.WriteLine($" Area of square{square.IsSquare()}");
