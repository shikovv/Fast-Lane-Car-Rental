namespace CarRental.Models.Comment
{
    public class AllCommentViewModel
    {
        public AllCommentViewModel() 
        { 
            this.Comments=new HashSet<CommentDetailsModel>();
        }
        public IEnumerable<CommentDetailsModel> Comments { get; set; }
    }
}
