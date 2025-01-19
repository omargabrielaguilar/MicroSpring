using Microsoft.AspNetCore.Mvc;
using UserApi.Models;
using UserApi.Services;
using System;

namespace UserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _userService.GetUsers();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            user.DateCreated = DateTime.Now;
            _userService.InsertUser(user);
            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }
    }
}

