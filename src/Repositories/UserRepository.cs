
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;

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
    public IEnumerable<User> GetAll()
    {
        return _users;
    }
    public User CreateOne(User user)
    {
        _users.Add(user);
        _databaseContext.SaveChanges();
        return user;

    }
    // public IEnumerable<User> DeleteOne(Guid id)
    // {
    //     _users = _users.Where(u => u.Id != id);
    //     return _users;
    // }
    public User FindOne(string email)
    {


        return _users.FirstOrDefault(u => u.Email == email);

    }
    public bool DeleteOne(User deleteObject)
  {
    _users.Remove(deleteObject);
    Console.WriteLine($"Remove user object in repo file");
    _databaseContext.SaveChanges();
        Console.WriteLine($"database saves changes");
    return true;
  }
  public bool UpdateOne(User updateObject)
  {
    _users.Update(updateObject);
    _databaseContext.SaveChanges();
    return true;
  }
public User FindOneByEmail(string email)
  {
    return _users.FirstOrDefault(U => U.Email == email);
  }
}

