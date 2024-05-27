

using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IUserService
    {
        public List<UserReadDto> GetAll();
        public UserReadDto SignUp(UserCreateDto user);

        public String SignIn(UserSignInDto user);
        public UserReadDto FindOne(string email);
        // public IEnumerable<User> DeleteOne(Guid id);
        // FindOne
public ActionResult<bool> DeleteOne(string name);
        public bool UpdateOne(string name, UserUpdateDto updateDto);
    }
}