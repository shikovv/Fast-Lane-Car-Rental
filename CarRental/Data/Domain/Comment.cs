using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Data.Domain
{
    public class Comment
    {
        public Comment()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        [Required, MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(1, 5)]
        public int StarsRating { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [ForeignKey(nameof(Creator))]
        public Guid CreatorId { get; set; }
        public virtual ApplicationUser Creator { get; set; }
    }
}
