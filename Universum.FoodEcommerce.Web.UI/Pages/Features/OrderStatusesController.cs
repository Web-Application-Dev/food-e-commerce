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
    public class OrderStatusesController : Controller
    {
        readonly IOrderStatusService _orderStatusService;
        public OrderStatusesController(IOrderStatusService orderStatusService)
        {
            _orderStatusService = orderStatusService;
        }
        [HttpGet("get-by-id")]
        public IActionResult GetOrderStatus(int id)
        {
            return Ok(_orderStatusService.GetOrderStatus(id));
        }
        [HttpGet]
        public IActionResult GetOrderStatuses()
        {
            return Ok(_orderStatusService.GetOrderStatuses());
        }
        [HttpPost]
        public IActionResult Register(OrderStatus product)
        {
            return Ok(_orderStatusService.Register(product));
        }
        [HttpPut]
        public IActionResult Update(OrderStatus product)
        {
            return Ok(_orderStatusService.Update(product));
        }
    }
}
