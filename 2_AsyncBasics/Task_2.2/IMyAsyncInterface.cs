namespace Task2._2;

public interface IMyAsyncInterface
{
    Task<int> GetValueAsync();
    Task DoSomethingAsync();
}