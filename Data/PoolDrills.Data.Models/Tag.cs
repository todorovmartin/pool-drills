namespace PoolDrills.Data.Models
{
    using System.Collections.Generic;

    public class Tag
    {
        public Tag()
        {
            this.DrillTags = new HashSet<DrillTag>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public virtual ICollection<DrillTag> DrillTags { get; set; }
    }
}
