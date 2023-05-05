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

Console.WriteLine("Enter the date of the activity");
string dateOfActivity = Console.ReadLine();
DateOnly date = DateOnly.Parse(dateOfActivity);

double averageSpeed = distance / (time.Hours * 3600 + time.Minutes + time.Seconds / 60);

Console.WriteLine("\nName of the activity: " + activityName + 
    "\nDistance covered: " + distance + " kilometers" + 
    "\nTimeTaken: " + time + 
    "\nDate of activity: " + date + 
    "\nAverage speed: " + averageSpeed + " KM/h");