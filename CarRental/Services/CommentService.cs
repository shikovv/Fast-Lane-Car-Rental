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
            dbContext = context;
        }

        public async Task<List<Comment>> AllCommentsByCreationTime()
        {
            return context.Comments.OrderByDescending(c => c.CreatedOn).ToList();
        }

        public async Task<bool> ExistById(Guid CommentId)
        {
            bool result = await this.context
                .Comments
                .AnyAsync(c => c.Id == CommentId);

            return result;
        }

        public async Task<CommentDetailsModel> GetCommentForDetailsById(Guid commentId)
        {
            Comment comment = await this.context
                .Comments
                .Include(c => c.Creator)
                .FirstAsync(c => c.Id == commentId);

            return new CommentDetailsModel
            {
                Id = comment.Id,
                Title = comment.Title,
                Description = comment.Description,
                StarsRating = comment.StarsRating,
                CreatedOn = comment.CreatedOn,
                CreaterFullName = comment.Creator.FirstName + " " + comment.Creator.LastName
        };
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


    }
}
