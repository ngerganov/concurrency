using System.Reactive.Linq;

namespace Task_14._7;

public static class ObservableProgress
{
    public static (IObservable<T>, IProgress<T>) CreateForUi<T>(TimeSpan? sampleInterval = null)
    {
        var (observable, progress) = Create<T>();
        if (SynchronizationContext.Current != null)
            observable = observable
                .Sample(sampleInterval ?? TimeSpan.FromMilliseconds(100))
                .ObserveOn(SynchronizationContext.Current);
        return (observable, progress);
    }

    private static (IObservable<T>, IProgress<T>) Create<T>()
    {
        var progress = new EventProgress<T>();
        var observable = Observable.FromEvent<T>(
            handler => progress.OnReport += handler,
            handler => progress.OnReport -= handler);
        return (observable, progress);
    }

    private class EventProgress<T> : IProgress<T>
    {
        public event Action<T>? OnReport;

        void IProgress<T>.Report(T value) => OnReport?.Invoke(value);
    }
}