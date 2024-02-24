namespace Task_7._3;

public class MyClassWrapper
{
    private readonly MyClass _myClass;

    public MyClassWrapper()
    {
        _myClass = new MyClass();
    }

    public async Task MyTaskMethodAsync()
    {
        await Task.Run(() => _myClass.MyVoidMethodAsync());
    }
}