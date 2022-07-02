using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Management_System1.Models
{
    public class Card
    {
        [Key]
        public int CardAccess { get; set; }

        [Required(ErrorMessage = "Credit is Required")]
        public int Credit { get; set; }

        [ForeignKey("Employee")]
        public int Employee_ID { get; set; }
        public virtual Employee Employee { get; set; }

        [ForeignKey("Car")]
        public int Car_ID { get; set; }
        public virtual Car Car { get; set; }
    }
}
