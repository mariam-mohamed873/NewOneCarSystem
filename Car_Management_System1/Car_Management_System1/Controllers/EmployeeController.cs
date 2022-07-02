using Car_Management_System1.Models;
using Car_Management_System1.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Car_Management_System1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        CarContext context;
        IEmployeeRepository employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepo,
            CarContext _context)
        {
            employeeRepository = employeeRepo;
            context = _context;
        }
        public ActionResult<Employee> PostEmployee(Employee employee)
        {
            employeeRepository.Insert(employee);


            return CreatedAtAction("GeEmployee", new { id = employee.Id }, employee);
        }
    }
}
