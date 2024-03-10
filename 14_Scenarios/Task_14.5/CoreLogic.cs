namespace Task_14._5;

public class CoreLogic
{
    private async Task<int> DelayAndReturnCore(bool sync)
    {
        int value = 100;
        if (sync)
            Thread.Sleep(value);
        else
            await Task.Delay(value);
        return value;
    }

    public Task<int> DelayAndReturnAsync() =>
        DelayAndReturnCore(sync: false);

    public int DelayAndReturn() =>
        DelayAndReturnCore(sync: true).GetAwaiter().GetResult();
}