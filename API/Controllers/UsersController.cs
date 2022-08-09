using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Interfaces;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;

        public UsersController(IUserRepository _userRepository)
        {
            _userRepository = userRepository;
           
        }


        [HttpGet]
       
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
           
            return Ok(await _userRepository.GetUsersAsync());
           

        }
      
        [HttpGet("{username}")]
        public async Task<ActionResult<AppUser>> GetUsers(string username)
        {
            return await _userRepository.GetUserByUserNameAsync(username);

        }
    }
}
