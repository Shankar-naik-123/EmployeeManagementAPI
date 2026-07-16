using EmployeeManagement.API.Controllers;

namespace EmployeeManagement.Tests
{
    public class EmployeeControllerTests
    {
        [Fact]
        public void GetEmployeesreturnsEmployees()
        {
            EmployeeController controller=new EmployeeController();
            var employees=controller.GetEmployees();
            Assert.NotNull(employees);
        }
        [Fact]
        public void AddEmployeesAddsEmployee()
        {
            EmployeeController controller = new EmployeeController();
            var result = controller.AddEmployees("Test Name", "Test Designation", "Test Address", 2);
            Assert.IsType<Microsoft.AspNetCore.Mvc.OkObjectResult>(result);
            Assert.Contains(controller.GetEmployees(), e => e.Name == "Test Name");
        }
        }
    }

