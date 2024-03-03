using Nito.AsyncEx;

namespace Task_11._5;

public class MyEventArgs : EventArgs, IDeferralSource
{
    private readonly DeferralManager _deferrals = new DeferralManager();

    public string Message { get; }

    public MyEventArgs(string message)
    {
        Message = message;
    }

    public IDisposable GetDeferral()
    {
        return _deferrals.DeferralSource.GetDeferral();
    }

    internal Task WaitForDeferralsAsync()
    {
        return _deferrals.WaitForDeferralsAsync();
    }
}