using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Application.Interfaces;
using Universum.FoodEcommerce.Domain.Entities;

namespace Universum.FoodEcommerce.Web.UI.Pages.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        readonly IProductServices _productServices;
        public ProductsController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var result = _productServices.GetAllProducts();
            return Ok(result);
        }

        [HttpGet("get-product")]
        public IActionResult GetProductById([FromQuery] int id)
        {
            var result = _productServices.GetProductById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult RegisterProduct(Product product)
        {
            var result = _productServices.Add(product);
            return Ok(result);
        }

    }
}
