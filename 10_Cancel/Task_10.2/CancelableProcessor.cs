namespace Task_10._2;

public class CancelableProcessor
{
    public int CancelableMethod(CancellationToken cancellationToken)
    {
        for (int i = 0; i != 10; ++i)
        {
            Thread.Sleep(1000);
            cancellationToken.ThrowIfCancellationRequested();
        }
        return 42;
    }

    public int CancelableMethodWithLimit(CancellationToken cancellationToken)
    {
        for (int i = 0; i != 1000; ++i)
        {
            Thread.Sleep(1);
            if (i % 100 == 0)
                cancellationToken.ThrowIfCancellationRequested();
        }
        return 42;
    }
}