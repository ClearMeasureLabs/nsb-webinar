using System;
using System.Threading;
using NServiceBus;
using Order.Contracts;
using static System.Console;

namespace Order.Processor
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        private readonly IBus _bus;

        public PlaceOrderHandler(IBus bus)
        {
            _bus = bus;
        }

        public void Handle(PlaceOrder message)
        {
            WriteLine($"Processing Order {message.OrderId} for customer {message.CustomerId}");
            Thread.Sleep(3000);
            WriteLine($"Order processed for {message.CustomerId}");
            _bus.Publish(new OrderPlaced { OrderId = message.OrderId, CustomerId = message.CustomerId });
        }
    }
}