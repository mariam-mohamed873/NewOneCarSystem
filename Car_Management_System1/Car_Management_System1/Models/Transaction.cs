using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Management_System1.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Date_of_entry is Required")]
        public DateTime Date_of_entry { get; set; }

        [ForeignKey("Employee")]
        public int Employee_ID { get; set; }
        public virtual Employee Employee { get; set; }

        [ForeignKey("Car")]
        public int Car_ID { get; set; }
        public virtual Car Car { get; set; }
    }
}
