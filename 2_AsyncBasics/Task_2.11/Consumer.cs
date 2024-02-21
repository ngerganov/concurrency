namespace Task2._11;

public class Consumer
{
    private readonly ValueTaskMethods _valueTaskMethods;

    public Consumer(ValueTaskMethods valueTaskMethods)
    {
        _valueTaskMethods = valueTaskMethods;
    }

    public async Task ConsumingMethodAsync()
    {
        int value = await _valueTaskMethods.MethodAsync();
        Console.WriteLine($"Consumed value: {value}");
    }
}