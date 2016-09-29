using System;
using NServiceBus;

namespace Order.Contracts
{
    public class OrderPlaced : IEvent
    {
        public Guid OrderId { get; set; }
        public string CustomerId { get; set; }
    }
}