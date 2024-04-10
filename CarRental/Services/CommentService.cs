using CarRental.Contracts;
using CarRental.Data;
using CarRental.Data.Domain;
using CarRental.Models.Comment;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CarRental.Services
{
    public class CommentService:ICommentService
    {
        private readonly ApplicationDbContext context;
        public CommentService(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public async Task<IEnumerable<CommentDetailsModel>> AllCommentsByCreationTime()
        {
            IEnumerable<CommentDetailsModel> allComments = await this.context
                 .Comments
                 .Select(c => new CommentDetailsModel()
                 {
                     Id = c.Id.ToString(),
                     Title = c.Title,
                     Description = c.Description,
                     CreatedOn = c.CreatedOn,
                     StarsRating = c.StarsRating,
                     CreaterFullName = c.Creator.FirstName + " " + c.Creator.LastName
                 })
                 .OrderByDescending(c => c.CreatedOn)
                 .ToArrayAsync();

            return allComments;

        }

        public async Task<bool> ExistById(Guid CommentId)
        {
            bool result = await this.context
                .Comments
                .AnyAsync(c => c.Id == CommentId);

            return result;
        }

        public async Task<string> CreateAndReturnId(CommentFormModel formModel, Guid userId)
        {
            Comment comment = new Comment()
            {
                Title = formModel.Title,
                Description = formModel.Description,
                StarsRating=formModel.StarsRating,
                CreatedOn = formModel.CreatedOn,
                CreatorId = userId
            };

            await this.context.Comments.AddAsync(comment);
            await this.context.SaveChangesAsync();

            return comment.Id.ToString();
        }

        public async Task<CommentFormModel> GetCommentForEditById(Guid commentId)
        {
            Comment comment = await this.context
                .Comments
                .FirstAsync(c => c.Id == commentId);

            return new CommentFormModel()
            {
                Title = comment.Title,
                Description = comment.Description,
                StarsRating=comment.StarsRating,
            };
        }

        public async Task EditCommentByIdAndFormModel(Guid commentId, CommentFormModel commentModel)
        {
            Comment comment = await this.context
                .Comments
                .FirstAsync(c => c.Id == commentId);

            comment.Title = commentModel.Title;
            comment.StarsRating = commentModel.StarsRating;
            comment.Description = commentModel.Description;

            await this.context.SaveChangesAsync();
        }

        public async Task DeleteCommentById(Guid commentId)
        {
            var commentToDelete = context.Comments.FirstOrDefault(c => c.Id == commentId);

            if (commentToDelete != null)
            {
                context.Comments.Remove(commentToDelete);
                context.SaveChanges();
            }
        }

        public async Task<bool> IsCreaterWithId(Guid id, Guid userId)
        {
            Comment comment = await this.context
                .Comments
                .FirstAsync(c => c.Id == id);

            return comment.CreatorId == userId;
        }
    }
}
