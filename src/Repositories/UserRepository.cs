

using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

public class UserRepository : IUserRepository
{
    private DbSet<User> _users { get; set; }
    private DatabaseContext _databaseContext;
    public UserRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext; 
        _users = _databaseContext.Users;
    }
    public IEnumerable<User>GetAll()
    {
        return _users;
    }
    public User CreateOne(User user)
    {
        
        _users.Add(user);

        return user;

    }
    // public IEnumerable<User> DeleteOne(Guid id)
    // {
    //     _users = _users.Where(u => u.Id != id);
    //     return _users;
    // }
    public User FindOne(string email)
    {
         return  _users.FirstOrDefault(u => u.Email == email);
   
    }
}
