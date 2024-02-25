namespace Task_9._7;

class Program
{
    static void Main(string[] args)
    {
        BlockingCollectionDemo blockingCollectionDemo = new BlockingCollectionDemo();

        blockingCollectionDemo.AddElementsToBlockingStack();
        blockingCollectionDemo.ConsumeElementsFromBlockingStack();
        blockingCollectionDemo.AddElementsToBlockingBag();
        blockingCollectionDemo.ConsumeElementsFromBlockingBag();
    }
}