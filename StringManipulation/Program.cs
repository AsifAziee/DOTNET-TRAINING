string firstName = "Mohammed";
string lastName = "Asif";

string fullName = firstName+ " " + lastName;

//Length of a string
int length = fullName.Length;
Console.WriteLine($"First name is {length} letters");

//Replace string part
string newFirstName = firstName.Replace("med", "aaa");
Console.WriteLine($"New first name is {newFirstName}");

//Split
string toSplit = "Asif , Jenu, hari, savanth, abhijith ";
string[] names = toSplit.Split(", ");
for(int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

//compare
string nullString = null;
string emptyString = "";
string whiteSpaceString = " ";

if(string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("nullString is empty or null");
}

if (string.IsNullOrEmpty(whiteSpaceString))
{

}

//int res = firstName.CompareTo(lastName);
if (firstName.CompareTo(lastName) == 0)
{
    Console.WriteLine("firstName and lastName are wqual");
}