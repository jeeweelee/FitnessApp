using Fitness.Model;
using Microsoft.EntityFrameworkCore;
namespace Fitness
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Leg> Legs { get; set; }
        public DbSet<Chest> Chests { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One-to-Many relationship: User -> Workout
            modelBuilder.Entity<Workout>()
                .HasOne(w => w.User)
                .WithMany(u => u.Workouts)
                .HasForeignKey(w => w.UserId)
                .OnDelete(DeleteBehavior.Cascade);  

            // One-to-Many relationship: Workout -> Leg
            modelBuilder.Entity<Leg>()
                .HasOne(l => l.Workout)
                .WithMany(w => w.LegWorkouts)
                .HasForeignKey(l => l.WorkoutId)
                .OnDelete(DeleteBehavior.Cascade);  

            // One-to-Many relationship: Workout -> Chest
            modelBuilder.Entity<Chest>()
                .HasOne(c => c.Workout)
                .WithMany(w => w.ChestWorkouts)
                .HasForeignKey(c => c.WorkoutId)
                .OnDelete(DeleteBehavior.Cascade);  
        }
    }
}
