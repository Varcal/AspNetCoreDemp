using System;
using SharedKernel.DomainEvents.Events;

namespace SharedKernel.Events
{
    public abstract class Event: DomainEvent
    {
        public DateTime DateOccurred { get; protected set; }

        protected Event()
        {
            DateOccurred = DateTime.Now;
        }
    }
}
