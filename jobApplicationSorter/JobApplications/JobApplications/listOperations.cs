using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplications
{

    public class listOperations
    {

        List<JobObject> listOfJobs = new List<JobObject>();

        public void Addjob()
        {
            Console.WriteLine("Please follow the directions as listed. If an error is made, type REDO to start again.");
            Console.WriteLine("1) Please enter the job name:");
            string jobName = Console.ReadLine();
            if (jobName == "REDO")
            {
                Addjob();
            }

            Console.WriteLine("2) Please enter the Company name: ");
            string companyName = Console.ReadLine();
            if (companyName == "REDO")
            {
                Addjob();
            }

            Console.WriteLine("3) Please enter the Location: ");
            string _location = Console.ReadLine();
            if (_location == "REDO")
            {
                Addjob();
            }

            Console.WriteLine("4) Please enter the Salary: ");
            string salaryString = Console.ReadLine();
            if (salaryString == "REDO")
            {
                Addjob();
            }

            Console.WriteLine("5) Please enter the hours:");
            string hoursString = Console.ReadLine();
            if (hoursString == "REDO")
            {
                Addjob();
            }

            JobObject job = new JobObject(jobName, companyName, _location, salaryString, hoursString);

            listOfJobs.Add(job);

        }


        public void DeleteJob()
        {
            if (listOfJobs.Count < 1)
            {
                Console.WriteLine("No Current Jobs in System");
                return;
            }

            Console.WriteLine("Current jobs on system:");
            foreach (JobObject a in listOfJobs)
            {
                Console.WriteLine("Job Name: " + a.Name + ", Company: " + a.Company);
            }

            Console.WriteLine("Please enter the name of the company who's job you wish to delete: ");

            bool correctDelete = false;
            while (correctDelete == false)
            {
                string deleteJob = Console.ReadLine();

                foreach (JobObject a in listOfJobs)
                {
                    if (deleteJob == a.Company)
                    {
                        listOfJobs.Remove(a);
                        Console.WriteLine("Job " + deleteJob + " has been removed");
                        correctDelete = true;
                        break;
                    }
                }
            }
        }


        public void showJobs()
        {
            if (listOfJobs.Count < 1)
            {
                Console.WriteLine("No Current Jobs in System");
                return;
            }

            Console.WriteLine("The current jobs on system are:");
            foreach (JobObject a in listOfJobs)
            {
                Console.WriteLine("Job Name: " + a.Name + ", Company: " + a.Company);
            }

            Console.WriteLine("Please enter the company who's job you want to know the info of: ");

            bool correctInfo = false;
            while (correctInfo == false)
            {
                string infoOfJob = Console.ReadLine();

                foreach (JobObject a in listOfJobs)
                {
                    if (infoOfJob == a.Company)
                    {
                        Console.Write("\nJob role: " + a.Name + "\nLocation: " + a.Location + "\nSalary: " + a.Salary + "\nHours: " + a.Hours);
                        correctInfo = true;
                        return;
                    }
                }

                Console.WriteLine("Please enter a valid company name: ");
            }
        }

    }
}
