using System.Drawing;
using System.Reactive.Linq;

namespace Task_6._3;

public class MouseEventsHandler
{
    public event EventHandler<MouseEventArgs> MouseMoved;

    public void SimulateMouseMovement()
    {
        Observable.Interval(TimeSpan.FromSeconds(1))
            .Take(10)
            .Subscribe(_ =>
            {
                OnMouseMoved(new MouseEventArgs(0, 0));
            });
    }

    protected virtual void OnMouseMoved(MouseEventArgs e)
    {
        MouseMoved?.Invoke(this, e);
    }
}