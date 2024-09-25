using userAsp.Entities; 
using userAsp.Models;
using System.Collections.Generic;
using System.Linq;

namespace userAsp.Services
{
    public class UserService : IUserService
    {
        private readonly UsersContext _context;

        public UserService()
        {
        }

        
        public UserService(UsersContext context)
        {
            _context = context;
        }

        
        public IEnumerable<Entities.User> Get()
        {
            
            return _context.Users.ToList();
        }
    }
}

