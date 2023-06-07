Console.WriteLine("Please enter you name: ");
string lionName = Console.ReadLine();

Console.WriteLine("Hello " + lionName + ". " + "Welcome to the Loropio Fitness App.");

Console.WriteLine("Enter the name of your activity");
string activityName = Console.ReadLine();

Console.WriteLine("Enter the total distance covered on the activity");
string distanceCovered = Console.ReadLine();
double distance = double.Parse(distanceCovered);

Console.WriteLine("Enter the total time spent on the activity in the format HH:MM:SS");
string timeTaken = Console.ReadLine();
TimeSpan time = TimeSpan.Parse(timeTaken);

Console.WriteLine("Enter the date of the activity in the format MM/DD/YY");
string dateOfActivity = Console.ReadLine();
DateOnly date = DateOnly.Parse(dateOfActivity);

double averageSpeed = distance / (time.Hours * 3600 + time.Minutes + time.Seconds / 60);


Console.WriteLine("How did you feel after the activity: ");
Console.WriteLine("1. BAD");
Console.WriteLine("2. OK");
Console.WriteLine("4. GOOD");
Console.WriteLine("5. VERY GOOD");
Console.WriteLine("6. STRONG");
string afterActivityFeeling = Console.ReadLine();

switch (afterActivityFeeling)
{
    case "1":
        Console.WriteLine("BAD");
        break;
    case "2":
        Console.WriteLine("OK");
        break;
    case "3":
        Console.WriteLine("GOOD");
        break;
    case "4":
        Console.WriteLine("VERY GOOD");
        break;
    default:
        Console.WriteLine("STRONG");
        break;
}

Console.WriteLine("\nName of the activity: " + activityName +
"\nDistance covered: " + distance + " kilometers" +
"\nTimeTaken: " + time +
"\nDate of activity: " + date +
"\nHow You Felt After the Activity: " + afterActivityFeeling +
"\nAverage speed: " + averageSpeed + " KM/h");
