using System;

namespace EventPublisher.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "UseDevelopmentStorage=true;";

            var @event = new TestEvent
            {
                Id = Guid.NewGuid(),
                Message = "This is a test!"
            };

            var eventPublisher = new AzureQueue.Services.EventPublisher(connectionString);

            eventPublisher.Publish("test-queue", @event).GetAwaiter();

            Console.WriteLine("Message Sent!");
            Console.ReadKey();
        }
    }
}
