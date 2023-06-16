using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp
{
    internal class Dialog
    {
        public static void StartDialog()
        {
            int userSelection;
            do
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Enter new sport activity");
                Console.WriteLine("2. View all activities");
                Console.WriteLine("3. Load specific sport activity");
                Console.WriteLine("4. Quit application");

                userSelection = int.Parse(Console.ReadLine());

                switch (userSelection)
                {
                    case 1:
                        ActivityDialog.EnterActivity();
                        Console.WriteLine("New sport activity entered successfully!");
                        // Do something with the new activity, such as saving it or displaying it
                        break;
                    case 2:
                        Console.WriteLine("What type of sports activity do you want to enter ?");
                        Console.WriteLine("1. Bike SportActivity");
                        Console.WriteLine("2. Climb SportActivity");
                        Console.WriteLine("3. Run SportActivity");
                        Console.WriteLine("4. Swim SportActivity");

                        string activityTypeInput = Console.ReadLine();

                        if(activityTypeInput != null)
                        {
                            Console.WriteLine("A new line activity has been entered successfully");
                        }
                        else
                        {
                            Console.WriteLine("invalid sport activity");
                        }
                        break;
                    case 3:
                        // Implement load specific sport activity
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using Loropio Fitness App. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            } while (userSelection != 4);
        }

    }
}

