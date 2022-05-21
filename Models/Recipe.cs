using System.ComponentModel.DataAnnotations;

namespace KukBuk.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? PhotoUrl { get; set; }

        [DataType(DataType.Date)]
        public DateTime UploadDate { get; set; }
    }
}