using System.Threading.Tasks.Dataflow;

namespace Task5._4;

class Program
{
    static void Main(string[] args)
    {
        var sourceBlock = DataFlowBlocks.CreateSourceBlock();
        var options = new DataflowBlockOptions { BoundedCapacity = 1 };
        var targetBlockA = DataFlowBlocks.CreateTargetBlock(options);
        var targetBlockB = DataFlowBlocks.CreateTargetBlock(options);

        DataFlowLinkManager.CreateLink(sourceBlock, targetBlockA);
        DataFlowLinkManager.CreateLink(sourceBlock, targetBlockB);
    }
}