
namespace Email.Processor
{
    using NServiceBus;

    public class EndpointConfig : IConfigureThisEndpoint
    {
        public void Customize(BusConfiguration configuration)
        {
        	System.Console.Title = "Email Processor";
            configuration.UseSerialization<JsonSerializer>();
            configuration.EndpointName("Email.Processor");
            configuration.UseTransport<MsmqTransport>();
            configuration.UsePersistence<InMemoryPersistence>();
        }
    }
}
