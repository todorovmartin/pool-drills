namespace PoolDrills.Data.Models
{
    public class FavoriteDrill
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int DrillId { get; set; }

        public virtual Drill Drill { get; set; }
    }
}
