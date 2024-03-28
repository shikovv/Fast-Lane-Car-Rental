namespace CarRental.Models.Comment
{
    public class AllCommentViewModel
    {
        public AllCommentViewModel() 
        { 
            this.Comments=new HashSet<CommentViewModel>();
        }
        public IEnumerable<CommentViewModel> Comments { get; set; }
    }
}
