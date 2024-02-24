using NUnit.Framework;

namespace Task_7._2;

public static class AssertExtensions
{
    public static async Task<TException?> ThrowsAsync<TException>(Func<Task> action, bool allowDerivedTypes = true)
        where TException : Exception
    {
        try
        {
            await action();
            var name = nameof(Exception);
            Assert.Fail($"Delegate did not throw expected exception {name}.");
            return null;
        }
        catch (Exception ex)
        {
            if (allowDerivedTypes && !(ex is TException))
                Assert.Fail($"Delegate threw exception of type {ex.GetType().Name}, but {typeof(TException).Name} or a derived type was expected.");
            if (!allowDerivedTypes && ex.GetType() != typeof(TException))
                Assert.Fail($"Delegate threw exception of type {ex.GetType().Name}, but {typeof(TException).Name} was expected.");
            return (TException)ex;
        }
    }
}