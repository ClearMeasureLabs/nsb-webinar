using System;
using NServiceBus;
using Order.Contracts;

namespace Email.Processor
{
    public class OrderPlacedHandler : IHandleMessages<OrderPlaced>
    {
        public void Handle(OrderPlaced message)
        {
            Console.WriteLine($"Sending email to customer {message.CustomerId}");
        }
    }
}