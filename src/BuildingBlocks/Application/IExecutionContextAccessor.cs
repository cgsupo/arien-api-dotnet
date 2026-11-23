namespace Osl.Arien.BuildingBlocks.Application;

public interface IExecutionContextAccessor
{
    Guid CorrelationId { get; }

    bool IsAvailable { get; }
}
