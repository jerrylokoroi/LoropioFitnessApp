using PersonLibrary;

Person person = new Person
{
    FirstName = "Jerry",
    LastName = "Lokoroi",
    Age = 23,
    EmailAddress = "jerry.ekuwom@learninglions.org"
};

string fullName = person.GetFullName();
Console.WriteLine($"Full Name: {fullName}");
