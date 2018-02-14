using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplications
{
    class JobObject
    {
        
        public string Name { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Salary { get; set; }
        public string Hours { get; set; }

        public JobObject(string _name, string _company, string _location, string _salary, string _hours)
        {
            this.Name = _name;
            this.Company = _company;
            this.Location = _location;
            this.Salary = _salary;
            this.Hours = _hours;
        }
    }
}
