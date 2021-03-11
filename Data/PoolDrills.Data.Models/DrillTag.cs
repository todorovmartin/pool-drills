namespace PoolDrills.Data.Models
{
    public class DrillTag
    {
        public int Id { get; set; }

        public int DrillId { get; set; }

        public virtual Drill Drill { get; set; }

        public int TagId { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
