using System;
using NServiceBus;

namespace Order.Contracts
{
    public class OrderPlaced : IEvent
    {
        public string CustomerId { get; set; }
        public Guid OrderId { get; set; }
    }
}