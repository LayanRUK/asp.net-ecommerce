

using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

public interface IUserRepository
{
    public IEnumerable<User> GetAll();
}
