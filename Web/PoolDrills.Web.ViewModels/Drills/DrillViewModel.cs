namespace PoolDrills.Web.ViewModels.Drills
{
    using PoolDrills.Data.Models;

    public class DrillViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public string Difficulty { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string AuthorId { get; set; }

        public ApplicationUser Author { get; set; }

        public bool IsApproved { get; set; }

        public bool IsHidden { get; set; }
    }
}
