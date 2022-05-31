using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KukBuk.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }
        [Display (Name = "Recipe Name")]
        public string? Title { get; set; }
        public string? Description { get; set; }
        [Display (Name = "Photo")]
        public string? PhotoUrl { get; set; }

        [Display (Name = "Upload Date")]
        [DataType(DataType.Date)]
        public DateTime UploadDate { get; set; }

        [Display (Name = "Cuisine")]
        public string? Cuisine { get; set; }
    }
}