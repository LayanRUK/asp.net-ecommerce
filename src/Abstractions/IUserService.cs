

using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IUserService
    {
        public IEnumerable<User> GetAll();
        public IEnumerable<User> CreateOne(User user);
        public IEnumerable<User> DeleteOne(string id);
        // FindOne
        public IEnumerable<User> FindOne(string id);
    }
}