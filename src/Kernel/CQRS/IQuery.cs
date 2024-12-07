using MediatR;

namespace RealBlank.Kernel.CQRS;

public interface IQuery<out TResponse> : IRequest<TResponse>;
