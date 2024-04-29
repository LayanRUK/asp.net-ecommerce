

using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

public class UserRepository : IUserRepository
{
    private IEnumerable<User> _users { get; set; }
    private DatabaseContext _databaseContext;
    public UserRepository()
    {
        _databaseContext = new DatabaseContext();
        _users = _databaseContext.users;
    }
    public IEnumerable<User> GetAll()
    {
        return _users;
    }
    public IEnumerable<User> CreateOne(User user)
    {
        return _users.Append(user);
    }
    public IEnumerable<User> DeleteOne(string id)
    {
        _users = _users.Where(u => u.Id != id);
        return _users;
    }
    // public IEnumerable<User> FindOne(string id)
    // {
    //     _users = _users.Where(u => u.Id == id);
    //     return _users;

    // }
}
