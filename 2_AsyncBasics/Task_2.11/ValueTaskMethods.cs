namespace Task2._11;

public class ValueTaskMethods
{
    public ValueTask<int> MethodAsync()
    {
        return new ValueTask<int>(Task.Delay(100).ContinueWith(_ => 13));
    }
}