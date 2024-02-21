namespace Task_6._1;

public class CustomProgress<T> : ICustomProgress<T>
{
    public event EventHandler<T> ProgressChanged;

    public void Report(T value)
    {
        ProgressChanged?.Invoke(this, value);
    }
}