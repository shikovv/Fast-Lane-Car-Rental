using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string FirstName { get; set; } = null!;
        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string Surname { get; set; } = null!;
        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string UserName { get; set; } = null!;
        [Required]
        [EmailAddress]
        [StringLength(60, MinimumLength = 10)]
        public string EmailAddress { get; set; } = null!;
        [Required]
        [StringLength(20, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;    
    }
}
