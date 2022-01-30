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
    public class GendersController : Controller
    {
        readonly GenderService _genderService;
        public GendersController(GenderService genderService)
        {
            _genderService = genderService;
        }

        [HttpGet("get-by-id")]
        public IActionResult GetGenderById(int genderId)
        {
            return Ok(_genderService.GetGenderById(genderId));
        }
        [HttpGet]
        public IActionResult GetList()
        {
            return Ok(_genderService.GetList());
        }

    }
}
