using learnC_ForBiggner;
using System;

namespace EmployeeSalaryUpdate
{
    // Delegate
    public delegate bool EmployeeCondition(Employee employee);

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee { Id = 1, Name = "Mahmoud", Salary = 40000, Experience = 6 },
                new Employee { Id = 2, Name = "Mohamed", Salary = 60000, Experience = 2 },
                new Employee { Id = 3, Name = "Zaki", Salary = 80000, Experience = 3 },
                new Employee { Id = 4, Name = "Ali", Salary = 100000, Experience = 5 }
            };

            EmployeeCondition condition = IsEligibleForUpdate;

            Employee.UpdateSalary(employees, condition);

            Console.ReadKey();
        }

        // شرط التحديث
        public static bool IsEligibleForUpdate(Employee employee)
        {
            return employee.Experience >= 5;
        }
    }
}
