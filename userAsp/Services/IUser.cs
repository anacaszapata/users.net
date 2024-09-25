using userAsp.Entities;

namespace userAsp.Services
{
    public interface IUserService
    {
        public IEnumerable<User> Get();
    }
}
