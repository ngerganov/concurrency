using System.Threading.Tasks.Dataflow;
using NUnit.Framework;

namespace Task_7._4;

public class Tests
{
    [Test]
    public async Task MyCustomBlock_TransformBlock_AddsOneToDataItems()
    {
        var myCustomBlock = new MyCustomBlock();
        var outputBuffer = new BufferBlock<int>();

        myCustomBlock.SourceBlock.LinkTo(outputBuffer);

        myCustomBlock.TargetBlock.Post(3);
        myCustomBlock.TargetBlock.Post(13);

        myCustomBlock.Complete();
        await myCustomBlock.Completion;

        Assert.AreEqual(4, await outputBuffer.ReceiveAsync());
        Assert.AreEqual(14, await outputBuffer.ReceiveAsync());
    }

    [Test]
    public async Task MyCustomBlock_TransformBlock_Fault_DiscardsDataAndFaults()
    {
        var myCustomBlock = new MyCustomBlock();
        var outputBuffer = new BufferBlock<int>();

        myCustomBlock.SourceBlock.LinkTo(outputBuffer);

        myCustomBlock.TargetBlock.Post(3);
        myCustomBlock.TargetBlock.Post(13);

        myCustomBlock.Fault(new InvalidOperationException());

        await Task.Delay(100);

        Console.WriteLine("Buffer block contents:");
        while (outputBuffer.TryReceive(out var item))
        {
            Console.WriteLine(item);
        }

        Assert.IsFalse(outputBuffer.TryReceive(out _));
    }
}