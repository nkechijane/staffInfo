using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staffInfo
{
    class employee
    {
        private int _staffId;
        private string _fullName;
        private DateTime _employmentDate;
        public string _department;
        public string _jobTitle;


        public employee(int staffId, string fullName, DateTime employmentDate)
        {
            _staffId = staffId;
            _fullName = fullName;
            _employmentDate = employmentDate;
        }
        public int staffId
        {
            get
            {
                return _staffId;
            }

        }

        public string Name
        {
            get
            {
                return _fullName;
            }
        }


        public string JobTitle
        {       

            get
            {
                return _jobTitle;
            }

            set
            {
                _jobTitle = value;
            }

        }

        public DateTime EmploymentDate
        {
            get
            {
                return _employmentDate;
            }
        }

        public string Department 
        {
            get
            {
                return _department;
            }

            set 
            {
                _department = value;
            }
        }

        public void ClockIn()
        {
            Console.Write("I am clocking into the office");
        }

        public void Work()
        {
            Console.WriteLine("i am busy at work");
        }

        public void ClockOut()
        {
            Console.WriteLine("i am done for the day, therefore am clocking out");
        }
        
        
    }
}


    
