using CarRental.Data.Domain;
using CarRental.Models.Comment;

namespace CarRental.Contracts
{
    public interface ICommentService
    {
        Task<IEnumerable<CommentDetailsModel>> AllCommentsByCreationTime();
        Task<bool> ExistById(Guid CommentId);
        Task<string> CreateAndReturnId(CommentFormModel formModel, Guid userId);
        Task<CommentFormModel> GetCommentForEditById(Guid commentId);
        Task EditCommentByIdAndFormModel(Guid commentId, CommentFormModel commentModel);
        Task DeleteCommentById(Guid commentId);
        Task<bool> IsCreaterWithId(Guid id, Guid userId);
    }
}
