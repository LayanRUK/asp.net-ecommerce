

using System.Text;
using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Utils;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services;

public class UserService : IUserService
{
    private IUserRepository _userRepository;
    private IConfiguration _config;
    private IMapper _mapper;
    public UserService(IUserRepository userRepository, IConfiguration config, IMapper mapper)
    {
        _userRepository = userRepository;
        _config = config;

        _mapper = mapper;
    }

    public List<UserReadDto> GetAll()
    {
        
       var users =   _userRepository.GetAll();
       var userRead = users.Select(_mapper.Map<UserReadDto>);
       return userRead.ToList();
    }
    public UserReadDto CreateOne(UserCreateDto userCreateDto)
    {

        // map userCreateDto to user 
        var user  = _mapper.Map<User>(userCreateDto); 
        
        User? foundUser = _userRepository.FindOne(user.Email);
        if ( foundUser is not null )
        {
           return null;  
        }
        Console.WriteLine($"Hash password");
        
        byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]!);
        PasswordUtils.HashPassword(user.Password, out string hashedPassword, pepper);
        user.Password = hashedPassword;
        Console.WriteLine($"{hashedPassword}");
        
          var userCreate = _userRepository.CreateOne(user);
          return _mapper.Map<UserReadDto>(userCreate); 
        
    }
    // public IEnumerable<User> DeleteOne(Guid id)
    // {
    //     return _userRepository.DeleteOne(id);
    // }
     public UserReadDto FindOne(string email)
    {
        var user = _userRepository.FindOne(email);
        var userRead = _mapper.Map<UserReadDto>(user);
        return userRead;
    }


}
