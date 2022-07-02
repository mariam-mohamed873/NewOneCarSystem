using Car_Management_System1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Car_Management_System1.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        CarContext context;
        public EmployeeRepository(CarContext _context)
        {
            context = _context;
        }

        [HttpPost]
        public int Insert(Employee employee)
        {
            context.Employees.Add(employee);
            int raws = context.SaveChanges();
            return raws;
        }
    }
}
