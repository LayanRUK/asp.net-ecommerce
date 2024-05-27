

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
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

        var users = _userRepository.GetAll();
        var userRead = users.Select(_mapper.Map<UserReadDto>);
        return userRead.ToList();
    }
    public UserReadDto SignUp(UserCreateDto userCreateDto)
    {

        // map userCreateDto to user 
        var user = _mapper.Map<User>(userCreateDto);

        User? foundUser = _userRepository.FindOne(user.Email);
        if (foundUser is not null)
        {
            return null;
        }


        byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]!);
        PasswordUtils.HashPassword(user.Password, out string hashedPassword, pepper);
        user.Password = hashedPassword;


        User userCreate = _userRepository.CreateOne(user);
        UserReadDto userRead = _mapper.Map<UserReadDto>(userCreate);
        return userRead;

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


    public String SignIn(UserSignInDto userSign)
    {
User? user = _userRepository.FindOneByEmail(userSign.Email);
        // User? user = _userRepository.FindOne(userSign.Email);
        if (user is null) return null;
        byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]!);

        bool isCorrectPass = PasswordUtils.VerifyPassword(userSign.Password, user.Password, pepper);
        if (!isCorrectPass) return null;

        // UserReadDto userRead = _mapper.Map<UserReadDto>(user);

        // return userRead;   

        var claims = new[] 
                     {
            new Claim(ClaimTypes.Name, user.Name),
            new Claim(ClaimTypes.Role, user.role.ToString()),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
        };
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:SigningKey"]!));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(
            issuer: _config["Jwt:Issuer"],
            audience: _config["Jwt:Audience"],
            claims: claims,
            expires: DateTime.Now.AddDays(7),
            signingCredentials: creds
        );
        var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
        return tokenString;


    }
    public ActionResult<bool> DeleteOne(string name )
        {
            var foundUser = _userRepository.FindOne(name);
            if (foundUser is null)
            {
                Console.WriteLine($"user is null in service file");
                return false;
            }
               Console.WriteLine($"user is not null in service file");
            return _userRepository.DeleteOne(foundUser);
        }

        public bool UpdateOne(string name, UserUpdateDto updateDto)
        {
            var foundUser = _userRepository.FindOne(name);
             Console.WriteLine($"user is not null in service file");
            if (foundUser == null)
            {
                return false;
            }
            foreach (var property in updateDto.GetType().GetProperties())
            {
                if (property.GetValue(updateDto) is null)
                {
                    property.SetValue(updateDto, foundUser.GetType().GetProperty(property.Name).GetValue(foundUser));
                }
            }
            var mappedUser = _mapper.Map(updateDto, foundUser);
            return _userRepository.UpdateOne(mappedUser);
        }

}
