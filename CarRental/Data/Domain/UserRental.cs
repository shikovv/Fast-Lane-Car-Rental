using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Data.Domain
{
    public class UserRental
    {
        [ForeignKey(nameof(ApplicationUser))]
        public Guid CustomerId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;
        [ForeignKey(nameof(Rental))]
        public Guid RentalId { get; set; }
        public virtual Rental Rental { get; set; } = null!;
    }
}
