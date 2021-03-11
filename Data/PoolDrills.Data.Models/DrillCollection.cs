namespace PoolDrills.Data.Models
{
    public class DrillCollection
    {
        public int Id { get; set; }

        public int DrillId { get; set; }

        public virtual Drill Drill { get; set; }

        public int CollectionId { get; set; }

        public virtual Collection Collection { get; set; }
    }
}
