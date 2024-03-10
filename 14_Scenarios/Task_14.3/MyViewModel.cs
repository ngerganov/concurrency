namespace Task_14._3;

public class MyViewModel
{
    public MyViewModel()
    {
        MyValue = new BindableTask<int>(CalculateMyValueAsync());
    }

    public BindableTask<int> MyValue { get; private set; }

    private async Task<int> CalculateMyValueAsync()
    {
        await Task.Delay(TimeSpan.FromSeconds(2));
        return 13;
    }
}