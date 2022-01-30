using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Application.Interfaces;
using Universum.FoodEcommerce.Domain.Entities;

namespace Universum.FoodEcommerce.Web.UI.Pages.Features
{
    [Route("api/address")]
    [AllowAnonymous]
    [ApiController]
    public class AddressController : Controller
    {
        readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        public IActionResult GetAllAddresses()
        {
            return Ok(_addressService.GetAll());
        }

        [HttpGet("get-by-id")]
        public IActionResult GetAddressById(int id)
        {
            return Ok(_addressService.GetById(id));
        }
    }
}
