using CarRental.Data.Domain.Enums;
using CarRental.Data.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Configurations
{
    public class CommentEntityConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(this.GenerateComments());
        }

        private ICollection<Comment> GenerateComments()
        {
            var comments = new HashSet<Comment>();

            comments.Add(new Comment()
            {
                Id = Guid.Parse("df0bd291-45c5-4ac0-a927-27b27ddbd821"),
                Title = "Reccomend it!",
                Description = "Exceptional service from Fast Lane Car Rental! The rental process was seamless, and the car exceeded my expectations. Will definitely be using their services again!",
                StarsRating = 5,
                CreatedOn = DateTime.UtcNow,
                CreatorId = Guid.Parse("F2525385-0162-4B42-8FA5-08DB8A43496A")
            });
            return comments;
        }
    }
}
