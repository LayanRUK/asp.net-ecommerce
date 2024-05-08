
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
        [HttpPost("signup")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<UserReadDto> SingUp([FromBody] UserCreateDto user)
        {
            // always return only one i create it 
            if (user is not null)
            {
                Console.WriteLine($"Receive user data");


                var createdUser = _userService.SignUp(user);
                return CreatedAtAction(nameof(SingUp), createdUser);
            }
            return BadRequest();
        }


        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<UserReadDto> SignIn([FromBody] UserSignInDto user)
        {
            // always return only one i create it 
            if (user is not null)
            {
                UserReadDto? userRead = _userService.SignIn(user);
                if (userRead is null)
                {
                    return BadRequest();
                }
                return Ok(userRead);
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


    }
}
