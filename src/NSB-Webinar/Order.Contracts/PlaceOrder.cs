using System;
using NServiceBus;

namespace Order.Contracts
{
    public class PlaceOrder : ICommand
    {
        public Guid OrderId { get; set; }
        public string CustomerId { get; set; }
    }
}