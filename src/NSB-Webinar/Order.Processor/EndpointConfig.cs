namespace Order.Processor
{
    using NServiceBus;

    public class EndpointConfig : IConfigureThisEndpoint
    {
        public void Customize(BusConfiguration configuration)
        {
        	System.Console.Title = "Order Processor";
            configuration.UseSerialization<JsonSerializer>();
            configuration.EndpointName("Order.Processor");
            configuration.UseTransport<MsmqTransport>();
            configuration.UsePersistence<InMemoryPersistence>();
        }
    }
}
