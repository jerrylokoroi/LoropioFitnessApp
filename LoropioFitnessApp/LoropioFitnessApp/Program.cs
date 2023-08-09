using LoropioFitnessApp;
using LoropioFitnessApp.UI;

Console.WriteLine("Please enter you name: ");

string lionName = Console.ReadLine();

Console.WriteLine("Hello " + lionName + ". " + "Welcome to the Loropio Fitness App.");

Dialog.StartDialog();


Feeling feeling = Feeling.Good;
int[] simulatedHeartRates = HeartRateSensorData.SimulateHeartRates(feeling);

Console.WriteLine($"Simulated heart rates for {feeling}:");
foreach (int heartRate in simulatedHeartRates)
{
    Console.WriteLine(heartRate);
}