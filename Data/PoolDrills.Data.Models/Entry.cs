namespace PoolDrills.Data.Models
{
    public class Entry
    {
        public int Id { get; set; }

        public int MaxPoints { get; set; }

        public int UserPoints { get; set; }

        public int DrillRoutineId { get; set; }

        public virtual DrillRoutine DrillRoutine { get; set; }
    }
}
