using System.Linq.Expressions;

namespace RealBlank.Kernel;

public interface ISpecification<T>
{
    Expression<Func<T, bool>>? Query { get; }
    bool IsSatisfiedBy(T inner);
}
