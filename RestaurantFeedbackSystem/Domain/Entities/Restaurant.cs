using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantFeedbackSystem.Domain.Entities
{
    public class Restaurant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string RestaurantName { get; set; }
        [Required, MaxLength(150)]
        public string Location { get; set; }
        public double Rating { get; set; } = 0;
        public ICollection<Feedback> Feedbacks { get; set; }


    }
}
