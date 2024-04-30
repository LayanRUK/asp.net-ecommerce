

using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services;

public class UserService : IUserService
{
    private IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public IEnumerable<User> GetAll()
    {
        return _userRepository.GetAll();
    }
    public IEnumerable<User> CreateOne(User user)
    {
        return _userRepository.CreateOne(user);
    }
    public IEnumerable<User> DeleteOne(string id)
    {
        return _userRepository.DeleteOne(id);
    }
    public IEnumerable<User> FindOne(string id)
    {
        return _userRepository.FindOne(id);
    }


}
