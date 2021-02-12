using RestAPICrud.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICrud.EmployeeData
{
    public class MockEmployeeData : IEmployeeData
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Sakshi"
            },

            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Munu"
            },

            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Kunu"
            },

            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Shivam"
            }
        };

        public Employee AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public List<Employee> GetEmployee()
        {
            return employees;
        }

        public Employee GetEmployee(Guid Id)
        {
            return employees.SingleOrDefault(x => x.Id == Id);
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var existingEmployee = GetEmployee(employee.Id);
            existingEmployee.Name = employee.Name;
            return existingEmployee;
        }
    }
}
