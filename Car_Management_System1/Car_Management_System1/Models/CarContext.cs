using Microsoft.EntityFrameworkCore;

namespace Car_Management_System1.Models
{
    public class CarContext:DbContext
    {
        public CarContext() : base()
        {

        }
        public CarContext(DbContextOptions option) : base(option)
        {
           

        }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
    }
}
