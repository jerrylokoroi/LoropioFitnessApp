using LoropioFitnessApp.Activity;
using LoropioFitnessApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp.UI
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
                Console.WriteLine("3. Load sport activity by date");
                Console.WriteLine("4. Quit application");

                userSelection = int.Parse(Console.ReadLine());

                switch (userSelection)
                {
                    case 1:
                        ActivityDialog.EnterActivity();
                        break;
                    case 2:
                        ActivityDialog.DisplayAllActivities();
                        break;
                    case 3:
                        // TM Why is this in ActivityRepository and the calls above go to the ActivityDialog, that does not make sense
                        //ActivityRespository.LoadActivities();
                        ActivityDialog.LoadActivityByDate();
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

