using System.Threading.Tasks.Dataflow;

namespace Task5._4;

public static class DataFlowLinkManager
{
    public static void CreateLink(BufferBlock<int> source, BufferBlock<int> target)
    {
        source.LinkTo(target);
    }
}