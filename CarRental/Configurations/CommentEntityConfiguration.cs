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
                CreatedOn = DateTime.Now,
                CreatorId = Guid.Parse("F2525385-0162-4B42-8FA5-08DB8A43496A")
            });

            comments.Add(new Comment()
            {
                Id = Guid.Parse("9bdc6a38-e9f4-4cdf-8b9e-b329e0f0233c"),
                Title = "The best in the business!",
                Description = "Fast Lane Car Rental made my trip an absolute breeze! Their extensive selection of vehicles ensured I found the perfect ride for my adventure. The seamless rental process and friendly staff made the experience top-notch. Highly recommend!",
                StarsRating = 4,
                CreatedOn = DateTime.Now,
                CreatorId = Guid.Parse("F06D4765-779A-4766-EB64-08DB8A42133C")
            });

            comments.Add(new Comment()
            {
                Id = Guid.Parse("6db74b16-8cc7-4709-9fce-9e8a30939efc"),
                Title = "Awesome!",
                Description = "My experience with Fast Lane Car Rental exceeded all expectations. From booking to drop-off, everything was flawless. The quality of their vehicles and the professionalism of their team truly set them apart. Will definitely be returning for my future rental needs!",
                StarsRating = 4,
                CreatedOn = DateTime.Now,
                CreatorId = Guid.Parse("8A5EDC49-7490-493F-2F01-08DB8A416485")
            });
            return comments;
        }
    }
}
