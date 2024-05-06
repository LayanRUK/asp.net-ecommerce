

using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IUserService
    {
        public List<UserReadDto> GetAll();
        public User CreateOne(UserCreateDto user);
        public UserReadDto FindOne(string email);
        // public IEnumerable<User> DeleteOne(Guid id);
        // FindOne
  
    }
}