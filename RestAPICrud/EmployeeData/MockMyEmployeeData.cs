using RestAPICrud.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICrud.EmployeeData
{
    public class MockMyEmployeeData : IMyEmployeeData
    {
        private List<MyEmployee> employees = new List<MyEmployee>()
        {
            new MyEmployee()
            {
                Id = Guid.NewGuid(),
                Name = "Sakshi"
            },

            new MyEmployee()
            {
                Id = Guid.NewGuid(),
                Name = "Munu"
            },

            new MyEmployee()
            {
                Id = Guid.NewGuid(),
                Name = "Kunu"
            },

            new MyEmployee()
            {
                Id = Guid.NewGuid(),
                Name = "Shivam"
            }
        };

        public MyEmployee AddEmployee(MyEmployee employee)
        {
            employee.Id = Guid.NewGuid();
            employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(MyEmployee employee)
        {
            employees.Remove(employee);
        }

        public List<MyEmployee> GetEmployee()
        {
            return employees;
        }

        public MyEmployee GetEmployee(Guid Id)
        {
            return employees.SingleOrDefault(x => x.Id == Id);
        }

        public MyEmployee UpdateEmployee(MyEmployee employee)
        {
            var existingEmployee = GetEmployee(employee.Id);
            existingEmployee.Name = employee.Name;
            return existingEmployee;
        }
    }
}
