using System.ComponentModel.DataAnnotations;

namespace AspMvcValidationApp
{
    public class Employee
    {
        [Required(ErrorMessage = "Имя должно быть")]
        public string Name { get; set; } = "";

        public int Age { get; set; } = 0;

        [RegularExpression(@"[A-Za-z]+@[A-Za-z]+\.[A-Za-z]{2,3}")]
        public string Email { get; set; } = "";

        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Длина пародля не менее 5 символов")]
        public string Password {  get; set; }

        [Compare("Password")]
        public string PasswordConfirm { get; set; }
    }
}
