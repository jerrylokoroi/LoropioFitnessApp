// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello what is your first name ?");
string firstName = Console.ReadLine();
Console.WriteLine("Hello what is your last name ?");
string lastName = Console.ReadLine();

// Dialog myDialog = new Dialog(); 
string gretings = Dialog.SayHello(firstName, lastName);
Console.WriteLine(gretings);
