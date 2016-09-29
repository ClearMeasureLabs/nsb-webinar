using System.Threading;
using NServiceBus;
using Order.Contracts;
using static System.Console;

namespace Order.Processor
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        public void Handle(PlaceOrder message)
        {
            WriteLine($"Processing Order {message.OrderId} for customer {message.CustomerId}");
            Thread.Sleep(3000);
            WriteLine($"Order processed for {message.CustomerId}");
        }
    }
}