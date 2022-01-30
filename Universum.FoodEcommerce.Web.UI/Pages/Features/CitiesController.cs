using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Application.Interfaces;
using Universum.FoodEcommerce.Domain.Entities;

namespace Universum.FoodEcommerce.Web.UI.Pages.Features
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : Controller
    {
      
        readonly ICityService _cityService;
        public CitiesController(ICityService cityService)
        {
            _cityService = cityService;
        }
        [HttpGet("get-by-id")]
        public IActionResult GetByStateId(int stateId)
        {
            return Ok(_cityService.GetByStateId(stateId));
        }
        [HttpGet]
        public IActionResult GetByZipCode(string zipcode)
        {
            return Ok(_cityService.GetByZipCode(zipcode));
        }


    }
}
