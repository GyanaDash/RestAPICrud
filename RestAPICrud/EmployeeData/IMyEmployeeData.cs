using RestAPICrud.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICrud.EmployeeData
{
    public interface IMyEmployeeData
    {
        List<MyEmployee> GetEmployee();
        MyEmployee GetEmployee(Guid Id);
        MyEmployee AddEmployee(MyEmployee employee);
        MyEmployee UpdateEmployee(MyEmployee employee);
        void DeleteEmployee(MyEmployee employee);
    }
}
