using System.ComponentModel.DataAnnotations;

namespace Car_Management_System1.Models
{
    public class UniquePlateNumberAttribute : ValidationAttribute
    {
        //public string Msg { get; set; }
        //CarContext context = new CarContext();
        
        //protected override ValidationResult IsValid(object value,
        //    ValidationContext validationContext)
        //{
        //    Car car = context.Cars.FirstOrDefault(c => c.PlateNumber == value.ToString());
        //    if (car == null)
        //        return ValidationResult.Success;//valid
        //    return new ValidationResult("PlateNumber Already Exists");

        //}
    }
}
