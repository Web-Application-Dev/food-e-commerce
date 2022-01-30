using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Application.Features;
using Universum.FoodEcommerce.Domain.DTO;
using Universum.FoodEcommerce.Domain.Entities;

namespace Universum.FoodEcommerce.Web.UI.Pages.Features
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        readonly UserService _userService;
        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("log-in")]
        public IActionResult LogIn(UserLogInDTO userLogIn)
        {
            return Ok(_userService.LogIn(userLogIn));
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            return Ok(_userService.Register(user));
        }

        [HttpPut]
        public IActionResult Update(User user)
        {
            return Ok(_userService.Update(user));
        }

        //public bool VerifyLogIn()
        //{
        //    return true;
        //}
    }
}
