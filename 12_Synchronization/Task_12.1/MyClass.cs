namespace Task_12._1;

public class MyClass
{
    private readonly object _mutex = new object();
    private int _value;

    public void Increment()
    {
        lock (_mutex)
        {
            _value = _value + 1;
        }
    }

    public int GetValue()
    {
        lock (_mutex)
        {
            return _value;
        }
    }
}