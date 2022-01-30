using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Application.Features;
using Universum.FoodEcommerce.Domain.Entities;

namespace Universum.FoodEcommerce.Web.UI.Pages.Features
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : Controller
    {
        readonly RoleService _roleService;
        public RolesController(RoleService roleService)
        {
            _roleService = roleService;
        }
        
        [HttpGet("get-by-id")]
        public IActionResult GetRole(int id)
        {
            return Ok(_roleService.GetRole(id));
        }
        [HttpGet]
        public IActionResult GetRoles()
        {
            return Ok(_roleService.GetRoles());
        }
    }
}
