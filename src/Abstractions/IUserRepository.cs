

using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

public interface IUserRepository
{
    public IEnumerable<User> GetAll();
    public IEnumerable<User> CreateOne(User user);
    public IEnumerable<User> DeleteOne(Guid id);
    public User? FindOne(string email);
}
