namespace template.Kernel.Result;

public class Result<T, E>
{
    private readonly T? _value;

    public T? Value
    {
        get
        {
            if (Error != null)
                throw new ResultException(Error.ToString() ?? "unkown");

            return _value;
        }
    }

    public ErrorWrapper<E>? Error { get; }

    public bool IsError
    {
        get
        {
            return Error == null;
        }
    }

    public Result(T value)
    {
        Error = null;
        _value = value;
    }

    public Result(E error)
    {
        Error = new ErrorWrapper<E>(error);
        _value = default;
    }

    public Result(T value, E error)
    {
        Error = new ErrorWrapper<E>(error);
        _value = value;
    }

    public class ErrorWrapper<T>(T value)
    {
        public T Value { get; set; } = value;
    }
}

