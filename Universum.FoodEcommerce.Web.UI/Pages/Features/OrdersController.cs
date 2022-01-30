using Microsoft.AspNetCore.Http;
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
    public class OrdersController : Controller
    {
        readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpDelete]
        public IActionResult Delete(Order product)
        {
            return Ok(_orderService.Delete(product));
        }
        [HttpGet("get-by-id")]
        public IActionResult GetOrder(int id)
        {
            return Ok(_orderService.GetOrder(id));
        }
        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok(_orderService.GetOrders());
        }
        [HttpPost]
        public IActionResult Register(Order product)
        {
            return Ok(_orderService.Register(product));
        }
        [HttpPut]
        public IActionResult Update(Order product)
        {
            return Ok(_orderService.Update(product));
        }
    }
}
