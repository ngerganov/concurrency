using System.Threading.Tasks.Dataflow;

namespace Task5._6;

class Program
{
    static void Main(string[] args)
    {
        var customBlock = CustomDataFlowBlock.CreateMyCustomBlock();

        customBlock.Post(4);
        customBlock.Post(6);
        customBlock.Post(8);

        customBlock.Complete();

        Console.WriteLine("Результаты обработки данных:");
        Console.WriteLine(customBlock.Receive());
        Console.WriteLine(customBlock.Receive());
        Console.WriteLine(customBlock.Receive());
    }
}