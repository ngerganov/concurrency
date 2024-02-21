namespace Task2._9;

public sealed class MyAsyncCommand : ICommand
{
    public async Task ExecuteAsync(object parameter)
    {
        await Execute(parameter);
    }

    private async Task Execute(object parameter)
    {
        await Task.Delay(TimeSpan.FromSeconds(1));
        throw new InvalidOperationException("Test");
    }
}