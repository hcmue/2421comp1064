using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab03Validation.Models
{
    public class Employee
    {
        public int? Id { get; set; }

        [Required(ErrorMessage ="Phải nhập")]
        [Remote(action: "CheckExistEmployee", controller:"Employee")]
        public string EmployeeNo { get; set; } = "";

        [MinLength(5, ErrorMessage ="Tối thiểu 5 kí tự")]
        [Display(Name ="Họ tên")]
        public string FullName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Url]
        public string Website { get; set; }

        [DataType(DataType.Date)]
        [Must18Ages]
        public DateTime BirthDate { get; set; }

        public bool Gender { get; set; }
        public double Salary { get; set; }
        public bool IsPartTime { get; set; }
        public string Address { get; set; }

        [RegularExpression(@"0[9875]\d{8}")]
        public string Phone { get; set; }

        [CreditCard]
        public string CreditCard { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(255, ErrorMessage ="Tối đa 255 kí tự")]
        public string Description { get; set; }
    }
}
