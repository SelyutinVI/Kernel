namespace RealBlank.Kernel;

public abstract class BaseAggregate(Guid? uuid) : IAggregate
{
    public Guid UUID { get; init; } = uuid ?? Guid.NewGuid();
}

