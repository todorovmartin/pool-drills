namespace PoolDrills.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class DrillRoutine
    {
        public DrillRoutine()
        {
            this.Entries = new HashSet<Entry>();
        }

        public int Id { get; set; }

        public int DrillId { get; set; }

        public virtual Drill Drill { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public DateTime? DateModified { get; set; }

        public virtual ICollection<Entry> Entries { get; set; }
    }
}
