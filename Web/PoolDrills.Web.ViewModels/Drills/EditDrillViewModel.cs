namespace PoolDrills.Web.ViewModels.Drills
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class EditDrillViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "\"{0}\" is reqired.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "\"{0}\" should be min {2} and max {1}.")]
        public string Title { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "\"{0}\" is required.")]
        public string Category { get; set; }

        [Display(Name = "Difficulty")]
        [Required(ErrorMessage = "\"{0}\" is required.")]
        public string Difficulty { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
    }
}
