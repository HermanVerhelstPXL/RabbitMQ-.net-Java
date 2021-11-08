using Logic.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.API.Events
{
    public class HelloWorldEventHandler : IIntegrationEventHandler<String>
    {
        public Task Handle(String @event)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("New event");
                Console.WriteLine(@event);
            });
        }
    }
}
