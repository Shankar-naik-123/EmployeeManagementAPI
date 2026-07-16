using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = Guid.NewGuid(), Name = "John Doe", Designation = "Software Engineer", Adresss = "123 Main St", ServiceYears = 5 },
            new Employee { Id = Guid.NewGuid(), Name = "Jane Smith", Designation = "Project Manager", Adresss = "456 Elm St", ServiceYears = 8 },
            new Employee { Id = Guid.NewGuid(), Name = "Alice Johnson", Designation = "QA Analyst", Adresss = "789 Oak St", ServiceYears = 3 }
        };

        [HttpGet(Name = "GetEmployees")]
        public IEnumerable<Employee> GetEmployees()
        {
            return employees;
        }


        [HttpPost("add")]
        public IActionResult AddEmployee([FromBody] Employee newEmployee)
        {
            if (newEmployee == null)
                return BadRequest();

            newEmployee.Id = Guid.NewGuid();
            employees.Add(newEmployee);

            return CreatedAtAction(nameof(GetEmployees), new { id = newEmployee.Id }, newEmployee);
        }
    }
}
