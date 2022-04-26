using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Application.Common.Interfaces;

public interface IDomainEventService
{
    // pattern -> observer
    Task Publish(DomainEvent domainEvent);
}
