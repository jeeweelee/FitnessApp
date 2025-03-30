using Microsoft.AspNetCore.Mvc;
using Fitness.Model;
namespace Fitness.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkoutController : Controller

    { private readonly DataContext _context;
        public WorkoutController(DataContext dataContext) {
            _context = dataContext;
        }

        [HttpGet]
        public ActionResult<List<Leg>>getAllLegs(){
            var legWorkout = _context.Legs.ToList();
            return legWorkout;
        }

        [HttpGet]
        public ActionResult<List<Chest>> getAllChests()
        {
            var chestWorkout = _context.Chests.ToList();
            return chestWorkout;
        }
        [HttpPost("addChest")]

        public ActionResult AddChest(Chest chest)
        {
            var newChest = new Chest
            {

                FlatBench = chest.FlatBench,
                InclineBench = chest.InclineBench,
                CableFlly = chest.CableFlly,
                InclineCableFly = chest.InclineCableFly,
                WorkoutId = chest.WorkoutId,
            };

            _context.Chests.Add(newChest);
            _context.SaveChanges();

            return Ok();
        }
    }
}
