using Nito.AsyncEx;

namespace Task_12._4;

public class AsyncManualResetEventWrapper
{
    private readonly AsyncManualResetEvent _connected = new AsyncManualResetEvent();

    public async Task WaitForConnectedAsync()
    {
        await _connected.WaitAsync();
    }

    public void ConnectedChanged(bool connected)
    {
        if (connected)
            _connected.Set();
        else
            _connected.Reset();
    }
}