using EmployeeSalaryUpdate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnC_ForBiggner
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public int Experience { get; set; }

        public static void UpdateSalary(
            Employee[] employees,
            EmployeeCondition condition)
        {
            foreach (Employee employee in employees)
            {
                if (condition(employee))
                {
                    employee.Salary += employee.Salary * 0.10; // زيادة 10%

                    Console.WriteLine(
                        $"Employee: {employee.Name} | " +
                        $"New Salary: {employee.Salary}");
                }
            }
        }
    }
}
