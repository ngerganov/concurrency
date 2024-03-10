namespace Task_14._6;

public static class Try
{
    public static Try<T> FromValue<T>(T value)
    {
        return new Try<T>(value);
    }

    public static Try<T> FromException<T>(Exception exception)
    {
        return new Try<T>(exception);
    }
}

public class Try<T>
{
    public T Value { get; }
    public Exception Exception { get; }
    public bool IsValue => Exception == null;

    public Try(T value)
    {
        Value = value;
    }

    public Try(Exception exception)
    {
        Exception = exception;
    }

    public Try<TOutput> Map<TOutput>(Func<T, TOutput> func)
    {
        try
        {
            return IsValue ? Try.FromValue(func(Value)) : Try.FromException<TOutput>(Exception);
        }
        catch (Exception ex)
        {
            return Try.FromException<TOutput>(ex);
        }
    }
}