namespace Task_9._5;

class Program
{
    static void Main(string[] args)
    {
        ConcurrentDictionaryExample example = new ConcurrentDictionaryExample();

        example.AddOrUpdateExample();
        example.ReadExample();
        example.RemoveExample();
    }
}