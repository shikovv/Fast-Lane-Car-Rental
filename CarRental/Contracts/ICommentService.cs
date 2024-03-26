using CarRental.Data.Domain;
using CarRental.Models.Comment;

namespace CarRental.Contracts
{
    public interface ICommentService
    {
        Task<List<Comment>> AllCommentsByCreationTime();
        Task<bool> ExistById(Guid CommentId);
        Task<CommentDetailsModel> GetCommentForDetailsById(Guid commentId);
        Task<string> CreateAndReturnId(CommentFormModel formModel, Guid userId);
        Task<CommentFormModel> GetCommentForEditById(Guid commentId);
        Task EditCommentByIdAndFormModel(Guid commentId, CommentFormModel commentModel);
        Task DeleteCommentById(Guid commentId);
    }
}
