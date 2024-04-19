using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Services;
using CarRental.Models.Comment;
using CarRental.Data;
using Microsoft.EntityFrameworkCore;
using CarRental.Data.Domain;

namespace NUnitTests
{
    [TestFixture]
    public class CommentServiceTests
    {
        private ApplicationDbContext dbContext;
        private CommentService commentService;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;
            dbContext = new ApplicationDbContext(options);
            SeedDatabase();
            commentService = new CommentService(dbContext);
        }

        private void SeedDatabase()
        {
            var comments = new List<Comment>
            {
                new Comment { Id = Guid.NewGuid(), Title = "Comment 1", Description = "Description 1", StarsRating = 5, CreatedOn = DateTime.Now.AddDays(-1), CreatorId = Guid.NewGuid() },
                new Comment { Id = Guid.NewGuid(), Title = "Comment 2", Description = "Description 2", StarsRating = 4, CreatedOn = DateTime.Now.AddDays(-2), CreatorId = Guid.NewGuid() },
                new Comment { Id = Guid.NewGuid(), Title = "Comment 3", Description = "Description 3", StarsRating = 3, CreatedOn = DateTime.Now.AddDays(-3), CreatorId = Guid.NewGuid() },
            };

            dbContext.Comments.AddRange(comments);
            dbContext.SaveChanges();
        }

        [Test]
        public async Task ExistById_WhenCommentExists_ShouldReturnTrue()
        {
            // Arrange
            var existingCommentId = dbContext.Comments.First().Id;

            // Act
            var result = await commentService.ExistById(existingCommentId);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task ExistById_WhenCommentDoesNotExist_ShouldReturnFalse()
        {
            // Arrange
            var nonExistingCommentId = Guid.NewGuid();

            // Act
            var result = await commentService.ExistById(nonExistingCommentId);

            // Assert
            Assert.IsFalse(result);
        }
        [Test]
        public async Task CreateAndReturnId_ShouldCreateNewCommentAndReturnItsId()
        {
            // Arrange
            var formModel = new CommentFormModel
            {
                Title = "New Comment",
                Description = "This is a new comment.",
                StarsRating = 5 // Assume a valid rating
            };
            var userId = Guid.NewGuid(); // Assume a valid user ID

            // Act
            var commentId = await commentService.CreateAndReturnId(formModel, userId);

            // Assert
            Assert.IsNotNull(commentId); // Check if commentId is not null
            Assert.IsInstanceOf(typeof(string), commentId); // Check if commentId is a string
                                                            // You may further validate the commentId format or structure depending on your implementation
        }
       
    }
}
