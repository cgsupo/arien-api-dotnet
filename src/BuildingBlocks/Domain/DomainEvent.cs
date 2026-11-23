namespace Osl.Arien.BuildingBlocks.Domain;

public abstract record DomainEvent : IDomainEvent
{
    public Guid EventId { get; init; } = Guid.CreateVersion7();

    public DateTime OccurredOn { get; init; } = DateTime.UtcNow;
}
