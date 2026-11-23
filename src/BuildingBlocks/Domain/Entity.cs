using Osl.Arien.BuildingBlocks.Domain.BusinessRules;

namespace Osl.Arien.BuildingBlocks.Domain;

public abstract class Entity
{
    protected static void CheckRule(IBusinessRule rule)
    {
        ArgumentNullException.ThrowIfNull(rule);

        if (rule.IsBroken())
        {
            throw new BusinessRuleBrokenException(rule);
        }
    }
}
