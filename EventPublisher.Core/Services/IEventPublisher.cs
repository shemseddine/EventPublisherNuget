using EventPublisher.Core.Events;
using System.Threading.Tasks;

namespace EventPublisher.Core.Services
{
    public interface IEventPublisher
    {
        Task Publish(string queueName, IEvent @event);
    }
}
