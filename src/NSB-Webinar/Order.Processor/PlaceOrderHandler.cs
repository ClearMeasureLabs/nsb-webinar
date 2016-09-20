using System;
using System.Threading;
using NServiceBus;
using Order.Contracts;

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
            Console.WriteLine($"Processing order {message.OrderId} for {message.CustomerId}");
            Thread.Sleep(3000);
            Console.WriteLine($"Order {message.OrderId} has been processed for {message.CustomerId}!");

            _bus.Publish(new OrderPlaced { CustomerId = message.CustomerId, OrderId = message.OrderId });
        }
    }
}