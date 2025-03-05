using System.ComponentModel.DataAnnotations;

namespace Lab03Validation.Models
{
    public class Must18AgesAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var birthDate = (DateTime)value;
            if (DateTime.Now.Year - birthDate.Year >= 18)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Chưa đủ 18 tuổi");
        }
    }
}