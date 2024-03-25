using System.ComponentModel.DataAnnotations;

namespace CarRental.Models.Rental
{
    public class RentalForm
    {
        public string? CarId { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 4, ErrorMessage = "Invalid Phone Number")]
        [RegularExpression(@"^\d+$",
            ErrorMessage = "Phone Number must contain only digits")]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [Range(1, int.MaxValue,
            ErrorMessage = "Deposit must be greater than 0")]
        public double? Deposit { get; set; }

        [Required]
        [Range(1, int.MaxValue,
            ErrorMessage = "Days must be greater than 0")]
        public int? Days { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; } = null!;
    }
}
