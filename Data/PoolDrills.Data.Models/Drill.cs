namespace PoolDrills.Data.Models
{
    using System;
    using System.Collections.Generic;

    using PoolDrills.Data.Models.Enums;

    public class Drill
    {
        public Drill()
        {
            this.DrillTags = new HashSet<DrillTag>();
            this.FavoriteDrills = new HashSet<FavoriteDrill>();
            this.DrillRoutines = new HashSet<DrillRoutine>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; } // todo

        public DateTime DateAdded { get; set; } = DateTime.UtcNow;

        public bool IsApproved { get; set; }

        public bool IsHidden { get; set; }

        public string AuthorId { get; set; }

        public ApplicationUser Author { get; set; }

        public virtual Category Category { get; set; }

        public virtual Difficulty Difficulty { get; set; }

        public virtual ICollection<DrillTag> DrillTags { get; set; }

        public virtual ICollection<FavoriteDrill> FavoriteDrills { get; set; }

        public virtual ICollection<DrillRoutine> DrillRoutines { get; set; }

        public virtual ICollection<DrillCollection> DrillCollections { get; set; }
    }
}
