

using System.Text;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Utils;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services;

public class UserService : IUserService
{
    private IUserRepository _userRepository;
    private IConfiguration _config;

    public UserService(IUserRepository userRepository, IConfiguration config)
    {
        _userRepository = userRepository;
        _config = config;
    }

    public IEnumerable<User> GetAll()
    {
        return _userRepository.GetAll();
    }
    public IEnumerable<User> CreateOne(User user)
    {
        byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]!);
        PasswordUtils.HashPassword(user.Password, out string hashedPassword, pepper);
        user.Password = hashedPassword;
        return _userRepository.CreateOne(user);
    }
    public IEnumerable<User> DeleteOne(Guid id)
    {
        return _userRepository.DeleteOne(id);
    }
    public IEnumerable<User> FindOne(Guid id)
    {
        return _userRepository.FindOne(id);
    }


}
