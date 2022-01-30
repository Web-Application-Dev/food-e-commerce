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
    public class ProductTypesController : Controller
    {
        readonly ProductTypeService _productTypeService;
        public ProductTypesController(ProductTypeService productTypeService)
        {
            _productTypeService = productTypeService;
        }
        
        [HttpDelete]
        public bool Delete(ProductType product)
        {
            return true;
        }
        [HttpGet("get-by-id")]
        public IActionResult GetProductType(int id)
        {
            return Ok(_productTypeService.GetProductType(id));
        }
        [HttpGet]
        public IActionResult GetProductTypes()
        {
            return Ok(_productTypeService.GetProductTypes());
        }
        [HttpPost]
        public IActionResult Register(ProductType product)
        {
            return Ok(_productTypeService.Register(product));
        }

        [HttpPut]
        public IActionResult Update(ProductType product)
        {
            return Ok(_productTypeService.Update(product));
        }
    }
}
