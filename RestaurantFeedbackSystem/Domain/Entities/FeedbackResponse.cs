using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantFeedbackSystem.Domain.Entities
{
    public class FeedbackResponse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int FeedbackId { get; set; }
        [Required, MaxLength(300)]
        public string ResponseMessage { get; set; }
        [Required]
        public string RespondedById { get; set; }
        [Required]
        public DateTime SubmitedDate { get; set; }
        [ForeignKey(nameof(FeedbackId))]
        public Feedback Feedback { get; set; }
    }
}
