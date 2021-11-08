using Logic.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.API.Events
{
    public class HelloWorldEvent : IntegrationEvent
    {
        public string Message { get; set; }
    }
}
