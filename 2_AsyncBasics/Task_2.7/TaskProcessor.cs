namespace Task2._7;

public class TaskProcessor
{
    public async Task ResumeOnContextAsync()
    {
        await Task.Delay(TimeSpan.FromSeconds(1));
    }

    public async Task ResumeWithoutContextAsync()
    {
        await Task.Delay(TimeSpan.FromSeconds(1)).ConfigureAwait(false);
    }
}