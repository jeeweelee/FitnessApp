using Fitness.Interfaces;
using Fitness.Model;

namespace Fitness.Services
{
    public class UserService: IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext dataContext)
        {
            _context = dataContext;
        }

        public List<User> getAllUser()
        {
            var users = _context.Users.ToList();
            return users;
        }
    }
}
