//Encapsulation
//class Person
//{
  /*  public string FirstName { get; set; }
    public string LastName { get; set; }*/
  class Person 
{ 
    public Person(string firstName, string lastName, double salary)         // Immutable
    {
        FirstName = firstName;
        LastName = lastName;
        _salary= salary;
    }
    //properties
    public string FirstName { get; }      // Immutable properties
    public string LastName { get;  }
    //Fields
    private double _salary;

    //Methods
    public void SetSalary()
    {
        _salary = 1000;
    }

    public double GetSalary()
    {
        return _salary;
    }
    // Method Overloading
    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }
    public string GetFullName(string middleName)
    {
        return FirstName + " "+ middleName +" "+ LastName;
    }

}