namespace Task_11._4;

public class DataProcessor
{
    private readonly AsyncLazy<int> _data;

    public DataProcessor()
    {
        _data = new AsyncLazy<int>(async () =>
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            return 13;
        });
    }

    public AsyncLazy<int> GetDataAsync()
    {
        return _data;
    }
}