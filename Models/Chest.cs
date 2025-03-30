namespace Fitness.Model
{
    public class Chest
    {   public int Id { get; set; }
        public long? FlatBench {  get; set; }
        public long? InclineBench { get; set; }
        public long? CableFlly {  get; set; }
        public long? InclineCableFly { get; set; }
        public int WorkoutId { get; set; }
        public Workout? Workout { get; set; }
    }
}
