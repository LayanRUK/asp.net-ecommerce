

using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

public class UserRepository : IUserRepository
{
    private IEnumerable<User> _users { get; }
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

}
