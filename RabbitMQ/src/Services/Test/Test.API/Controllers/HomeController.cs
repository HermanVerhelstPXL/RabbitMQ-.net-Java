using Logic.Events;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.API.Events;

namespace Test.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IEventBus _eventBus;

        public HomeController(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        [HttpGet]
        public IActionResult GetMessage()
        {
            Console.WriteLine("...");
            HelloWorldEvent @event = new HelloWorldEvent
            {
                Message = "Hello from .NET"
            };
            _eventBus.Publish(@event);
            return Ok("Hello");
        }
    }
}
