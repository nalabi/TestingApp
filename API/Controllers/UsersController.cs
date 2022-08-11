using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Interfaces;
using API.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }


        [HttpGet]
       
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
           var users = await _userRepository.GetMembersAsync();
            return Ok(users);
           

        }
      
        [HttpGet("{username}")]
        public async Task<ActionResult<MemberDto>> GetUsers(string username)
        {
            return await _userRepository.GetMemberAsync(username);

            
        }
    }
}
