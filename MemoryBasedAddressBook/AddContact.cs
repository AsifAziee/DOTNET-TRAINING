public class AddressBook
{
    // Fields
    private readonly List<Contact> _contacts;

    public AddressBook()
    {
        _contacts = new List<Contact>();
    }

    public void RemoveContact(Contact contact)
    {
        _contacts.Remove(contact);
    }
    public void AddContact(Contact contact) 
    {
        _contacts.Add(contact);
    }
    public void SortContacts()
    {
        _contacts.Sort((a, b) => a.FirstName.CompareTo(b.FirstName));
    }
    public void PrintContacts()
    {
        foreach (var items in _contacts)
        {
            Console.WriteLine(items);
        }
    }
}