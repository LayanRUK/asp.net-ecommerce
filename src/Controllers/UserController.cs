
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Utils;

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
        public List<UserReadDto> GetAll()
        {
            return _userService.GetAll();
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<User> CreateOne([FromBody] UserCreateDto user)
        {
            // always return only one i create it 
            if (user is not null)
            {

                var createdUser = _userService.CreateOne(user);
                return CreatedAtAction(nameof(CreateOne), user);
            }
            return BadRequest();
        }
        // [HttpDelete("{id}")]
        // public IEnumerable<User> DeleteOne(Guid id)
        // {
        //     return _userService.DeleteOne(id);
        // }
        [HttpGet("{email}")]
        public UserReadDto FindOne(string email)
        {
            return _userService.FindOne(email);
        }
        [HttpPost("/test")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<User> CreateOneTest([FromBody] UserCreateDto userCreate)
        {
            // always return only one i create it 
            if (userCreate is not null)
            {

                var createdUser = _userService.CreateOne(userCreate);
                return CreatedAtAction(nameof(CreateOne), userCreate);
            }
            return BadRequest();
        }

    }
}
