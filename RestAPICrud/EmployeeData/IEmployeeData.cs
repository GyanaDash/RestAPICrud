using RestAPICrud.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICrud.EmployeeData
{
    public interface IEmployeeData
    {
        List<Employee> GetEmployee();
        Employee GetEmployee(Guid Id);
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
