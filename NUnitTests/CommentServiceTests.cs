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
            commentService = new CommentService(dbContext);
        }

        [Test]
        public async Task AllCommentsByCreationTime_ShouldReturnAllCommentsSortedByCreationTimeDescending()
        {
            var comments = new List<Comment>
    {
        new Comment { Id = Guid.NewGuid(), Title = "Title 1", Description = "Description 1", StarsRating = 5, CreatedOn = DateTime.UtcNow.AddDays(-3), Creator = new ApplicationUser { FirstName = "John", LastName = "Doe" } },
        new Comment { Id = Guid.NewGuid(), Title = "Title 2", Description = "Description 2", StarsRating = 4, CreatedOn = DateTime.UtcNow.AddDays(-1), Creator = new ApplicationUser { FirstName = "Jane", LastName = "Smith" } },
        new Comment { Id = Guid.NewGuid(), Title = "Title 3", Description = "Description 3", StarsRating = 3, CreatedOn = DateTime.UtcNow.AddDays(-2), Creator = new ApplicationUser { FirstName = "Alice", LastName = "Johnson" } }
    };

            dbContext.Comments.AddRange(comments);
            dbContext.SaveChanges();
            var result = await commentService.AllCommentsByCreationTime();
            Assert.IsNotNull(result);
            var commentDetails = result.ToList();
            Assert.AreEqual(3, commentDetails.Count);
            Assert.AreEqual("Title 2", commentDetails[0].Title);
            Assert.AreEqual("Title 3", commentDetails[1].Title);
            Assert.AreEqual("Title 1", commentDetails[2].Title);
        }


        [Test]
        public async Task ExistById_WhenCommentExists_ShouldReturnTrue()
        {
            var existingCommentId = dbContext.Comments.First().Id;
            var result = await commentService.ExistById(existingCommentId);
            Assert.IsTrue(result);
        }

        [Test]
        public async Task ExistById_WhenCommentDoesNotExist_ShouldReturnFalse()
        {
            var nonExistingCommentId = Guid.NewGuid();
            var result = await commentService.ExistById(nonExistingCommentId);
            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetCommentForEditById_ShouldReturnCommentFormModel()
        {
            var commentId = Guid.NewGuid();
            var comment = new Comment
            {
                Id = commentId,
                Title = "Test Title",
                Description = "Test Description",
                StarsRating = 4
            };
            dbContext.Comments.Add(comment);
            dbContext.SaveChanges();
            var result = await commentService.GetCommentForEditById(commentId);
            Assert.IsNotNull(result);
            Assert.AreEqual("Test Title", result.Title);
            Assert.AreEqual("Test Description", result.Description);
            Assert.AreEqual(4, result.StarsRating);
        }

        [Test]
        public async Task EditCommentByIdAndFormModel_ShouldUpdateCommentProperties()
        {
            var commentId = Guid.NewGuid();
            var comment = new Comment
            {
                Id = commentId,
                Title = "Old Title",
                Description = "Old Description",
                StarsRating = 3
            };
            dbContext.Comments.Add(comment);
            dbContext.SaveChanges();

            var updatedModel = new CommentFormModel
            {
                Title = "New Title",
                Description = "New Description",
                StarsRating = 5
            };
            await commentService.EditCommentByIdAndFormModel(commentId, updatedModel);
            var updatedComment = await dbContext.Comments.FindAsync(commentId);
            Assert.IsNotNull(updatedComment);
            Assert.AreEqual("New Title", updatedComment.Title);
            Assert.AreEqual("New Description", updatedComment.Description);
            Assert.AreEqual(5, updatedComment.StarsRating);
        }

        [Test]
        public async Task CreateAndReturnId_ShouldCreateNewCommentAndReturnItsId()
        {
            var formModel = new CommentFormModel
            {
                Title = "New Comment",
                Description = "This is a new comment.",
                StarsRating = 5
            };
            var userId = Guid.NewGuid();
            var commentId = await commentService.CreateAndReturnId(formModel, userId);
            Assert.IsNotNull(commentId);
            Assert.IsInstanceOf(typeof(string), commentId);
        }

        [Test]
        public async Task DeleteCommentById_ShouldDeleteComment_WhenCommentExists()
        {
            var commentId = Guid.NewGuid();
            await commentService.DeleteCommentById(commentId);
            var deletedComment = await dbContext.Comments.FindAsync(commentId);
            Assert.IsNull(deletedComment);
        }

        [Test]
        public async Task IsCreaterWithId_ShouldReturnTrue_WhenCreatorIdMatchesUserId()
        {
            var commentId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var comment = new Comment { Id = commentId, CreatorId = userId, Description = "test", Title = "Test", StarsRating = 5 };
            dbContext.Comments.Add(comment);
            dbContext.SaveChanges();
            var isCreator = await commentService.IsCreaterWithId(commentId, userId);
            Assert.IsTrue(isCreator);
        }
    }
}
