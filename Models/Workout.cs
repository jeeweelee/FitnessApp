namespace Fitness.Model
{
    public class Workout
    {

        public int Id { get; set; }
        public ICollection<Leg> LegWorkouts { get; set; } = [];
        public ICollection<Chest> ChestWorkouts { get; set; } = [];

        public User User { get; set; }
        public int UserId { get; set; }

    }
}
