
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
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<User>> CreateOne([FromBody] User user)
        {
            // always return only one i create it 
            if (user is not null)
            {
                _userService.CreateOne(user);
                return CreatedAtAction(nameof(CreateOne), user);
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public IEnumerable<User> DeleteOne(Guid id)
        {
            return _userService.DeleteOne(id);
        }
        [HttpGet("{id}")]
        public IEnumerable<User> FindOne(Guid id)
        {
            return _userService.FindOne(id);
        }

    }
}
