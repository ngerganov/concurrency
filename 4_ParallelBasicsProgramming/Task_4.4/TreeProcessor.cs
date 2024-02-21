namespace Task4._4;

public class TreeProcessor
{
    public static void Traverse(Node current)
    {
        DoExpensiveActionOnNode(current);
        if (current.Left != null)
        {
            Task.Factory.StartNew(
                () => Traverse(current.Left),
                CancellationToken.None,
                TaskCreationOptions.AttachedToParent,
                TaskScheduler.Default);
        }
        if (current.Right != null)
        {
            Task.Factory.StartNew(
                () => Traverse(current.Right),
                CancellationToken.None,
                TaskCreationOptions.AttachedToParent,
                TaskScheduler.Default);
        }
    }

    public static void ProcessTree(Node root)
    {
        Task task = Task.Factory.StartNew(
            () => Traverse(root),
            CancellationToken.None,
            TaskCreationOptions.None,
            TaskScheduler.Default);
        task.Wait();
    }

    private static void DoExpensiveActionOnNode(Node node)
    {
        Thread.Sleep(TimeSpan.FromSeconds(2));
    }
}