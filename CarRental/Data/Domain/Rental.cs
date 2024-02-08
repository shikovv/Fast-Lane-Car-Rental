using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Data.Domain
{
    public class Rental
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public double Deposit { get; set; }
        [ForeignKey(nameof(Car))]
        public virtual Car Car { get; set; } = null!;
    }
}
