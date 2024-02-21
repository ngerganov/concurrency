using System.Threading.Tasks.Dataflow;

namespace Task5._3;

public static class DataFlowLinkManager
{
    public static IDisposable CreateLink(TransformBlock<int, int> source, TransformBlock<int, int> target)
    {
        return source.LinkTo(target);
    }

    public static void RemoveLink(IDisposable link)
    {
        using (link)
        {
            
        }
    }
}