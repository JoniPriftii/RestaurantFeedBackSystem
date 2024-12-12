using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantSystem.Core.Entities
{
    public class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int RestaurantId { get; set; }
        [Required, MaxLength(300)]
        public string Comment { get; set; }
        [Required, Range(1, 5)]
        public int Rating { get; set; }
        [Required]
        public DateTime SubmitedDate {  get; set; }
        [ForeignKey(nameof(RestaurantId))]
        public Restaurant Restaurant { get; set; }
        public ICollection<FeedbackResponse> Responses { get; set; }
    }
}
