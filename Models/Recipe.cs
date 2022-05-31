using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KukBuk.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Display (Name = "Recipe Name")]
        [StringLength(60, MinimumLength =3)]
        [Required]
        public string? Title { get; set; }

        [Range(0, 5000)]
        public string? Description { get; set; }
        [Display (Name = "Photo")]

        [RegularExpression(@"[(http(s)?):\/\/(www\.)?a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)")]
        public string? PhotoUrl { get; set; }

        [Display (Name = "Upload Date")]
        [DataType(DataType.Date)]
        public DateTime UploadDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Display (Name = "Cuisine")]
        public string? Cuisine { get; set; }
    }
}