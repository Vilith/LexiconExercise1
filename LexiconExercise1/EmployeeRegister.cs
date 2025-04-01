using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise1
{
    internal class EmployeeRegister
    {
        private List<Employee> employee = new List<Employee>();

        public void AddEmployee(string name, decimal salary)
        {
            employee.Add(new Employee(name, salary));
        }

        public void PrintEmployees()
        {
            Console.WriteLine(
                """
                    __________________
                    Personal-Register
                    __________________
                    """);
            foreach (var employee in employee)
            {
                Console.WriteLine(employee);
            }
        }
    }
}

