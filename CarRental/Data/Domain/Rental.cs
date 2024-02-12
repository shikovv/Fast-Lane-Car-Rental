using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Data.Domain
{
    public class Rental
    {
        public Rental() 
        { 
            this.Id = Guid.NewGuid();
            this.UserRentals=new HashSet<UserRental>();
        }
        [Key]
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public double Deposit { get; set; }
        [ForeignKey(nameof(Car))]
        public Guid CarId { get; set; }
        public virtual Car Car { get; set; } = null!;
        public ICollection<UserRental>UserRentals { get; set; }
    }
}
