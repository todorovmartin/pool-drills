namespace PoolDrills.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Collection
    {
        public Collection()
        {
            this.DrillCollections = new HashSet<DrillCollection>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public DateTime? ModifiedOn { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<DrillCollection> DrillCollections { get; set; }
    }
}
