namespace Task_7._2;

public class MyClass
{
    public static async Task<int> DivideAsync(int dividend, int divisor)
    {
        if (divisor == 0)
            throw new DivideByZeroException();
        
        await Task.Delay(100);
        
        return dividend / divisor;
    }
}