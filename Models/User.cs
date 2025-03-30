namespace Fitness.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public ICollection<Workout> Workouts { get; set; } = [];

    }
}
