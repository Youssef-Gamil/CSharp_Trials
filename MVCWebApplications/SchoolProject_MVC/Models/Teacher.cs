using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SchoolProject_MVC.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]//for Validation
        public string Name { get; set; }
        [Url]//for UI Behaviour and validation (check it is an absolute url or not)
        [Display(Name ="Blog URL")]//for UI Behaviour
        public string BlogUrl { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [RegularExpression("[A-Fa-f1-6Yy]{6,}")]//for Validation
        [DataType(DataType.Password)]//for UI Behaviour in edit mode
        public string Password { get; set; }
        [Required]//for Validation
        [RegularExpression("0-9{14}")]//for Validation
        [Display(Name="National ID")]//for UI Behaviour
        public string NationalId { get; set; }
        [Display(Name ="Date of Birth")]//for UI Behaviour
        public DateTime DOB { get; set; }
        [Phone]//for UI Behaviour & Validation
        [Display(Name = "Phone Number")]//for UI Behaviour
        public string PhoneNumber { get; set; }
        [Range(500,50000)]//For server side validation
        [DataType(DataType.Currency)]//for UI Behaviour
        public Double Salary { get; set; }
    }
}
