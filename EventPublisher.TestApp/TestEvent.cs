using EventPublisher.Core.Events;
using System;

namespace EventPublisher.TestApp
{
    public class TestEvent : IEvent
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public string Message { get; set; }
    }
}
