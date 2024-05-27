

using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

public interface IUserRepository
{
  public IEnumerable<User> GetAll();
  public User CreateOne(User user);

  public User? FindOne(string email);

  // public IEnumerable<User> DeleteOne(Guid id);
  public bool DeleteOne(User user);
  public bool UpdateOne(User updateObject);

  public User FindOneByEmail(string email);
}
