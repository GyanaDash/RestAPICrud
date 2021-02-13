using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPICrud.EmployeeData;
using RestAPICrud.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICrud.Controllers
{
    
    [ApiController]
    public class MyEmployeeController : ControllerBase
    {
        private IMyEmployeeData _employeeData;
        public MyEmployeeController(IMyEmployeeData employeeData)
        {
            _employeeData = employeeData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEmployees()
        {
            return Ok(_employeeData.GetEmployee());
        }


        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetEmployee(Guid id)
        {
            var employee = _employeeData.GetEmployee(id);

            if (employee != null)
            {
                return Ok(employee);
            }

            return NotFound($"Employee with the ID: {id} was not found...");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddNewEmployee(MyEmployee employee)
        {
            _employeeData.AddEmployee(employee);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + employee.Id, employee);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteAnEmployee(Guid id)
        {
            var employee = _employeeData.GetEmployee(id);

            if (employee != null)
            {
                _employeeData.DeleteEmployee(employee);
                return Ok();
            }

            return NotFound($"Employee with the ID: {id} was not found...");
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult EditEmployee(Guid Id, MyEmployee employee)
        {
            var employeeExisted = _employeeData.GetEmployee(Id);

            if (employeeExisted != null)
            {
                employee.Id = employeeExisted.Id;
                _employeeData.UpdateEmployee(employee);
            }

            return Ok(employee);
        }
    }
}
