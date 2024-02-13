using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Data.Domain
{
    public class ApplicationUser: IdentityUser<Guid>
    {
        public ApplicationUser() 
        { 
            this.Id = Guid.NewGuid();
            this.Comments = new HashSet<Comment>();
            this.UserRentals = new HashSet<UserRental>();
            this.SecurityStamp=Guid.NewGuid().ToString();
        }
        [Required,MaxLength(20)]
        public string FirstName { get; set; }
        [Required, MaxLength(25)]
        public string LastName { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<UserRental> UserRentals { get; set; }
    }
}
