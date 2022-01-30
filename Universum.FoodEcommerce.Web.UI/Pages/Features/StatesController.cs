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
    public class StatesController : Controller
    {
        readonly StateService _stateService;
        public StatesController(StateService stateService)
        {
            _stateService = stateService;
        }
        [HttpGet]
        public IActionResult GetStates()
        {
            return Ok(_stateService.GetStates());
        }
    }
}
