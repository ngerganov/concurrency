using System.Threading.Tasks.Dataflow;

namespace Task5._5;

public static class DataFlowLinkManager
{
    public static void CreateLink(TransformBlock<int, int> source, TransformBlock<int, int> target)
    {
        source.LinkTo(target);
    }
}