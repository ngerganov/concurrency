namespace Task2._10;

public class MyClass
{
    public async ValueTask<int> MethodAsync()
    {
        await Task.Delay(100);
        return 13;
    }
}