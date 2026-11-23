namespace Osl.Arien.BuildingBlocks.Domain.BusinessRules;

public interface IBusinessRule
{
    string Message { get; }

    bool IsBroken();
}
