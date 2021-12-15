using System.ComponentModel.DataAnnotations;

namespace Lab1.ViewModels
{
    public class RegisterModel
    {
        [Required]
        public string Email { get; set; }
         
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
         
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password's don't match" )]
        public string ConfirmPassword { get; set; }
    }
}