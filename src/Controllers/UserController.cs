
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers
{

    public class UserController : BaseController
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return _userService.GetAll();
        }
        [HttpPost]
        public IEnumerable<User> CreateOne(User user)
        {
            return _userService.CreateOne(user);
        }
        [HttpDelete("{id}")]
        public IEnumerable<User> DeleteOne(string id)
        {
            return _userService.DeleteOne(id);
        }
        [HttpGet("{id}")]
        public IEnumerable<User> FindOne(string id)
        {
            return _userService.FindOne(id);
        }

    }
}
