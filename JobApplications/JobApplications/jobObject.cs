using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplications
{
    class JobObject
    {
        Program pr = new Program();

        private string Name, Company, Location, Salary, Hours;

        public JobObject(string _name, string _company, string _location, string _salary, string _hours)
        {
            this.Name = _name;
            this.Company = _company;
            this.Location = _location;
            this.Salary = _salary;
            this.Hours = _hours;
        }

        public JobObject() { }
        

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

            pr.listOfJobs.Add(job);
            
        }


        public void DeleteJob()
        {
            Console.WriteLine("Current jobs on system:");
            foreach (JobObject a in pr.listOfJobs)
            {
                Console.WriteLine("Job Name: " + a.Name + ", Company: " + a.Company);
            }

            Console.WriteLine("Please enter the name of the company who's job you wish to delete: ");

            bool correctDelete = false;
            while (correctDelete == false)
            {
                string deleteJob = Console.ReadLine();

                foreach (JobObject a in pr.listOfJobs)
                {
                    if (deleteJob == a.Company)
                    {
                        pr.listOfJobs.Remove(a);
                        Console.WriteLine("Job " + deleteJob + " has been removed");
                        correctDelete = true;
                    }
                }
            }
        }


        public void showJobs()
        {
            if (pr.listOfJobs.Count < 1)
            {
                Console.WriteLine("No Current Jobs in System");
                return;
            }
            
            Console.WriteLine("The current jobs on system are:");
            foreach (JobObject a in pr.listOfJobs)
            {
                Console.WriteLine("Job Name: " + a.Name + ", Company: " + a.Company);
            }

            Console.WriteLine("Please enter the company who's job you want to know the info of: ");

            bool correctInfo = false;
            while (correctInfo == false)
            {
                string infoOfJob = Console.ReadLine();

                foreach (JobObject a in pr.listOfJobs)
                {
                    if (infoOfJob == a.Company)
                    {
                        Console.Write("\nJob role: " + a.Name + "\nLocation: " + a.Location + "\nSalary: " + a.Salary + "\nHours: " + a.Hours);
                        correctInfo = true;
                        break;
                    }
                }

                Console.WriteLine("Please enter a valid company name: ");
            }
        }
    }
}
