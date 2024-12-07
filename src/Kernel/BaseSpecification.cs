using System.Linq.Expressions;

namespace RealBlank.Kernel;

public abstract class BaseSpecification<T> : ISpecification<T>
{
    public Expression<Func<T, bool>>? Query { get; protected set; }

    public bool IsSatisfiedBy(T inner)
    {
        if (inner == null) 
            throw new ArgumentNullException(nameof(inner));

        if (Query == null)
            return false;

        var func = Query.Compile();
        return func(inner);
    }
}
