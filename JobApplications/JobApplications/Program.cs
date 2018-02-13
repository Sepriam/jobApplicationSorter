using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplications
{
    class Program
    {
        public List<JobObject> listOfJobs = new List<JobObject>();



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

            JobObject jobs = new JobObject();

            switch (_command)
            {
                case "Info":
                    jobs.showJobs();
                    break;
                case "Add":
                    jobs.Addjob();
                    break;
                case "Delete":
                    jobs.DeleteJob();
                    break;
                case "Exit":
                    break;
                case "?":
                    DisplayInfo();
                    break;
                default:
                    Console.WriteLine("Incorrect Input");
                    break;
            }

            Console.WriteLine("Please enter a command: ");

            string command = Console.ReadLine();
            decideAction(command);

        }
    }
}
