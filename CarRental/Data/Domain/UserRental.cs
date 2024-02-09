using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Data.Domain
{
    public class UserRental
    {
        [ForeignKey(nameof(Rental))]
        public Guid RentalId { get; set; }
        public virtual Rental Rental { get; set; } = null!;
    }
}
