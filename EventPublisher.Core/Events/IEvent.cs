using System;

namespace EventPublisher.Core.Events
{
    public interface IEvent
    {
        Guid Id { get; set; }
        DateTime Created { get; set; }
    }
}
