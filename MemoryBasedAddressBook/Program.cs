
var addressBook = new AddressBook();

List<Contact> cachedContacts= new List<Contact>();

int count = 4;
for(int i = 0; i < count; i++)
{
    string firstName = string.Empty;
    string lastName = string.Empty;
    string phone = string.Empty;
    string email = string.Empty;

    Console.WriteLine("Enter firstname");
    firstName = Console.ReadLine();
    if (string.IsNullOrEmpty(firstName))
    {
        Console.WriteLine("You entered null");
    }
    else
    {
        Console.WriteLine("Enter lastname");
        lastName = Console.ReadLine();

        Console.WriteLine("Enter the phone number");
        phone = Console.ReadLine();

        Console.WriteLine("Enter the email");
        email = Console.ReadLine();

        var contact = new Contact(firstName, lastName, phone, email);
        cachedContacts.Add(contact);
        addressBook.AddContact(contact);
        Console.WriteLine();
       
    }


}

Console.WriteLine("Printing Contacts");
addressBook.PrintContacts();
Console.WriteLine();

// Sorting
Console.WriteLine("Sorting Contacts");
addressBook.SortContacts();
addressBook.PrintContacts();
Console.WriteLine();

// Removing Contact
for (int i = 0; i < count; i++)
{
    Console.WriteLine("Removing contact " + cachedContacts[i]);
    addressBook.RemoveContact(cachedContacts[i]);
    Console.WriteLine();
    addressBook.PrintContacts();
}
