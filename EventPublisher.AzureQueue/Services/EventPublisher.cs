using EventPublisher.Core.Events;
using EventPublisher.Core.Services;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace EventPublisher.AzureQueue.Services
{
    public class EventPublisher : IEventPublisher
    {
        private readonly CloudQueueClient _queueClient;

        public EventPublisher(string connectionString)
        {
            var storageAccount = CloudStorageAccount.Parse(connectionString);

            _queueClient = storageAccount.CreateCloudQueueClient();
        }
        public async Task Publish(string queueName, IEvent @event)
        {
            var queue = _queueClient.GetQueueReference(queueName);
            await queue.CreateIfNotExistsAsync();
            var message = new CloudQueueMessage(JsonConvert.SerializeObject(@event));
            await queue.AddMessageAsync(message);

        }
    }
}
