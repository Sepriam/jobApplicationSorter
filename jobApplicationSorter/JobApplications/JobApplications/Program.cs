using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplications
{
    class Program
    {
        


        static void Main(string[] args)
        {

            startProgram();

        }


        static void startProgram()
        {
            Console.WriteLine("Hello, this program is an easy way to quick, store and display your current job applications");

            DisplayInfo();

            string command = Console.ReadLine();

            decideAction(command);
        }

        static void DisplayInfo()
        {
           
            Console.WriteLine("You can choose from any of the following options:");

            Console.WriteLine("Info   - Displays info of a job or all jobs");
            Console.WriteLine("Add    - Allows you to add a new job to system");
            Console.WriteLine("Delete - Allows you to delete any of the jobs you've applied for");
            Console.WriteLine("Exit   - Saves and exits the application");
            Console.WriteLine("?      - Displays these options again");

            Console.WriteLine("Please enter a command:");
        }

        static void decideAction(string _command)
        {
            listOperations li = new listOperations();


            bool finished = false;
            while (finished == false)
            {
                switch (_command)
                {
                    case "Info":
                        li.showJobs();
                        break;
                    case "Add":
                        li.Addjob();
                        break;
                    case "Delete":
                        li.DeleteJob();
                        break;
                    case "Exit":
                        finished = true;
                        break;
                    case "?":
                        DisplayInfo();
                        break;
                    default:
                        Console.WriteLine("Incorrect Input");
                        break;
                }

                Console.WriteLine("Please enter a command: ");

                _command = Console.ReadLine();
            }

        }


       
    }
}
