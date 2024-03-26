namespace CarRental.Models.Comment
{
    public class CommentFormModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int StarsRating { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
