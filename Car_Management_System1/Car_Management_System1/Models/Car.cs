using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Management_System1.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Brand is Required")]
        [MaxLength(20)]
        [MinLength(3)]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Model is Required")]
        public int Model { get; set; }

        //[UniquePlateNumber]
        [Required(ErrorMessage = "PlateNumber is Required")]
        [MaxLength(8)]
        [MinLength(2)]
        public string PlateNumber { get; set; }

        [ForeignKey("Employee")]
        public int Employee_ID { get; set;}
        public virtual Employee Employee { get; set; }
        public virtual List<Transaction> Transactions { get; set; }
    }
}
