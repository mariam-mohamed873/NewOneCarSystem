using System.ComponentModel.DataAnnotations;

namespace Car_Management_System1.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(20)]
        [MinLength(3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is Required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Position is Required")]
        [MaxLength(10)]
        [MinLength(2)]
        public string Position { get; set; }
        public virtual List<Transaction> Transactions { get; set; }
    }
}
