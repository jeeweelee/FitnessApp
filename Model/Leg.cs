namespace Fitness.Model
{
    public class Leg
    {   
        public int Id { get; set; }
        public long? Squat { get; set; }
        public long? LegCurl {  get; set; }
        public long? LegPress {  get; set; }
        public long? LegExtension { get; set; }
        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }
    }
}
