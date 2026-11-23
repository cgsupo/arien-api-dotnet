namespace Osl.Arien.BuildingBlocks.Domain.BusinessRules;

public sealed class BusinessRuleBrokenException(IBusinessRule brokenRule)
    : Exception(brokenRule.Message)
{
    public IBusinessRule BrokenRule { get; } = brokenRule;
}
