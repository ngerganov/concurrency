using System.Reactive;
using System.Reactive.Linq;

namespace Task_6._1;

public class ObservableEventProcessor
{
    public IObservable<EventPattern<TEventArgs>> FromEventPattern<TEventArgs>(
        Action<EventHandler<TEventArgs>> addHandler,
        Action<EventHandler<TEventArgs>> removeHandler)
    {
        return Observable.FromEventPattern<TEventArgs>(addHandler, removeHandler);
    }

    public IObservable<EventPattern<object>> FromEventPattern(object source, string eventName)
    {
        return Observable.FromEventPattern(source, eventName);
    }
}