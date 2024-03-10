namespace Task_14._4;

public class AsyncOperationManager
{
    private readonly AsyncLocalGuidStack _operationIds = new AsyncLocalGuidStack();

    public async Task DoLongOperationAsync()
    {
        using (_operationIds.Push(Guid.NewGuid()))
        {
            await DoSomeStepOfOperationAsync();
        }
    }

    private async Task DoSomeStepOfOperationAsync()
    {
        await Task.Delay(100);
        Console.WriteLine("In operation: " + string.Join(":", _operationIds.Values));
    }
}