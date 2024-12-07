using MediatR;

namespace RealBlank.Kernel.CQRS;

public interface ICommand<out TResponse> : IRequest<TResponse>;
