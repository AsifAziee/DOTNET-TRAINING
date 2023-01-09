
string fullname = "";
int age = 0;
double salary = 0.0f;
char gender = char.MinValue;
bool working = false;    

Console.Write("Please enter your name");
fullname = Console.ReadLine();

Console.Write("Please enter your age");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary");
salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter your gender");
gender = Convert.ToChar(Console.ReadLine());


Console.WriteLine("The name entered is " + fullname);
Console.WriteLine($"age entered {age}");
Console.WriteLine($"salary entered {salary}");
Console.WriteLine($"gender entered {gender}");
Console.WriteLine("currently woking " + working);