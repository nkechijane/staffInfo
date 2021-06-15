using System;

namespace staffInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            employee firstEmployee = new employee(0001, "Donald Turner", date.AddYears(-2));
            employee secondEmployee = new employee(00021, "Hillary Tina", date.AddYears(1));
            employee thirdEmployee = new employee(0020, "Betty Ashley", date.AddYears(1));
            employee fourthEmployee = new employee(00034, "Eddy Jones", date.AddYears(2));
            employee fifthEmployee = new employee(00038, "Ireti Bamidele", date.AddYears(3));

            firstEmployee.Department = "Accounts";
            secondEmployee.Department = "Administration";
            thirdEmployee.Department = "Accounts";
            fourthEmployee.Department = "Accounts";
            fifthEmployee.Department = "Human Resources";

            firstEmployee.JobTitle = "Chief Finance Officer";
            secondEmployee.JobTitle = "Admin Manager";
            thirdEmployee.JobTitle = "Cashier";
            fourthEmployee.JobTitle = "Auditor";             
            fifthEmployee.JobTitle = "HR Manager";

            //Console.WriteLine($"The first employee job title is {firstEmployee}");

            employee[] employee = new employee[5] { firstEmployee, secondEmployee, thirdEmployee, fourthEmployee, fifthEmployee };
            var a = 1;
            Console.WriteLine("Staff Id \t Name \t\t\t Employment Date \t Department \t\t Job Title");
            foreach (employee i in employee)
            {
                Console.WriteLine(i.staffId + "\t\t" + i.Name + "\t\t" + i.EmploymentDate + "\t" + i.Department + "\t\t" + i.JobTitle + "\n");
                //Console.WriteLine($"The staffId of the employee {a} is {i.staffId}");
                //Console.WriteLine($"The name of the employee {a} is {i.Name}");
                //Console.WriteLine($"The employee {a} was employed on the {i.EmploymentDate}");
                //Console.WriteLine($"The employee {a} department is {i.Department}");
                //Console.WriteLine($"The employee {a} job title is {i.JobTitle}");
                a++;
            }

        }
    }
}
