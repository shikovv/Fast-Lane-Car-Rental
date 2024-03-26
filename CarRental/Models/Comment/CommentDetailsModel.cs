using System.ComponentModel.DataAnnotations;

namespace CarRental.Models.Comment
{
    public class CommentDetailsModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int StarsRating { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreaterFullName { get; set; }
    }
}
