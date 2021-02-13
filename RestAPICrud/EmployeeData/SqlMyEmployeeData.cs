using RestAPICrud.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICrud.EmployeeData
{
    public class SqlMyEmployeeData : IMyEmployeeData
    {
        private MyEmployeeContext _employeeContext;
        public SqlMyEmployeeData(MyEmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public MyEmployee AddEmployee(MyEmployee employee)
        {
            employee.Id = Guid.NewGuid();
            _employeeContext.Employees.Add(employee);
            _employeeContext.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(MyEmployee employee)
        {
            _employeeContext.Employees.Remove(employee);
            _employeeContext.SaveChanges();
        }

        public List<MyEmployee> GetEmployee()
        {
           return _employeeContext.Employees.ToList();
        }

        public MyEmployee GetEmployee(Guid Id)
        {
            //return _employeeContext.Employees.SingleOrDefault(x => x.Id == Id);
            var employee = _employeeContext.Employees.Find(Id);
            return employee;
        }

        public MyEmployee UpdateEmployee(MyEmployee employee)
        {
            var employeeExists = _employeeContext.Employees.Find(employee.Id);
            if (employeeExists != null)
            {
                employeeExists.Name = employee.Name;
                _employeeContext.Employees.Update(employeeExists);
                _employeeContext.SaveChanges();
            }
            return employee;
        }
    }
}
