using System.Drawing;

namespace Task_6._3;

public class MouseEventArgs : EventArgs
{
    public int X { get; }
    public int Y { get; }

    public MouseEventArgs(int x, int y)
    {
        X = x;
        Y = y;
    }
}