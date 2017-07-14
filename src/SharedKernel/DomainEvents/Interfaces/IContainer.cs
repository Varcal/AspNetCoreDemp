using SharedKernel.Events;

namespace SharedKernel.DomainEvents.Interfaces
{
    public interface IContainer
    {
        void RaiseEvent<T>(T theEvent) where T : Event;
    }
}
