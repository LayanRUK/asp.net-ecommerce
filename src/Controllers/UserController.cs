
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "Admin")]
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
        public ActionResult<string> SignIn([FromBody] UserSignInDto user)
        {
            // always return only one i create it 
            if (user is not null)
            {
                string  Token = _userService.SignIn(user);
                if (Token is null)
                {
                    return BadRequest();
                }
                return Ok(Token);
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

[HttpPatch("{name}")]
        public ActionResult<bool> UpdateOne([FromRoute] string name, [FromBody] UserUpdateDto updateDto)
        {
            var updated = _userService.UpdateOne(name, updateDto);
            return Ok(updated);
        }
        [HttpDelete("{name}")]
        public ActionResult<bool> DeleteOne([FromRoute] string name)
        {
            Console.WriteLine($"name from query {name}");
            var deleted = _userService.DeleteOne(name);
            return NoContent();
        }
    }
}
