using System;
using NServiceBus;

namespace Order.Contracts
{
    public class PlaceOrder : ICommand
    {
        public string CustomerId { get; set; }
        public Guid OrderId { get; set; }
    }
}